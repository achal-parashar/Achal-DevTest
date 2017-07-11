using MasterDb.Domain.Abstract;
using MasterDb.Domain.Concrete;
using MasterDb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;
using System.Data.SqlClient;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Elmah;

namespace MasterDb.WebUI.Controllers
{
    public class WorkRequestController : Controller
    {
        private ITenantRepository TenantRepository;
        private ILookupRepository LookupRepository;
        private IUnitRepository UnitRepository;
        private IWorkRequestRepository WorkRequestRepository;
        public WorkRequestController()
        {
            this.TenantRepository = new TenantRepository();
            this.LookupRepository = new LookupRepository();
            this.WorkRequestRepository = new WorkRequestRepository();
            this.UnitRepository = new UnitRepository();
        }
        protected string RenderRazorViewToString(string view_name, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, view_name);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
      
        [Auth(Roles = "SYS-Admin")]
        public ActionResult WorkRequest(int workRequestId = 0)
        {
            WorkRequest model = new WorkRequest();
            model.ContextId = Convert.ToInt32(this.RouteData.Values["ContextId"].ToString());

            if (workRequestId > 0)
            {
                WorkRequestRepository.GetWorkRequestById(workRequestId, model);
                //Set Download Url For Each Document
                string downloadPath = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/Imports/WorkRequest/";
                foreach (var item in model.WorkRequestAttachments)
                    item.DownloadUrl = downloadPath + item.AttachmentName;
            }
            else
            {
                model.CreatedBy = ClaimsPrincipal.Current.FindFirst("FirstName").Value
                                   + " " + ClaimsPrincipal.Current.FindFirst("LastName").Value;
                var value = ClaimsPrincipal.Current.Claims.ToList();
                model.PriorityId = 0;
            }


            model.UnitTable.Add(new UnitForWorkRequest { UnitNbr = string.Empty, UnitId = 0 });

            return View(model);
        }
        [HttpPost]
        public ActionResult CreateWorkRequest(WorkRequest workrequestModel)
        {
            try
            {

                //get transaction detials
                var transaction = WorkRequestRepository.GetTransactionTypeList().Where(t => t.Id == workrequestModel.TransactionTypeId).FirstOrDefault();
                //Get transaction
                if (transaction != null && transaction.IsUnitSpecific)
                {
                    foreach (var item in workrequestModel.UnitTable)
                    {
                        if (item.UnitId > 0 && item.IsDeleted == false)
                        {
                            if (string.IsNullOrEmpty(workrequestModel.UnitIdsToMap))
                                workrequestModel.UnitIdsToMap += item.UnitId;
                            else
                                workrequestModel.UnitIdsToMap += "," + item.UnitId;
                        }

                    }
                }
                if (workrequestModel.SubTransactionTypeId.HasValue)
                    workrequestModel.TransactionTypeId = workrequestModel.SubTransactionTypeId ?? 0;
                if (workrequestModel.Id > 0)
                {
                    //if (workrequestModel.Emergency)
                    //    workrequestModel.PriorityId = null;
                    //if()
                    
                    workrequestModel.Id = WorkRequestRepository.UpdateWorkRequest(workrequestModel);
                    TempData["SUCCESS"] = "Updated Successfully.";
                }
                else
                {
                    workrequestModel.Id = WorkRequestRepository.CreateWorkRequest(workrequestModel);
                    TempData["SUCCESS"] = "Saved Successfully.";
                }

                return RedirectToAction("ListWorkRequest", new { ContextId = workrequestModel.ContextId });
            }
            catch (SqlException sex)
            {
                ErrorSignal.FromCurrentContext().Raise(sex); // Log it via ELMAH
                TempData["ERROR"] = sex.Message;
                return RedirectToAction("ListWorkRequest", new { ContextId = workrequestModel.ContextId });

            }
            catch (Exception ex)
            {
                ErrorSignal.FromCurrentContext().Raise(ex); // Log it via ELMAH
                TempData["ERROR"] = ex.Message;
                return RedirectToAction("ListWorkRequest", new { ContextId = workrequestModel.ContextId });


            }

        }
        
        [Auth(Roles = "SYS-Admin")]
        [HttpPost]
        public ActionResult WorkRequestAttachment_Upload(IEnumerable<HttpPostedFileBase> uploadAttachment, int ContextId)
        {
            if (uploadAttachment.Count() < 1)
            {
                return null;
            }
            string Attachments = string.Empty;
            foreach (var uploadedFile in uploadAttachment)
            {
                try
                {
                    var uploadFile = uploadAttachment.First(); // First() will throw an exception if the list is empty.*/
                    string filename = Path.Combine(Path.GetDirectoryName(uploadFile.FileName), string.Concat(Path.GetFileNameWithoutExtension(uploadFile.FileName), DateTime.Now.ToString("-MM_dd_yyyy-HH_mm_ss_fff"), Path.GetExtension(uploadFile.FileName)));
                    var physicalPath = Server.MapPath("/Imports/WorkRequest/" + filename);
                    uploadFile.SaveAs(physicalPath);
                    if (string.IsNullOrEmpty(Attachments))
                        Attachments += filename;
                    else
                        Attachments += "," + filename;
                }
                catch (Exception ex)
                {
                    return new JsonResult { Data = new { Success = false, Response = ex.Message.ToString() } }; ;
                }
            }
            return new JsonResult { Data = new { Success = true, Response = "Uploaded", Attachments = Attachments } }; ;

        }

        [Auth(Roles = "SYS-Admin")]
        public FileResult WorkRequestDownload(string docName,string displayName)
        {
            string mime = MimeMapping.GetMimeMapping(displayName);
            byte[] file = System.IO.File.ReadAllBytes(Server.MapPath("/imports/workrequest/" + docName));
            return File(file, mime, displayName);
        }

        [OutputCache(Duration = 0, NoStore = true, VaryByParam = "*")]
        public ActionResult LoadBulkUnitResult(WorkRequest workrequestModel)
        {
            workrequestModel.UnitTable.RemoveAll(m => string.IsNullOrWhiteSpace(m.UnitNbr));
            workrequestModel.UnitTable.RemoveAll(m => m.IsDeleted);
            //Get Data for All the Added Items
            List<UnitForWorkRequest> unitForWork = new List<UnitForWorkRequest>();
            List<string> unitNbr = new List<string>();
            string message = string.Empty;
            foreach (var unit in workrequestModel.UnitTable)
            {
                if (unitNbr.Count > 0 && unitNbr.Contains(unit.UnitNbr))
                {

                    if (string.IsNullOrEmpty(message))
                        message += unit.UnitNbr;
                    else
                        message += "," + unit.UnitNbr;
                }
                else
                {
                    unitForWork.Add(unit);
                    unitNbr.Add(unit.UnitNbr);
                }
            }
            //Fill data for each of the existing items
            foreach (var unit in unitForWork)
            {
                var unitDetials = UnitRepository.GetUnitDetailsByUnitNbr(unit.UnitNbr, workrequestModel.DomainId);
                if (unitDetials != null && unitDetials.Id > 0)
                {
                    unit.UnitId = unitDetials.Id;
                    unit.UnitNbr = unitDetials.UnitNbr;
                    unit.Location = unitDetials.LocationName;
                    unit.TenantName = unitDetials.TenantName;
                    unit.Fleet = unitDetials.FleetNbr;
                    unit.Vin = unitDetials.Vin;
                }
            }
            //Identify Duplicate Items and remove them from list
            unitForWork.Add(new UnitForWorkRequest { UnitNbr = string.Empty, UnitId = 0 });
            workrequestModel.UnitTable.Clear();
            workrequestModel.UnitTable = unitForWork;

            string view = RenderRazorViewToString("_LoadBulkUnit", workrequestModel.UnitTable);



            var jsonResult = Json(new ActionOutput<string>
            {
                Status = ActionStatus.Successfull,
                Message = message,
                Object = view
            });
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;

        }

        #region WorkRequestList 

        [Auth(Roles = "SYS-Admin")]
        public ActionResult ListWorkRequest()
        {
            if (TempData["SUCCESS"] != null)
                ViewBag.Success = TempData["SUCCESS"].ToString();
            if (TempData["ERROR"] != null)
                ViewBag.Error = TempData["ERROR"].ToString();
            return View();
        }
        [Auth(Roles = "SYS-Admin")]
        public ActionResult WorkRequest_Read([DataSourceRequest] DataSourceRequest request, DateTime? start, DateTime? end, int? Statusid)
        {

            int ContextId = Convert.ToInt32(this.RouteData.Values["ContextId"]);
            if (Statusid == null)
                Statusid = 1;

            var items = from i in WorkRequestRepository.GetWorkRequestList(ContextId, start, end, Statusid)
                        select new { WorkRequestId = i.WorkRequestId, DomainName = i.DomainName, TransactionName = i.TransactionName, SubTransactionName = i.SubTransactionName, UnitCount = i.UnitCount, Status = i.Status, RequestDate = i.RequestDate };
            return Json(items.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [Auth(Roles = "SYS-Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult WorkRequest_Destroy([DataSourceRequest] DataSourceRequest request, ListWorkRequest ListWorkRequest)
        {
            int ContextId = Convert.ToInt32(this.RouteData.Values["ContextId"]);
            if (ListWorkRequest != null)
            {
                try
                {
                    WorkRequestRepository.DeleteWorkRequest(ListWorkRequest, ContextId);
                }
                catch (SqlException sex)
                {
                    ErrorSignal.FromCurrentContext().Raise(sex); // Log it via ELMAH
                    ModelState.AddModelError("CustomError", sex.Number + "|" + sex.Message);
                }
                catch (Exception ex)
                {
                    ErrorSignal.FromCurrentContext().Raise(ex); // Log it via ELMAH
                    ModelState.AddModelError("CustomError", ex.Message);
                }
            }
            return Json(new[] { ListWorkRequest }.ToDataSourceResult(request, ModelState));
        }
        public ActionResult FilterMenuCustomization_Transaction()
        {
            int ContextId = Convert.ToInt32(this.RouteData.Values["ContextId"]);
            var transactions = WorkRequestRepository.GetWorkRequestList(ContextId, null, null, 1).Select(t => t.TransactionName).Distinct().ToList();
            return Json(transactions, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FilterMenuCustomization_SubTransaction()
        {
            int ContextId = Convert.ToInt32(this.RouteData.Values["ContextId"]);
            var subtransactions = WorkRequestRepository.GetWorkRequestList(ContextId, null, null, 1).Select(t => t.SubTransactionName).Distinct().ToList();
            return Json(subtransactions, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FilterMenuCustomization_Domain()
        {
            int ContextId = Convert.ToInt32(this.RouteData.Values["ContextId"]);
            var domainname = WorkRequestRepository.GetWorkRequestList(ContextId, null, null, 1).Select(t => t.DomainName).Distinct().ToList();
            return Json(domainname, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region KendoDropDown Read
        public JsonResult WorkRequest_ReadStatus()
        {
            return Json(WorkRequestRepository.GetWorkRequestStatusList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult WorkRequest_ReadTransactionType()
        {
            return Json(WorkRequestRepository.GetTransactionTypeList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult WorkRequest_ReadSubTransaction(int parentId)
        {
            return Json(WorkRequestRepository.GetTransactionTypeList(parentId), JsonRequestBehavior.AllowGet);
        }
        public JsonResult WorkRequest_ReadRequestOrigin()
        {
            return Json(WorkRequestRepository.GetRequestOriginList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult WorkRequest_ReadDomainProject(int domainId)
        {
            int ContextId = Convert.ToInt32(this.RouteData.Values["ContextId"]);
            var items = LookupRepository.GetProjectList(ContextId)
                         .Where(x => x.Domainid == domainId).ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetTransactionDetails(int transactionId)
        {
            var data = WorkRequestRepository.GetTransactionTypeList().Where(t => t.Id == transactionId).FirstOrDefault();
            //Get Count of subtransaction items
            if (WorkRequestRepository.GetTransactionTypeList(transactionId).Count() > 0)
                data.HaveSubTransaction = "Y";
            else
                data.HaveSubTransaction = "N";
            var jsonResult = Json(new ActionOutput<TransactionType>
            {
                Status = ActionStatus.Successfull,
                Object = data
            });
            return jsonResult;
        }
        [HttpPost]
        public ActionResult GetDomainDetails(int domainId)
        {
            int ContextId = Convert.ToInt32(this.RouteData.Values["ContextId"]);
            string message = string.Empty;
            var items = LookupRepository.GetProjectList(ContextId)
                         .Where(x => x.Domainid == domainId).ToList();
            if (items != null && items.Count > 0)
                message = "Y";
            else
                message = "N";
            var jsonResult = Json(new ActionOutput<string>
            {
                Status = ActionStatus.Successfull,
                Message = message
            });
            return jsonResult;
        }

        public JsonResult WorkRequest_ReadPriority()
        {
            List<SelectListItem> lstPriority = new List<SelectListItem>();
            lstPriority.Add(new SelectListItem {Text="Normal",Value="0" });
            lstPriority.Add(new SelectListItem { Text = "High", Value = "1" });
            return Json(lstPriority.OrderBy(l=>l.Value), JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}
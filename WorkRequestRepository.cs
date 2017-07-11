using MasterDb.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDb.Domain.Entities;
using System.Web.Mvc;
using System.Security.Claims;
using System.IO;

namespace MasterDb.Domain.Concrete
{
    public class WorkRequestRepository : IWorkRequestRepository
    {
        private MasterDbDataContext context;

        public WorkRequestRepository()
        {
            this.context = new MasterDbDataContext();
        }
        public List<TransactionType> GetTransactionTypeList(int parentid = 0)
        {

            return context.GetTransactionTypeList(parentid).Select(t => new TransactionType
            {
                Id = t.Id,
                BuId = t.BusinessUnitId,
                Name = t.Name,
                ParentId = t.ParentId,
                IsUnitSpecific = t.IsUnitSpecific
            }).ToList();


        }
        public List<SelectListItem> GetRequestOriginList()
        {
            return context.GetRequestOriginList().Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            }).ToList();
        }
        public List<Status> GetWorkRequestStatusList()
        {
            return context.GetWorkRequestStatus().Select(t => new Status
            {
                Id = t.Id,
                StatusTypeId = t.StatusTypeId,
                Name = t.Name,
                StatusTypeName = t.Name
            }).ToList();
        }
        public int CreateWorkRequest(WorkRequest workRequest)
        {
            var UserId = Convert.ToInt32(ClaimsPrincipal.Current.FindFirst("UserId").Value);
            return context.CreateWorkRequest(
                  UserId,
                  workRequest.DomainId,
                  workRequest.StatusId,
                  workRequest.TransactionTypeId,
                  workRequest.RequestOriginId,
                  workRequest.TransactionDescription,
                  workRequest.RequestDate,
                  workRequest.SpecialProjectId,
                  workRequest.ContactPersonName,
                  workRequest.AttachedDocList,
                  UserId,
                  workRequest.UnitIdsToMap,
                  true,
                  UserId,
                  null,
                  workRequest.Emergency,
                  workRequest.Comments,
                  workRequest.FollowUpDate
              );

        }
        public int UpdateWorkRequest(WorkRequest workRequest)
        {
            var UserId = Convert.ToInt32(ClaimsPrincipal.Current.FindFirst("UserId").Value);
            return context.UpdateWorkRequest(
                  UserId,
                  workRequest.Id,
                  workRequest.StatusId,
                  workRequest.RequestOriginId,
                  workRequest.TransactionDescription,
                  workRequest.RequestDate,
                  workRequest.SpecialProjectId,
                  workRequest.ContactPersonName,
                  workRequest.AttachedDocList,
                  UserId,
                  workRequest.UnitIdsToMap,
                  true,
                  UserId,
                  null,
                  workRequest.Emergency,
                  workRequest.Comments,
                  workRequest.FollowUpDate
              );
        }
        public IEnumerable<MasterDb.Domain.Entities.ListWorkRequest> GetWorkRequestList(int ContextId)
        {
            int UserId = Convert.ToInt32(ClaimsPrincipal.Current.FindFirst("UserId").Value);
            IList<MasterDb.Domain.Entities.ListWorkRequest> WorkRequestList = new List<MasterDb.Domain.Entities.ListWorkRequest>();
            foreach (var WorkRequest in context.GetWorkRequestDetails(UserId, ContextId).ToList())
            {
                WorkRequestList.Add(new MasterDb.Domain.Entities.ListWorkRequest()
                {
                    WorkRequestId = WorkRequest.WorkRequestId
                    ,
                    DomainName = WorkRequest.DomainName
                    ,
                    TransactionName = WorkRequest.TransactionName
                    ,
                    SubTransactionName = WorkRequest.SubTransaction
                    ,
                    UnitCount = WorkRequest.UnitCount
                    ,
                    Status = WorkRequest.Status
                });
            }
            return WorkRequestList;
        }

        public void DeleteWorkRequest(ListWorkRequest ListWorkRequest, int ContextId)
        {
            int UserId = Convert.ToInt32(ClaimsPrincipal.Current.FindFirst("UserId").Value);
            context.DeleteWorkRequest(
               UserId
               , ContextId
               , ListWorkRequest.WorkRequestId
            );
        }

        public WorkRequest GetWorkRequestById(int workRequestId, WorkRequest workRequest)
        {
            int UserId = Convert.ToInt32(ClaimsPrincipal.Current.FindFirst("UserId").Value);
            var data = context.GetWorkRequestById(workRequestId, UserId).FirstOrDefault();
            if (data != null)
            {
                var userDetails = context.GetUserById(data.createdby).FirstOrDefault();
                workRequest.Id = data.id;
                workRequest.StatusId = data.statusid;
                workRequest.CreatedBy = userDetails.FirstName + " " + userDetails.LastName;
                workRequest.DomainId = data.domainid;
                workRequest.RequestOriginId = data.requestoriginid ?? 0;
                workRequest.RequestDate = data.requestdate;
                workRequest.ContactPersonName = data.contactname;
                workRequest.TransactionDescription = data.description;
                workRequest.SpecialProjectId = data.projectid;
                workRequest.Emergency = data.emergency??false;
                workRequest.Comments = data.comments;
                workRequest.FollowUpDate = data.FollowUpDate;
                //workRequest.AttachedDocList = data.a;
                //Get Transaction Detils from database
                if (data.ParentId > 0)
                {
                    workRequest.TransactionTypeId = data.ParentId;
                    workRequest.SubTransactionTypeId = data.transactiontypeid;
                }
                else
                    workRequest.TransactionTypeId = data.transactiontypeid;

                workRequest.IsUnitSpecific = data.IsUnitSpecific;
                //find all the unit details
                workRequest.UnitTable = context.GetWorkRequestUnitsById(workRequestId, UserId)
                                        .Select(u => new UnitForWorkRequest
                                        {
                                            UnitId = u.UnitId,
                                            UnitNbr = u.UnitNbr,
                                            Location = u.Location,
                                            TenantName = u.Company,
                                            Fleet = u.Unit_Fleet,
                                            Vin = u.Vin
                                        }).ToList();
                workRequest.WorkRequestAttachments = context.GetWorkRequestAttachmentById(workRequestId, UserId)
                                        .Select(a => new Attachments
                                        {
                                            AttachmentName = a.AttachmentName,
                                            AttachmentId = a.AttachmentId,
                                            AttachmentExtension = Path.GetExtension(a.AttachmentName).Substring(1),
                                            AttachmentDisplayName = a.AttachmentName.Split('-')[0] + "." + Path.GetExtension(a.AttachmentName).Substring(1)
                                        }).ToList();

            }
            return workRequest;
        }

    }
}

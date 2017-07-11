
//---------------------------------------------------------------------
// Author: Hans
// Version: 1.0.0
// Date: 10/03/2011
// Description:Implement Data Request Bussiness Class
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;

using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;

using CQM.Entities;
using CQM.Resource;
using CQM.Common.ExecutionResults;

namespace CQM.Business
{
    /// <summary>
    /// Implements Matter business class
    /// </summary>
    /// <author></author>
    /// <creationDate>2011-10-03</creationDate>
    /// <modifications>
    /// <item>Date ;By ;Description</item>
    /// <item>Date ;By ;Description</item>
    /// </modifications>
    public class DataRequest
    {

        private static DataRequest _dataRequest;
        /// <summary>
        /// This is a singleton Class object which will be used across the application
        /// to invoke common functions available 
        /// </summary>
        /// <returns></returns>
        public static DataRequest DataRequestBusinessInstance
        {
            //Singleton Pattern
            get
            {
                if (_dataRequest == null)
                    _dataRequest = new DataRequest();
                return _dataRequest;
            }
        }
        /// <summary>
        /// Implements the business action - FindDataRequestSetEntityByCaseNumber.
        /// </summary>
        public List<DataRequestSetEntity> FindDataRequestSetEntityByCaseNumber(System.String CaseNumber, System.String UserID, Int32 PageSize, Int32 CurrentPageNumber, String SortExp)
        {
            //Process object data
            List<DataRequestSetEntity> result = null;

            ResDataRequest ObjDRSet = new ResDataRequest();
            result = ResDataRequest.DataRequestResourceInstance.FindDRSetListByCaseNumber(CaseNumber, UserID, PageSize, CurrentPageNumber, SortExp);
           
            if (result.Count > 0)
            {
                List<DataRequestSetEntity> targetList = new List<DataRequestSetEntity>();
                targetList = result;
                for (int x = 0; x < result.Count; x++)
                {
                    if (result[x].RequestedByCompany > 0)
                    {
                        List<ItemEntity> objItemList = ResDataRequest.DataRequestResourceInstance.GetDropDownValue(result[x].RequestedByCompany.ToString(), "DRSET_LIST_GET_REQUESTEDBYNAME");
                        if (objItemList.Count > 0)
                        {
                            //targetList[x].RequestedByName = objItemList[0].ItemDesc;
                            if (objItemList[0].ItemCode != null)
                                targetList[x].RequestedByName = objItemList[0].ItemDesc + "(" + objItemList[0].ItemCode + ")";
                            else
                                targetList[x].RequestedByName = objItemList[0].ItemDesc;
                        }
                    }

                    if (result[x].PropoundedUponIndividual > 0)
                    {
                        List<ItemEntity> objItemList = ResDataRequest.DataRequestResourceInstance.GetDropDownValue(result[x].PropoundedUponIndividual.ToString(), "CREATE_UPD_DR_GET_MEMBER_IND_NAME");
                        if (objItemList.Count > 0)
                            targetList[x].PropoundedUponName = objItemList[0].ItemDesc;                        
                    }

                    if (result[x].PropoundedUponStaff != null)
                    {
                        targetList[x].PropoundedUponName = result[x].PropoundedUponStaff;
                    }


                    if (System.Convert.ToDateTime(result[x].UpdatedDate) == DateTime.MinValue)
                        targetList[x].UpdatedDate = result[x].CreatedDate;
                    else
                        targetList[x].UpdatedDate = result[x].UpdatedDate;

                    if (string.IsNullOrEmpty(result[x].UpdatedBy))
                        targetList[x].UpdatedBy = result[x].CreatedBy;
                    else
                        targetList[x].UpdatedBy = result[x].UpdatedBy;
                }
                result = targetList;
            }
           


            return result;
        }

        public DataRequestSetEntity GetDataRequestListDetails(DataRequestSetEntity ObjDataRequestSetEntity)
        {
            DataRequestSetEntity ObjDataRequestSetEntityResult = new DataRequestSetEntity();
            try
            {
                ObjDataRequestSetEntityResult = ResDataRequest.DataRequestResourceInstance.GetDataRequestListDetails(ObjDataRequestSetEntity);
                //if (ObjDataRequestSetEntityResult.DRItemEntityList != null)
                //{
                //    ObjDataRequestSetEntity.CaseNumber

                //}
            }
            catch
            {
                throw;
            }
            return ObjDataRequestSetEntityResult;
        }

        public DataRequestQuestionEntity GetDataRequestQuestion(DataRequestQuestionEntity ObjDataRequestQuestionEntity)
        {
            DataRequestQuestionEntity ObjReturn = new DataRequestQuestionEntity();
            try
            {
                ObjReturn = ResDataRequest.DataRequestResourceInstance.GetDataRequestQuestion(ObjDataRequestQuestionEntity);

                if (ObjReturn.DRDocumentEntityList.Count > 0)
                {
                    List<DataRequestDocumentEntity> targetList = new List<DataRequestDocumentEntity>();
                    targetList = ObjReturn.DRDocumentEntityList;
                    string checked1 = "";
                    for (int x = 0; x < ObjReturn.DRDocumentEntityList.Count; x++)
                    {
                        if (!string.IsNullOrEmpty(ObjReturn.DRDocumentEntityList[x].POrders))
                        {
                            try
                            {
                                string[] arr = ObjReturn.DRDocumentEntityList[x].POrders.Split(',');
                                foreach (string arrstring in arr)
                                {
                                    List<ItemEntity> objItemList = ResDataRequest.DataRequestResourceInstance.GetDropDownValue(arrstring.ToString(), "DR_QUESRESP_GET_PORDERS");
                                    if (checked1 == "")
                                    { checked1 = objItemList[0].ItemDesc; }
                                    else
                                    { checked1 = checked1 + "," + objItemList[0].ItemDesc; }

                                }
                                targetList[x].JustificationDocSecurity = targetList[x].POrders;
                                targetList[x].POrders = checked1;
                            }
                            catch (Exception ex)
                            { }
                        }


                    }
                    ObjReturn.DRDocumentEntityList = targetList;
                }
            
            }
            catch
            {
                throw;
            }
            return ObjReturn;
        }

        public List<DataRequestQuestionEntity> GetDataRequestListOnDRSet(DataRequestSetEntity ObjDataRequestSetEntity)
        {
            List<DataRequestQuestionEntity> ObjDataRequestQuestionEntityList = new List<DataRequestQuestionEntity>();
            try
            {
                ObjDataRequestQuestionEntityList = ResDataRequest.DataRequestResourceInstance.GetDataRequestListOnDRSet(ObjDataRequestSetEntity);
            }
            catch
            {
                throw;
            }
            return ObjDataRequestQuestionEntityList;
        }


        public DataRequestResponseEntity GetDataRequestRespOnQuesSeq(DataRequestResponseEntity ObjDataRequestResponseEntity)
        {
            DataRequestResponseEntity ObjReturn = new DataRequestResponseEntity();
            try
            {
                ObjReturn = ResDataRequest.DataRequestResourceInstance.GetDataRequestRespOnQuesSeq(ObjDataRequestResponseEntity);
            }
            catch
            {
                throw;
            }
            return ObjReturn;
        }

        public List<ItemEntity> GetDropDownValue(string TypeCode, string Module)
        {
            List<ItemEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDropDownValue(TypeCode, Module);                
            }
            catch
            {
                throw;
            }
            return result;
        }

        public DataRequestSetEntity CreateDRSet(DataRequestSetEntity DRSetObj)
        {
           
           DataRequestSetEntity result = null;
           try
           {
               result = ResDataRequest.DataRequestResourceInstance.CreateDRSet(DRSetObj);
               if (result.IsSuccessfull && DRSetObj.DRSetStatus.Equals("1"))
               {
                   try
                   {
                       //EMail to Propoundedupon
                       if (result.IsSuccessfull)
                       {
                           CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                           objNotificationInputEntity.EventCode = "E0036";
                           objNotificationInputEntity.TrckingReferenceNumber = result.DRSetSeq.ToString();
                           CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);

                           CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                           result.notificationStatus = (int)ObjEmailSendAcknowledgement.SendStatus;
                       }
                   }
                   catch (Exception exd)
                   { }
               }
           }
           catch
           {
               throw;
           }

            return result;
        }

        public ContactEntity InsertContact(ContactEntity contactEntity)
        {
            ContactEntity result = new ContactEntity();
            try
            {
                //Process object data
                result = ResDataRequest.DataRequestResourceInstance.InsertContact(contactEntity);
                
                
            }
            catch
            {
                throw;
            }
            return result;
        }

        public List<ContactEntity> SearchContactModified(ContactEntity contactEntity, System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            List<ContactEntity> result = new List<ContactEntity>();
            try
            {
                ResMatter objResMatter = new ResMatter();
                result = ResDataRequest.DataRequestResourceInstance.SearchContactModified(contactEntity, pageSize, pageNumber, sortBy);
                
            }
            catch
            {
                throw;
            }
            return result;
        }

        /// <summary>
        /// Implements the business action - FindDataRequestSetEntityByDRSetSeq.
        /// </summary>
        public DataRequestSetEntity FindDataRequestSetEntityByDRSetSeq(System.Int32 drSetSeq)
        {
            //Process object data
            DataRequestSetEntity result = null;            
            result = ResDataRequest.DataRequestResourceInstance.FindDataRequestSetEntityByDRSetSeq(drSetSeq);

            List<DataRequestQuestionEntity> targetQList = result.DRQuestionEntityList;
            int cnt = 0;
           foreach( DataRequestQuestionEntity obj in result.DRQuestionEntityList)
           {
               List<DataRequestDocumentEntity> docList = GetDRDocumentList(obj.DRQuesSeq, "DRQ");
               
               targetQList[cnt].DRDocumentEntityList = docList;
               cnt++;
            }
           result.DRQuestionEntityList = targetQList;
           if (result.DRSetSeq > 0)
           {
               List<DataRequestDocumentEntity> doc2List = GetDRDocumentList(result.DRSetSeq, "DRS");
               result.DRDocumentEntityList = doc2List;
           }
            return result;
        }

        /// <summary>
        /// Implements the business action - UpdateDRSet.
        /// </summary>
        public DataRequestSetEntity UpdateDRSet(DataRequestSetEntity dataRequestSetEntity)
        {            
            //Process object data
            DataRequestSetEntity result = null;
            result = ResDataRequest.DataRequestResourceInstance.UpdateDRSet(dataRequestSetEntity);
            return result;           
        }

        public bool DeleteDRSet(System.Int32 drSetSeq)
        {
            //Process object data
            bool result = false;
            result = ResDataRequest.DataRequestResourceInstance.DeleteDRSet(drSetSeq);
            return result;      

        }

        public System.Int32 CreateDataRequestResponse(DataRequestResponseEntity ObjDataRequestResponseEntity)
        {
            System.Int32 nOutput = 0;
            try
            {
                nOutput = ResDataRequest.DataRequestResourceInstance.CreateDataRequestResponse(ObjDataRequestResponseEntity);
                if (nOutput > 0 && ObjDataRequestResponseEntity.Status.Equals("1"))
                {
                    try
                    {
                        //Added By Ashish Mamodia for DEFW36 on 23 Oct 2012
                        if (ObjDataRequestResponseEntity.ProcType == "SuplResponse")
                        {
                            CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                            objNotificationInputEntity.EventCode = "E0102";
                            objNotificationInputEntity.TrckingReferenceNumber = nOutput.ToString();
                            CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);

                            CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                            int notificationStatus = (int)ObjEmailSendAcknowledgement.SendStatus;
                        }
                        else
                        {
                            CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                            objNotificationInputEntity.EventCode = "E0038";
                            objNotificationInputEntity.TrckingReferenceNumber = nOutput.ToString();
                            CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);

                            CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                            int notificationStatus = (int)ObjEmailSendAcknowledgement.SendStatus;
                        }
                        //End By Ashish Mamodia for DEFW36 on 23 Oct 2012
                    }
                    catch (Exception ext)
                    { }
                  }
            }
            catch
            {
                throw;
            }
            return nOutput;
        }

        // Added by Anuj Singh---start---12-11-2013

        public System.Int32 GetDataSubmitedResponse(DataRequestResponseEntity ObjDataRequestResponseEntity)
        {
            System.Int32 nOutput = 0;

            try
            {
                nOutput = ResDataRequest.DataRequestResourceInstance.GetDataSubmittedRespOnQuesSeq(ObjDataRequestResponseEntity);
            }
            catch { }
            return nOutput;
        }

        // Added by Anuj Singh---end---12-11-2013



        /// <summary>
        /// Implements the business action - FindDRCaseByCaseNumber.
        /// </summary>
        public List<DataRequestSetEntity> FindDRCaseByCaseNumber(System.String CaseNumber)
        {
            //Process object data
            List<DataRequestSetEntity> result = null;
            ResDataRequest ObjDRSet = new ResDataRequest();
            result = ResDataRequest.DataRequestResourceInstance.FindDRCaseByCaseNumber(CaseNumber);            
            return result;
        }
        /// <Added By : Manoj> On 15 June 2013 
        /// Implements the business action - FindDRCaseList.
        /// </summary>
        public List<DataRequestSetEntity> FindDRCaseList(System.String CaseNumber, System.String UserId, System.String ShowAll, System.String Sortingby)
        {
            //Process object data
            List<DataRequestSetEntity> result = null;
            ResDataRequest ObjDRSet = new ResDataRequest();
            result = ResDataRequest.DataRequestResourceInstance.FindDRCaseList(CaseNumber, UserId, ShowAll, Sortingby);
            return result;
        }

        /// <summary>
        /// Implements the business action - GetDRDocumentList.
        /// </summary>
        public List<DataRequestDocumentEntity> GetDRDocumentList(System.Int32 drSeq, string drType)
        {            
            List<DataRequestDocumentEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRDocumentList(drSeq, drType);
            }
            catch(Exception ex)
            {
                throw ex; 
            }
            return result;
        }

        /// <summary>
        /// Implements the business action - GetDRProtectDocList.
        /// </summary>
        public List<DataRequestDocumentEntity> GetDRProtectDocList(string caseNumber)
         {

            List<DataRequestDocumentEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRProtectDocList(caseNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        /// <summary>
        /// Implements the business action - GetDRSearch.
        /// </summary>
        public List<DataRequestSearchRespEntity> GetDRSearch(DataRequestSearchEntity ObjDataRequestSearchEntity)
        {

            List<DataRequestSearchRespEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRSearch(ObjDataRequestSearchEntity);

                if (result.Count > 0)
                {
                    List<DataRequestSearchRespEntity> targetList = new List<DataRequestSearchRespEntity>();
                    targetList = result;
                    for (int x = 0; x < result.Count; x++)
                    {
                        if (result[x].RequestedByCompany > 0)
                        {
                            List<ItemEntity> objItemList = ResDataRequest.DataRequestResourceInstance.GetDropDownValue(result[x].RequestedByCompany.ToString(), "DRSET_LIST_GET_REQUESTEDBYNAME");
                            if (objItemList.Count > 0)
                                targetList[x].RequestedByName = objItemList[0].ItemDesc;
                        }

                        if (result[x].RequestedByIndividual > 0)
                        {

                            targetList[x].RequestedByName = result[x].RequestedByIndividual_s;
                        }

                        if (result[x].PropoundedUponCompany > 0)
                        {
                            List<ItemEntity> objItemList = ResDataRequest.DataRequestResourceInstance.GetDropDownValue(result[x].PropoundedUponCompany.ToString(), "DRSET_LIST_GET_REQUESTEDBYNAME");
                            if (objItemList.Count > 0)
                                targetList[x].PropoundedUponName = objItemList[0].ItemDesc;
                        }

                        //if (result[x].PropoundedUponIndividual > 0)
                        //{

                        //    targetList[x].PropoundedUponName = result[x].PropoundedUponIndividual_s;
                        //}

                        if (System.Convert.ToDateTime(result[x].UpdatedDate) == DateTime.MinValue)
                            targetList[x].UpdatedDate = result[x].CreatedDate;

                        if (string.IsNullOrEmpty(result[x].UpdatedBy))
                            targetList[x].UpdatedBy = result[x].CreatedBy;
                    }
                    result = targetList;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }


        public DataRequestResponseEntity GetDRQuesResponseByDRQuesSeq(DataRequestQuestionEntity ObjDataRequestQuestionEntity)
        {
            DataRequestResponseEntity result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRQuesResponseByDRQuesSeq(ObjDataRequestQuestionEntity);
                if (result.DRDocumentEntityList.Count > 0)
                {
                    List<DataRequestDocumentEntity> targetList = new List<DataRequestDocumentEntity>();
                    targetList = result.DRDocumentEntityList;
                    
                    for (int x = 0; x < result.DRDocumentEntityList.Count; x++)
                    {
                        string checked1 = "";
                        if (!string.IsNullOrEmpty(result.DRDocumentEntityList[x].POrders ))
                        {
                            try
                            {
                                if (result.DRDocumentEntityList[x].POrders.IndexOf('.') > 0)
                                {
                                    checked1 = result.DRDocumentEntityList[x].POrders;
                                }
                                else
                                {
                                    string[] arr = result.DRDocumentEntityList[x].POrders.Split(',');
                                    foreach (string arrstring in arr)
                                    {
                                        List<ItemEntity> objItemList = ResDataRequest.DataRequestResourceInstance.GetDropDownValue(arrstring.ToString(), "DR_QUESRESP_GET_PORDERS");
                                        if (checked1 == "")
                                        { checked1 = objItemList[0].ItemDesc; }
                                        else
                                        { checked1 = checked1 + "," + objItemList[0].ItemDesc; }

                                    }
                                }
                                targetList[x].JustificationDocSecurity = targetList[x].POrders;
                                targetList[x].POrders = checked1;
                            }
                            catch (Exception ex2)
                            { }                        
                        }

                        
                    }
                    result.DRDocumentEntityList = targetList;
                }

            
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<DataRequestSearchRespEntity> GetDRViewBySet(DataRequestSearchEntity ObjDataRequestSearchEntity)
        {
            List<DataRequestSearchRespEntity> result = null;
             try
             {
                 result = ResDataRequest.DataRequestResourceInstance.GetDRViewBySet(ObjDataRequestSearchEntity);
             }
             catch (Exception ex)
             { throw ex; 
             }

             return result;
        }

        public DataRequestSupplQuestionEntity CreateSupplQuestion(DataRequestSupplQuestionEntity DRSetObj)
        {
            DataRequestSupplQuestionEntity result = new DataRequestSupplQuestionEntity();
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.CreateSupplQuestion(DRSetObj);
                //EMail to Propoundedupon
                if (result.DRSupplQuesSeq != 0)
                {
                    CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntity.EventCode = "E0100";
                    objNotificationInputEntity.TrckingReferenceNumber = result.DRSupplQuesSeq.ToString();
                    CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);

                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    //result.notificationStatus = (int)ObjEmailSendAcknowledgement.SendStatus;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public DataRequestQuestionEntity UpdateQuestionMetaData(DataRequestQuestionEntity dataRequestQuestionEntity)
        {

            DataRequestQuestionEntity result = new DataRequestQuestionEntity();
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.UpdateQuestionMetaData(dataRequestQuestionEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;

        }


        public CQM.Entities.ContentEntity ViewDocument(CQM.Entities.ContentEntity conEntity)
        {
            CQM.Entities.ContentEntity result= null;
            try
            {
                ResContentEngine objResContentEngine = new ResContentEngine();
                result=objResContentEngine.ViewDocument(conEntity);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public DataRequestResponseEntity GetDRSupQuesResponseByDRSupQuesSeq(DataRequestSupplQuestionEntity ObjDataRequestSupplQuestionEntity)
        {
            DataRequestResponseEntity result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRSupQuesResponseByDRSupQuesSeq(ObjDataRequestSupplQuestionEntity);
                if (result.DRDocumentEntityList.Count > 0)
                {
                    List<DataRequestDocumentEntity> targetList = new List<DataRequestDocumentEntity>();
                    targetList = result.DRDocumentEntityList;
                    string checked1 = "";
                    for (int x = 0; x < result.DRDocumentEntityList.Count; x++)
                    {
                        if (!string.IsNullOrEmpty(result.DRDocumentEntityList[x].POrders))
                        {
                            string[] arr = result.DRDocumentEntityList[x].POrders.Split(',');
                            foreach (string arrstring in arr)
                            {
                                List<ItemEntity> objItemList = ResDataRequest.DataRequestResourceInstance.GetDropDownValue(arrstring.ToString(), "DR_QUESRESP_GET_PORDERS");
                                if (checked1 == "")
                                { checked1 = objItemList[0].ItemDesc; }
                                else
                                { checked1 = checked1 + "," + objItemList[0].ItemDesc; }

                            }
                            targetList[x].JustificationDocSecurity = targetList[x].POrders;
                            targetList[x].POrders = checked1;
                        }


                    }
                    result.DRDocumentEntityList = targetList;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public List<DataRequestSearchRespEntity> GetDRSetList(DataRequestSearchEntity ObjDataRequestSearchEntity)
        {
            List<DataRequestSearchRespEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRSetList(ObjDataRequestSearchEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<DataRequestSupplQuestionEntity> GetDataRequestSupplQuestion(DataRequestQuestionEntity ObjDataRequestQuestionEntity)
        {
            List<DataRequestSupplQuestionEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDataRequestSupplQuestion(ObjDataRequestQuestionEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<DataRequestResponseEntity> GetDRSupQuesResponseListByDRSupQuesSeq(DataRequestSupplQuestionEntity ObjDataRequestSupplQuestionEntity)
        {
            List<DataRequestResponseEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRSupQuesResponseListByDRSupQuesSeq(ObjDataRequestSupplQuestionEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<DataRequestResponseEntity> GetDRSupQuesResponseListByDRQuesSeq(DataRequestQuestionEntity ObjDataRequestQuestionEntity)
        {
            List<DataRequestResponseEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRSupQuesResponseListByDRQuesSeq(ObjDataRequestQuestionEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<ItemEntity> GetSetItemEntity(string TypeCode, string Module, string SetCode)
        {
            List<ItemEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetSetItemEntity(TypeCode, Module, SetCode);
            }
            catch
            {
                throw;
            }
            return result;
        }
        ///Implements the business action - GetDRCaseDetails.
        ///Added By:Nilesh Kumar
        /// Date:05/09/2012
        /// For DEFW35

        public DataRequestSearchRespEntity GetDRCaseDetails(System.String DRQuesSeq)
        {
            DataRequestSearchRespEntity ObjDataRequestSearchRespEntity = new DataRequestSearchRespEntity();
            try
            {
                ResDataRequest ObjDRSet = new ResDataRequest();

                ObjDataRequestSearchRespEntity = ResDataRequest.DataRequestResourceInstance.GetDRCaseDetails(DRQuesSeq);
            }
            catch
            {
                throw;
            }
            return ObjDataRequestSearchRespEntity;

        }

        //Added BY Ashish 
        public List<DataRequestResponseEntity> GetDRSupQuesResponseListForPrintByDRQuesSeq(DataRequestQuestionEntity ObjDataRequestQuestionEntity)
        {
            List<DataRequestResponseEntity> ObjDataRequestRespEntity = new List<DataRequestResponseEntity>();
            try
            {
                ResDataRequest ObjDRSet = new ResDataRequest();

                ObjDataRequestRespEntity = ResDataRequest.DataRequestResourceInstance.GetDRSupQuesResponseListForPrintByDRQuesSeq(ObjDataRequestQuestionEntity);
            }
            catch
            {
                throw;
            }
            return ObjDataRequestRespEntity;

        }

        /* 
            Added by            :Manoj kumar
            Added Date          :01 July 2013
            Description         :To get the DR Question listing whose response is not submitted yet.
        */
        public List<DataRequestQuestionEntity> GetDRPendingRespQueslist(DataRequestSetEntity ObjDataRequestSetEntity)
        {
            List<DataRequestQuestionEntity> ObjDataRequestQuestionEntityList = new List<DataRequestQuestionEntity>();
            try
            {
                ObjDataRequestQuestionEntityList = ResDataRequest.DataRequestResourceInstance.GetDRPendingRespQueslist(ObjDataRequestSetEntity);
            }
            catch
            {
                throw;
            }
            return ObjDataRequestQuestionEntityList;
        }

        /* 
            Added by            :Manoj kumar
            Added Date          :02 July 2013
            Description         :To get the DR Question listing by set whose response is not submitted yet.
        */

        public List<DataRequestSearchRespEntity> GetDRPendingRespQueslistBySet(DataRequestSearchEntity ObjDataRequestSearchEntity)
        {
            List<DataRequestSearchRespEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRPendingRespQueslistBySet(ObjDataRequestSearchEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        //Added By SUnayana Saxena DEFW037 22 august 2014

        public int GetDataReqNoOfQuestion(string DataReqSetID, string CaseNumber)
        {
            int result = 0;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDataReqNoOfQuestion(DataReqSetID, CaseNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        //end - Added By SUnayana Saxena DEFW037 22 august 2014
        //START CODE ADDED BY ACHAL FOR CQM120
        public List<DataRequestDocumentEntity> GetDRSuppleQuesDocList(System.Int32 drSuppQuesSeq, string drType)
        {
            List<DataRequestDocumentEntity> result = null;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.GetDRSuppleQuesDocList(drSuppQuesSeq, drType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //END CODE ADDED BY ACHAL FOR CQM120
        //START CODE ADDED BY ACHAL FOR CQM141 ON 3/02/2016
        public bool UpdateQuestionAndSuppQuesStatus(List<int> questions, List<int> supplQuestion)
        {
            bool result = false;
            try
            {
                result = ResDataRequest.DataRequestResourceInstance.UpdateQuestionAndSuppQuesStatus(questions, supplQuestion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //END CODE ADDED BY ACHAL FOR CQM141 ON 3/02/2016
    }


}
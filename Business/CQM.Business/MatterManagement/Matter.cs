//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/27/2007
// Description:Implement Matter Bussiness Class
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
using CQM.Common.Utility;

namespace CQM.Business
{
    /// <summary>
    /// Implements Matter business class
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-11-27</creationDate>
    /// <modifications>
    /// <item>Date ;By ;Description</item>
    /// <item>Date ;By ;Description</item>
    /// </modifications>
    public class Matter
    {
        /// <summary>
        /// GetFranchiseForFiling implements the business action - GetFranchiseForFiling. 
        /// </summary>
        /// <param name="CountySeq">County Seq corresponding to which Franchise to be retreived</param>
        /// <param name="MunicipalitySeq">Municipality Seq corresponding to which Franchise to be retreived</param>
        /// <returns>GenericExecutionResult object with return value-List of Franchise</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<FranchiseEntity>> GetFranchiseForFiling(System.Int32 MunicipalitySeq)
        {
            GenericExecutionResult<List<FranchiseEntity>> ObjGenEx = new GenericExecutionResult<List<FranchiseEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetFranchiseForFiling(MunicipalitySeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ReportProjectEntity>> GetRptPrjSubmissionDocDetail(System.String TrackingNumber)
        {
            GenericExecutionResult<List<ReportProjectEntity>> ObjGenEx = new GenericExecutionResult<List<ReportProjectEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetRptPrjSubmissionDocDetail(TrackingNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ReportProjectEntity>> GetRptPrjSubmissionDetail(System.String TrackingNumber)
        {
            GenericExecutionResult<List<ReportProjectEntity>> ObjGenEx = new GenericExecutionResult<List<ReportProjectEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetRptPrjSubmissionDetail(TrackingNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ReportProjectEntity>> GetRptPrjSubmissionDetailForSupp(System.String TrackingNumber)
        {
            GenericExecutionResult<List<ReportProjectEntity>> ObjGenEx = new GenericExecutionResult<List<ReportProjectEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetRptPrjSubmissionDetailForSupp(TrackingNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ReportProjectEntity>> GetRptPrjType()
        {
            GenericExecutionResult<List<ReportProjectEntity>> ObjGenEx = new GenericExecutionResult<List<ReportProjectEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetRptPrjType();
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<System.Int32> InsertRptPrjSuppSubmission(ReportProjectEntity rptprjEntity)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.InsertRptPrjSuppSubmission(rptprjEntity);
            }
            catch
            {
                throw;
            }
            try
            {
                if (ObjGenEx.IsSuccess)
                {
                    CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntity.EventCode = "E0075";
                    objNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.Messages[0];
                    CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    ObjGenEx.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);
                }
            }
            catch (Exception ex) { }

            return ObjGenEx;
        }

        public GenericExecutionResult<List<ReportProjectEntity>> SearchRptPrjSubmission(System.Int32 PageSize, System.Int32 PageNumber, System.String OrderBy, ReportProjectEntity reportprojectsearchEntity)
        {
            GenericExecutionResult<List<ReportProjectEntity>> ObjGenEx = new GenericExecutionResult<List<ReportProjectEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.SearchRptPrjSubmission(PageSize, PageNumber, OrderBy, reportprojectsearchEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<System.Int32> InsertRptPrjSubmission(ReportProjectEntity rptprjEntity)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.InsertRptPrjSubmission(rptprjEntity);
            }
            catch
            {
                throw;
            }
            try
            {
                if (ObjGenEx.IsSuccess)
                {
                    CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntity.EventCode = "E0074";
                    objNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.Messages[0];
                    CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    ObjGenEx.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);
                }
            }
            catch (Exception ex) { }

            return ObjGenEx;
        }


        public GenericExecutionResult<List<CompanyEntity>> GetCompanyByIndTypeSubType(System.String IndustryTypeCode, System.String IndustrySubTypeCode,System.String UserID)
        {
            GenericExecutionResult<List<CompanyEntity>> ObjGenEx = new GenericExecutionResult<List<CompanyEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetCompanyByIndTypeSubType(IndustryTypeCode, IndustrySubTypeCode, UserID);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetMatterTypeByIndustryAfftected implements the business action - GetMatterTypeByIndustryAffected. 
        /// </summary>
        /// <param name="IndustrySeq">Industry Sequence</param>
        /// <param name="IsExternal">'1' for External Matters; '0' for Office Filing</param>
        /// <returns>GenericExecutionResult object with return value-List of Matter Type entities corresponding to that Industry</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterTypeEntity>> GetMatterTypeByIndustryAffected(System.String Utility_Type_Code, System.String IsExternal)
        {
            GenericExecutionResult<List<MatterTypeEntity>> ObjGenEx = new GenericExecutionResult<List<MatterTypeEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetMatterTypeByIndustryAffected(Utility_Type_Code, IsExternal);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<IndustrySubtypeEntity>> GetIndustrySubType(System.String IndustryTypeCode)
        {
            GenericExecutionResult<List<IndustrySubtypeEntity>> ObjGenEx = new GenericExecutionResult<List<IndustrySubtypeEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetIndustrySubType(IndustryTypeCode);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


        /// <summary>
        /// GetMattersubTypeByMattertypeAndIndustry implements the business action - GetMattersubTypeByMattertypeAndIndustry. 
        /// </summary>
        /// <param name="IndustryAffectedSeq">Industry Sequence</param>
        /// <param name="MatterSeq">Matter Sequence</param>
        /// <param name="IsExternal">'1' for External Matters; '0' for Office Filing</param>
        /// <returns>GenericExecutionResult object with return value-List of Matter SubType entities corresponding to the Industry Sequence and MatterType Sequence</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterSubtypeEntity>> GetMatterSubType(System.String caseTypeCode)
        {
            GenericExecutionResult<List<MatterSubtypeEntity>> ObjGenEx = new GenericExecutionResult<List<MatterSubtypeEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetMatterSubType(caseTypeCode);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// SearchMatter implements the business action - SearchMatter. 
        /// </summary>
        /// <param name="searchMatterEntity">searchMatterEntity object</param>
        /// <param name="PageNumber">The current page number</param>
        /// <param name="PageSize">The Page Size</param>
        /// <param name="SortOrder">The sorting expression</param>
        /// <returns>GenericExecutionResult object with return value-List of Matters as List of MatterResultEntity objects</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        //public GenericExecutionResult<List<MatterResultEntity>> SearchMatter(SearchMatterEntity searchMatterEntity, System.Int32 PageSize, System.Int32 PageNumber, System.String SortOrder)
        //{
        //    GenericExecutionResult<List<MatterResultEntity>> ObjGenEx = new GenericExecutionResult<List<MatterResultEntity>>();
        //    try
        //    {
        //        ResMatter ObjResMatter = new ResMatter();
        //        ObjGenEx = ObjResMatter.SearchMatter(searchMatterEntity, PageSize, PageNumber, SortOrder);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return ObjGenEx;
        //}
        /// <summary>
        /// SearchMatter implements the business action - SearchMatter. 
        /// </summary>
        /// <param name="searchMatterEntity">searchMatterEntity object</param>
        /// <param name="PageNumber">The current page number</param>
        /// <param name="PageSize">The Page Size</param>
        /// <param name="SortOrder">The sorting expression</param>
        /// <returns>GenericExecutionResult object with return value-List of Matters as List of MatterResultEntity objects</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterResultEntity>> SearchMatter(SearchMatterEntity searchMatterEntity, System.Int32 PageSize, System.Int32 PageNumber, System.String SortOrder)
        {
            GenericExecutionResult<List<MatterResultEntity>> ObjGenEx = new GenericExecutionResult<List<MatterResultEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.SearchMatter(searchMatterEntity, PageSize, PageNumber, SortOrder);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        /// <summary>
        /// GetValidRelatedMatter implements the business action - GetValidRelatedMatter. 
        /// </summary>
        /// <param name="MatterCaseNumber">Matter/Case Number to validate</param>
        /// <returns>GenericExecutionResult object with return value-Matter Info entity object</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<MatterInfoEntity> GetValidRelatedMatter(System.String MatterCaseNumber)
        {
            GenericExecutionResult<MatterInfoEntity> ObjGenEx = new GenericExecutionResult<MatterInfoEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetValidRelatedMatter(MatterCaseNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<MatterMasterEntity> GetExternalMatterMasterInformation(MatterMasterEntity ObjMatterMasterEntity)
        {
            GenericExecutionResult<MatterMasterEntity> ObjGenEx = new GenericExecutionResult<MatterMasterEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetExternalMatterMasterInformation(ObjMatterMasterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<MatterMasterEntity> GetExternalPublicComments(MatterMasterEntity ObjMatterMasterEntity)
        {
            GenericExecutionResult<MatterMasterEntity> ObjGenEx = new GenericExecutionResult<MatterMasterEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetExternalPublicComments(ObjMatterMasterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<ReportProjectEntity> ValidateTrackingNumber(System.String TrackingNumber,System.String UserID)
        {
            GenericExecutionResult<ReportProjectEntity> ObjGenEx = new GenericExecutionResult<ReportProjectEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.ValidateTrackingNumber(TrackingNumber,UserID);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<MatterMasterEntity> GetExternalFilingInformation(MatterMasterEntity ObjMatterMasterEntity)
        {
            GenericExecutionResult<MatterMasterEntity> ObjGenEx = new GenericExecutionResult<MatterMasterEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetExternalFilingInformation(ObjMatterMasterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


        public GenericExecutionResult<MatterMasterEntity> GetExternalAssignedStaffInformation(MatterMasterEntity ObjMatterMasterEntity)
        {
            GenericExecutionResult<MatterMasterEntity> ObjGenEx = new GenericExecutionResult<MatterMasterEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetExternalAssignedStaffInformation(ObjMatterMasterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<MatterMasterEntity> GetExternalActivePartyListInformation(MatterMasterEntity ObjMatterMasterEntity)
        {
            GenericExecutionResult<MatterMasterEntity> ObjGenEx = new GenericExecutionResult<MatterMasterEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetExternalActivePartyListInformation(ObjMatterMasterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<MatterMasterEntity> GetExternalContactListInformation(MatterMasterEntity ObjMatterMasterEntity)
        {
            GenericExecutionResult<MatterMasterEntity> ObjGenEx = new GenericExecutionResult<MatterMasterEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetExternalContactListInformation(ObjMatterMasterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        /// <summary>
        /// GetMattersubTypeByMattertypeAndIndustry implements the business action - GetMattersubTypeByMattertypeAndIndustry. 
        /// </summary>
        /// <param name="IndustryAffectedSeq">Industry Sequence</param>
        /// <param name="MatterSeq">Matter Sequence</param>
        /// <returns>GenericExecutionResult object with return value-List of Matter SubType entities corresponding to the Industry Sequence and MatterType Sequence</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterSubtypeEntity>> GetMatterSubTypeByMatterTypeAndIndustry(System.String MatterTypeCode, System.String IndustryAffectedCode, System.String IsExternal)
        {
            GenericExecutionResult<List<MatterSubtypeEntity>> ObjGenEx = new GenericExecutionResult<List<MatterSubtypeEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetMatterSubTypeByMatterTypeAndIndustry(MatterTypeCode, IndustryAffectedCode, IsExternal);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// InsertMatterSubscription implements the wrapper method for business action - InsertMatterSubscription. 
        /// </summary>
        /// <param name="subscriptionEntity">subscriptionEntity corresponding to which data to be insert</param>        
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-5-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<int> InsertMatterSubscription(SubscriptionEntity subscriptionEntity)
        {
            GenericExecutionResult<int> ObjGenEx = new GenericExecutionResult<int>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.InsertMatterSubscription(subscriptionEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetMatterSubscriptionInfo implements the wrapper method for business action - GetMatterSubscriptionInfo. 
        /// </summary>
        /// <param name="UserName">User Name corresponding to which data to be retreived</param>        
        /// <returns>GenericExecutionResult object with return value-SubscriptionEntity Entity object</returns>
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-05-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<SubscriptionEntity>> GetMatterSubscriptionInfo(System.String UserName)
        {
            GenericExecutionResult<List<SubscriptionEntity>> ObjGenEx = new GenericExecutionResult<List<SubscriptionEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetMatterSubscriptionInfo(UserName);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// UnsubscribeForCase implements the wrapper method for business action - UnsubscribeForCase. 
        /// </summary>
        /// <param name="UserName">User Name corresponding to which data to be update</param>        
        /// <param name="MatterSubSeq">Comma separated matter subscription seq corresponding to which data to be update</param>        
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-05-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public void UnsubscribeForCase(System.String UserName, System.String MatterSubSeq)
        {
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjResMatter.UnsubscribeForCase(UserName, MatterSubSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// GetCaseSubscriptionInformationBySubSeq implements the wrapper method for business action - GetCaseSubscriptionInformationBySubSeq. 
        /// </summary>
        /// <param name="MatterSubSeq">Subscription Seq corresponding to which data to be retreived</param>        
        /// <returns>GenericExecutionResult object with return value-SubscriptionEntity Entity object</returns>
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-05-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<SubscriptionEntity> GetCaseSubscriptionInformationBySubSeq(System.Int32 MatterSubSeq)
        {
            GenericExecutionResult<SubscriptionEntity> ObjGenEx = new GenericExecutionResult<SubscriptionEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetCaseSubscriptionInformationBySubSeq(MatterSubSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }


        /// <summary>
        /// UpdateMatterSubscription implements the wrapper method for business action - UpdateMatterSubscription. 
        /// </summary>
        /// <param name="subscriptionEntity">subscriptionEntity corresponding to which data to be insert</param>        
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-5-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<int> UpdateMatterSubscription(SubscriptionEntity subscriptionEntity)
        {
            GenericExecutionResult<int> ObjGenEx = new GenericExecutionResult<int>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.UpdateMatterSubscription(subscriptionEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// InsertSubscribeForServiceList implements the wrapper method for business action - InsertSubscribeForServiceList. 
        /// </summary>
        /// <param name="UserName">/param>        
        /// <param name="MatterSeq"></param>  
        /// <param name="IssuanceOnly"></param>  
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-5-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<int> InsertSubscribeForServiceList(SubscriptionEntity ObjSubscriptionEntity)
        {
            GenericExecutionResult<int> ObjGenEx = new GenericExecutionResult<int>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.InsertSubscribeForServiceList(ObjSubscriptionEntity);

                //START Code Added By Achal For DEFW302
                if (ObjGenEx.ReturnValue == 0 && ObjGenEx.IsSuccess)
                {
                    string trackingNumber = string.Empty;
                    var listOfInrollment = ObjResMatter.GetServiceListSubscriptionInfo(ObjSubscriptionEntity.UserID);
                    foreach (var item in listOfInrollment.ReturnValue)
                    {
                        if (item.CaseNumber.ToUpper() == ObjSubscriptionEntity.CaseNumber.ToUpper())
                        {
                            trackingNumber = item.ServiceListSeq.ToString();
                            break;
                        }
                    }
                    if (!string.IsNullOrEmpty(trackingNumber))
                    {
                        CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                        objNotificationInputEntity.EventCode = "E0116";
                        objNotificationInputEntity.TrckingReferenceNumber = trackingNumber;
                        CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
                        CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                        ObjGenEx.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);
                    }

                }
                //END Code Added By Achal For DEFW302
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetServiceListSubscriptionInfo implements the wrapper method for business action - GetServiceListSubscriptionInfo. 
        /// </summary>
        /// <param name="UserName">User Name corresponding to which data to be retreived</param>        
        /// <returns>GenericExecutionResult object with return value-SubscriptionEntity Entity object</returns>
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-05-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterDetailEntity>> GetServiceListSubscriptionInfo(System.String UserName)
        {
            GenericExecutionResult<List<MatterDetailEntity>> ObjGenEx = new GenericExecutionResult<List<MatterDetailEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetServiceListSubscriptionInfo(UserName);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetServiceListSubscriptionInformationByServiceListSeq implements the wrapper method for business action - GetServiceListSubscriptionInformationByServiceListSeq. 
        /// </summary>
        /// <param name="ServiceListSeq">ServiceList Seq corresponding to which data to be retreived</param>        
        /// <returns>GenericExecutionResult object with return value-MatterDetailEntity Entity object</returns>
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-05-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<MatterDetailEntity> GetServiceListSubscriptionInformationByServiceListSeq(System.Int32 ServiceListSeq)
        {
            GenericExecutionResult<MatterDetailEntity> ObjGenEx = new GenericExecutionResult<MatterDetailEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetServiceListSubscriptionInformationByServiceListSeq(ServiceListSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// UpdateServiceListSubscription implements the wrapper method for business action - UpdateServiceListSubscription. 
        /// </summary>
        /// <param name="ServiceListSeq"></param>        
        /// <param name="IssuanceOnly"></param>        
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-5-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<int> UpdateServiceListSubscription(SubscriptionEntity ObjSubscriptionEntity)
        {
            GenericExecutionResult<int> ObjGenEx = new GenericExecutionResult<int>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.UpdateServiceListSubscription(ObjSubscriptionEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// UnsubscribeForServiceList implements the wrapper method for business action - UnsubscribeForServiceList. 
        /// </summary>
        /// <param name="UserName">User Name corresponding to which data to be update</param>        
        /// <param name="ServiceListSeq">Comma separated ServiceList subscription seq corresponding to which data to be update</param>        
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-05-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public void UnsubscribeForServiceList(System.String UserName, System.String ServiceListSeq)
        {
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjResMatter.UnsubscribeForServiceList(UserName, ServiceListSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<DocumentTypeEntity> GetDocTypeListForExternalUser()
        {
            List<DocumentTypeEntity> ObjDocumentTypeEntity = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjDocumentTypeEntity = ObjResMatter.GetDocTypeListForExternalUser();
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjDocumentTypeEntity;
        }

        public GenericExecutionResult<int> InsertFavoriteSearch(FavoriteSearchEntity favoriteSearchEntity)
        {
            GenericExecutionResult<int> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.InsertFavoriteSearch(favoriteSearchEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public GenericExecutionResult<List<FavoriteSearchEntity>> GetFavoriteSearchInfo(System.String UserName)
        {
            GenericExecutionResult<List<FavoriteSearchEntity>> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.GetFavoriteSearchInfo(UserName);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public GenericExecutionResult<FavoriteSearchEntity> GetFavoriteInfoForFavoriteSeq(System.Int32 FavoriteSearch)
        {
            GenericExecutionResult<FavoriteSearchEntity> ObjGenEx = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetFavoriteInfoForFavoriteSeq(FavoriteSearch);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Get Company By CompanySeq .
        /// </summary>
        /// <param name="companySeq"></param>
        /// <returns></returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public List<CompanyEntity> GetCompanybyCompanySeq(System.Int32 companySeq)
        {
            List<CompanyEntity> ObjCompanyEntity = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjCompanyEntity = ObjResMatter.GetCompanybyCompanySeq(companySeq);
            }
            catch
            {
                throw;
            }
            return ObjCompanyEntity;
        }

        public GenericExecutionResult<int> UpdateFavoriteSearch(FavoriteSearchEntity favoriteSearchEntity)
        {
            GenericExecutionResult<int> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.UpdateFavoriteSearch(favoriteSearchEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public void DeleteFavoriteSearch(System.Int32 FavSeq, System.String UserName)
        {
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjResMatter.DeleteFavoriteSearch(FavSeq, UserName);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public GenericExecutionResult<List<MatterDetailEntity>> GetPagedPostCommentMatterInfo(System.Int32 PageSize, System.Int32 PageNumber, System.String SortingField)
        {
            GenericExecutionResult<List<MatterDetailEntity>> ObjGenEx = new GenericExecutionResult<List<MatterDetailEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetPagedPostCommentMatterInfo(PageSize, PageNumber, SortingField);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Implements the business action - GetMatterDetail.
        /// </summary>
        /// <param name="MatterSeq">Matter Seq Number</param>
        /// <returns>List of MatterDetailEntity class object</returns>
        /// <author>Krishan Kumar Aishpunani</author>
        /// <creationDate>2008-02-04</ceationDate>
        /// <modifications>
        /// <item>2008-02-04;Krishan Kumar Aishpunani;Added Comments</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public List<MatterDetailEntity> GetMatterDetail(System.String CaseNumber)
        {
            List<MatterDetailEntity> ObjMatterDetailEntityList = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjMatterDetailEntityList = ObjResMatter.GetMatterDetail(CaseNumber);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjMatterDetailEntityList;
        }

        public GenericExecutionResult<MemberEntity> GetMemberInformation(System.String UserName)
        {
            GenericExecutionResult<MemberEntity> result = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                result = ObjResMatter.GetMemberInformation(UserName);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public GenericExecutionResult<List<MatterFilingDocEntity>> GetProtectiveOrderList(System.String matterNo, System.String DocType, System.String DocSubtype,System.Int32 pageSize, System.Int32 pageNumber, System.String sortExp)
        {
            GenericExecutionResult<List<MatterFilingDocEntity>> ObjGenEx = new GenericExecutionResult<List<MatterFilingDocEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetProtectiveOrderList(matterNo,DocType,DocSubtype, pageSize, pageNumber, sortExp);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }


        public GenericExecutionResult<int> ResetPassword(MemberEntity memberEntity)
        {
            GenericExecutionResult<int> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.ResetPassword(memberEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public GenericExecutionResult<int> UpdateMemberInformation(MemberEntity memberEntity)
        {
            GenericExecutionResult<int> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.UpdateMemberInformation(memberEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public GenericExecutionResult<LoginEntity> GetTempMemberInfo(LoginEntity ObjLoginEntity)
        {
            GenericExecutionResult<LoginEntity> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.GetTempMemberInfo(ObjLoginEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public List<IDNameEntity> GetStateList()
        {
            List<IDNameEntity> ObjIDNameEntityList = new List<IDNameEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjIDNameEntityList = ObjResMatter.GetStateList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjIDNameEntityList;
        }

        public GenericExecutionResult<int> InsertMemberInformation(MemberEntity memberEntity)
        {
            GenericExecutionResult<int> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.InsertMemberInformation(memberEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            //Start R2 - Modification made by Ritika on 23rd July 2012 - for notification missing to registering person
            try
            {
                if (ObjGen.IsSuccess)
                {
                    CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntity.EventCode = "E0043";
                    objNotificationInputEntity.TrckingReferenceNumber = memberEntity.UserId;
                    CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    ObjGen.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);

                    CQM.Notification.NotificationInputEntity objNotificationInputEntityCOC = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntityCOC.EventCode = "E0044";
                    objNotificationInputEntityCOC.TrckingReferenceNumber = memberEntity.UserId; 
                    CQM.Notification.NotificationAbstract objNotificationAbstractCOC = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntityCOC);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgementCOC = objNotificationAbstractCOC.SendNotification(objNotificationAbstractCOC, CQM.Notification.SendMailTo.Individual);
                    ObjGen.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgementCOC.SendStatus);
                }
            }
            catch (Exception ex)
            { }
            //End R2 - Modification made by Ritika on 23rd July 2012 - for notification missing to registering person
            return ObjGen;
        }


        public GenericExecutionResult<List<MemberEntity>> GetMemberByEmailID(System.String EmailID)
        {
            GenericExecutionResult<List<MemberEntity>> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.GetMemberByEmailID(EmailID);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public GenericExecutionResult<int> AssociateMemberInformation(System.Int32 MemberSeq, System.String UserID, System.String EmailID)
        {
            GenericExecutionResult<int> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.AssociateMemberInformation(MemberSeq, UserID, EmailID);
            }
            catch (Exception ex)
            {
                throw;
            }
            //Start R2 - Modification made by Ritika on 23rd July 2012 - for notification missing to registering person
            try
            {
                if (ObjGen.IsSuccess)
                {
                    CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntity.EventCode = "E0043";
                    objNotificationInputEntity.TrckingReferenceNumber = UserID;
                    CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    ObjGen.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);

                    CQM.Notification.NotificationInputEntity objNotificationInputEntityCOC = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntityCOC.EventCode = "E0044";
                    objNotificationInputEntityCOC.TrckingReferenceNumber = UserID;
                    CQM.Notification.NotificationAbstract objNotificationAbstractCOC = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntityCOC);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgementCOC = objNotificationAbstractCOC.SendNotification(objNotificationAbstractCOC, CQM.Notification.SendMailTo.Individual);
                    ObjGen.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgementCOC.SendStatus);
                }
            }
            catch (Exception ex)
            { }
            //End R2 - Modification made by Ritika on 23rd July 2012 - for notification missing to registering person
            return ObjGen;
        }

        public GenericExecutionResult<LoginEntity> GetForgotPasswordDetails(LoginEntity ObjLoginEntity)
        {
            GenericExecutionResult<LoginEntity> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.GetForgotPasswordDetails(ObjLoginEntity);

                //Email to user for Forgot Password | Piyush | 22 March
                if (ObjGen.IsSuccess)
                {
                    CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntity.EventCode = "E0042";
                    objNotificationInputEntity.TrckingReferenceNumber = ObjLoginEntity.UserID;
                    CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    ObjGen.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);
                }
                //Change end
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public GenericExecutionResult<LoginEntity> InsertPendingRegistration(LoginEntity ObjLoginEntity)
        {
            GenericExecutionResult<LoginEntity> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.InsertPendingRegistration(ObjLoginEntity);

                //EMail to user for registration verification | Piyush | 03 March
                if (ObjGen.IsSuccess)
                {
                    CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntity.EventCode = "E0041";
                    objNotificationInputEntity.TrckingReferenceNumber = ObjLoginEntity.UserID;
                    CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    ObjGen.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);
                }
                //Change end
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public bool SendCommentNotification(System.Int32 MatterSeq, System.Int32 MemberSeq)
        {
            Boolean bSend = false;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                bSend = ObjResMatter.SendCommentNotification(MatterSeq, MemberSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
            return bSend;
        }
        public bool SendCommentNotification(System.String MatterSeq, System.Int32 MemberSeq)
        {
            Boolean bSend = false;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                bSend = ObjResMatter.SendCommentNotification(MatterSeq, MemberSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
            return bSend;
        }
        
        public GenericExecutionResult<int> IsPendingRegistration(System.String UserID)
        {
            GenericExecutionResult<int> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.IsPendingRegistration(UserID);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }


        /// <summary>
        /// GetCompanyByUserID implements the business action - GetCompanyByUserID. 
        /// </summary>
        /// <param name="UserID">The logged in UserID corresponding to which filings to be updated</param>
        /// <param name="IndustrySeq">The Industry Sequence corresponding to which Companies to be retreived</param>
        /// <param name="IsExistingMatter">Flag set to '1' for Existing matter</param>
        /// <returns>GenericExecutionResult object with return value-List companies as List of IDNameEntity objects</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>03/07/2012/Ritika/Modification changed return type and input parameters to method and to SP</item>
        /// </modifications>
        public GenericExecutionResult<List<CompanyEntity>> GetCompanyByUserID(System.String UserID, System.String IndustryTypeCode, System.String SelectActive, System.String CompanyOrgName, System.String IndustrySubtypeCode, System.String CompanyCode,System.String OrderBy,System.Int32 pageSize, System.Int32 pageNumber)
        {
            GenericExecutionResult<List<CompanyEntity>> ObjGenEx = new GenericExecutionResult<List<CompanyEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetCompanyByUserID(UserID, IndustryTypeCode, SelectActive,CompanyOrgName,IndustrySubtypeCode,CompanyCode,OrderBy,pageSize,pageNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<CompanyEntity>> GetCompanyInfo(CompanyEntity ObjCompanyEntity)
        {
            GenericExecutionResult<List<CompanyEntity>> ObjGenEx = new GenericExecutionResult<List<CompanyEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetCompanyInfo(ObjCompanyEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetPreviousFiling implements the business action - GetPreviousFiling. 
        /// </summary>
        /// <param name="MatterSeq">The Matter Seq corresponding to which filings to be updated</param>
        /// <returns>GenericExecutionResult object with return value-List of FilingInfo Entity objects</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<FilingInfoEntity>> GetPreviousFiling(System.Int32 MatterSeq, System.Int32 FilingSeq)
        {
            GenericExecutionResult<List<FilingInfoEntity>> ObjGenEx = new GenericExecutionResult<List<FilingInfoEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetPreviousFiling(MatterSeq, FilingSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


        /// <summary>
        /// GetMatterData implements the business action - GetMatterData. 
        /// </summary>
        /// <param name="MatterSeq">Matter Seq corresponding to which data to be retreived</param>        
        /// <returns>GenericExecutionResult object with return value-MatterInfo Entity object</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<MatterInfoEntity> GetMatterData(System.String CaseNo)
        {
            GenericExecutionResult<MatterInfoEntity> ObjGenEx = new GenericExecutionResult<MatterInfoEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetMatterData(CaseNo);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
  
        /// <summary>
        /// GetBusinessRule implements the business action - GetBusinessRule. 
        /// </summary>
        /// <param name="businessRuleEntity">The businessRuleEntity object</param>
        /// <returns>GenericExecutionResult object having business rules values set</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2002-11-27</ceationDate>
        /// <modifications>
        /// <item></item>
        /// </modifications>
        public GenericExecutionResult<BusinessRuleEntity> GetBusinessRule(BusinessRuleEntity businessRuleEntity)
        {
            GenericExecutionResult<BusinessRuleEntity> ObjGenEx = new GenericExecutionResult<BusinessRuleEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetBusinessRule(businessRuleEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// ValidateMatter implements the business action - ValidateMatter. 
        /// </summary>
        /// <param name="MatterCaseNumber">Matter/Case Number to validate</param>
        /// <returns>GenericExecutionResult object with return value-Matter Info entity object</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<MatterInfoEntity> ValidateMatter(System.String MatterCaseNumber)
        {
            GenericExecutionResult<MatterInfoEntity> ObjGenEx = new GenericExecutionResult<MatterInfoEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.ValidateMatter(MatterCaseNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary> 
        /// SubmitMatter implements the business action - SubmitMatter. 
        /// </summary>
        /// <param name="matterFilingEntity">MatterEntity object</param>
        /// <param name="IsInternalUser">Flag set to true for Internal User</param>
        /// <returns>GenericExecutionResult object with return value-New added Matter Seq</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int32> SubmitMatter(MatterEntity matterFilingEntity, System.Boolean IsInternalUser)
        {
            //Entity level Validation
            bool bValidationRequired = false;
            if (bValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(matterFilingEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder strmessage = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        System.String strvalidationResultMessage = validationResult.Message;
                        strmessage.AppendLine(String.Format("{0}", strvalidationResultMessage));
                    }
                    throw new InvalidOperationException(strmessage.ToString());
                }
            }
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.SubmitMatter(matterFilingEntity,IsInternalUser);
            }
            catch
            {
                throw;
            }
            //if (ObjGenEx.IsSuccess)
            //{
            //    try
            //    {
            //        CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
            //        objNotificationInputEntity.EventCode = "E0049";
            //        objNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.Messages[1];
            //        CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
            //        CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
            //        ObjGenEx.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);
            //    }
            //    catch { }
            //}
            return ObjGenEx;
        }

        /// <summary> 
        /// SubmitSubsequentMatter implements the business action - SubmitSubsequentMatter. 
        /// </summary>
        /// <param name="matterFilingEntity">MatterEntity object</param>
        /// <param name="IsInternalUser">Flag set to true for Internal User</param>
        /// <returns>GenericExecutionResult object with return value-New added Filing Seq</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int32> SubmitSubsequentMatter(MatterEntity matterFilingEntity)
        {
            //Entity level Validation
            bool bValidationRequired = false;
            if (bValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(matterFilingEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder strmessage = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        System.String strValidationResultMessage = validationResult.Message;
                        strmessage.AppendLine(String.Format("{0}", strValidationResultMessage));
                    }
                    throw new InvalidOperationException(strmessage.ToString());
                }
            }
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.SubmitSubsequentMatter(matterFilingEntity);
            }
            catch
            {
                throw;
            }
            //if (ObjGenEx.IsSuccess)
            //{
            //    try
            //    {
            //        CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
            //        objNotificationInputEntity.EventCode = "E0050";
            //        objNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.ReturnValue.ToString();
            //        CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
            //        CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
            //        ObjGenEx.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);
            //    }
            //    catch { }
            //}
            return ObjGenEx;
        }

        /// <summary>
        /// GetAllMimeType implements the wrapper method for business action - GetAllMimeType. 
        /// </summary>
        /// <returns>Object of GenericExecutionResult with Mime Types</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2008-04-14</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<CodeNameEntity>> GetAllMimeType()
        {
            GenericExecutionResult<List<CodeNameEntity>> ObjGenEx = new GenericExecutionResult<List<CodeNameEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetAllMimeType();
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<DocumentSubTypeEntity>> GetDocumentSubTypeListByDocumentType(System.String docCode)
        {
            GenericExecutionResult<List<DocumentSubTypeEntity>> ObjGenEx = new GenericExecutionResult<List<DocumentSubTypeEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetDocumentSubTypeListByDocumentType(docCode);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// SearchDocument methode is used to search document from CE as well as from database Used for dispaly record in diffrent tab.
        /// </summary>
        /// <param name="searchDocumentEntity"></param>
        /// <param name="searchMatterEntity"></param>
        /// <param name="SrchdPblcDcmntPageSize"></param>
        /// <param name="SrchdPblcDcmntPageNumber"></param>
        /// <param name="SrchdPblcDcmntSortExp"></param>
        /// <param name="SrchdIntrnlDcmntPageSize"></param>
        /// <param name="SrchdIntrnlDcmntPageNumber"></param>
        /// <param name="SrchdIntrnlDcmntSortExp"></param>
        /// <param name="SrchdSAPADcmntPageSize"></param>
        /// <param name="SrchdSAPADcmntPageNumber"></param>
        /// <param name="SrchdSAPADcmntSortExp"></param>
        /// <param name="ClickValue"></param>
        /// <returns></returns>
        //@@@@ Start - For Comments - updated the signature of method
        //public GenericExecutionResult<List<List<MatterDocumentEntity>>> SearchDocumentDisplayInDiffTab(SearchDocumentEntity searchDocumentEntity, SearchMatterEntity searchMatterEntity, System.Int32 SrchdPblcDcmntPageSize, System.Int32 SrchdPblcDcmntPageNumber, System.String SrchdPblcDcmntSortExp, System.Int32 SrchdIntrnlDcmntPageSize, System.Int32 SrchdIntrnlDcmntPageNumber, System.String SrchdIntrnlDcmntSortExp, System.Int32 SrchdSAPADcmntPageSize, System.Int32 SrchdSAPADcmntPageNumber, System.String SrchdSAPADcmntSortExp, System.Boolean ClickValue)
        public GenericExecutionResult<SearchDocumentResultEntity> SearchDocumentDisplayInDiffTab(SearchDocumentEntity searchDocumentEntity, SearchMatterEntity searchMatterEntity, System.Int32 SrchdPblcDcmntPageSize, System.Int32 SrchdPblcDcmntPageNumber, System.String SrchdPblcDcmntSortExp, System.Int32 CommentPageSize, System.Int32 CommentPageNumber, System.String CommentOrderBy, System.Boolean ClickValue)
        {
            bool bValidationRequired = false;
            if (bValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(searchDocumentEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder strmessage = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        System.String strValidationResultMessage = validationResult.Message;
                        strmessage.AppendLine(String.Format("{0}", strValidationResultMessage));
                    }
                    throw new InvalidOperationException(strmessage.ToString());
                }
            }
            // GenericExecutionResult<List<List<MatterDocumentEntity>>> ObjGenEx = new GenericExecutionResult<List<List<MatterDocumentEntity>>>();
            GenericExecutionResult<SearchDocumentResultEntity> ObjGenEx = new GenericExecutionResult<SearchDocumentResultEntity>();
            try
            {
                ResMatter objResMatter = new ResMatter();
                ObjGenEx = objResMatter.SearchDocumentDisplayInDiffTab(searchDocumentEntity, searchMatterEntity, SrchdPblcDcmntPageSize, SrchdPblcDcmntPageNumber, SrchdPblcDcmntSortExp, CommentPageSize, CommentPageNumber, CommentOrderBy, ClickValue);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<SearchDocumentResultEntity> GetProtectiveOrder(System.Int32 PageSize, System.Int32 PageNumber, System.String OrderBy, System.Int32 DocSeq)
        {
            //GenericExecutionResult<List<List<MatterDocumentEntity>>> ObjGenEx = new GenericExecutionResult<List<List<MatterDocumentEntity>>>();
            GenericExecutionResult<SearchDocumentResultEntity> ObjGenEx = new GenericExecutionResult<SearchDocumentResultEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetProtectiveOrder(PageSize, PageNumber, OrderBy, DocSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// This Method is used to get information of perticular filing of a matter by filing seq. 
        /// used in popup open form matter filing approval screen.
        /// </summary>
        /// <param name="FilingSeq">Filing sequence of matter filing</param>
        /// <returns>GenericExecutionResult object of type MatterDocumentEntity</returns>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-01-08</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<MatterDocumentEntity> GetMatterFilingInformation(System.Int32 nFilingSeq)
        {
            GenericExecutionResult<MatterDocumentEntity> ObjGenEx = new GenericExecutionResult<MatterDocumentEntity>();
            try
            {
                ResMatter ObjResMatterMgmt = new ResMatter();
                ObjGenEx = ObjResMatterMgmt.GetMatterFilingInformation(nFilingSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<ReferenceEntity> GetStaReference(System.String CaseNumber, System.String isStatutory)
        {
            GenericExecutionResult<ReferenceEntity> ObjGenEx = new GenericExecutionResult<ReferenceEntity>();
            try
            {
                ResMatter ObjResMatterMgmt = new ResMatter();
                ObjGenEx = ObjResMatterMgmt.GetStaReference(CaseNumber, isStatutory);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// This methode is used get information about Document associate with perticular filing by filing seq.
        /// used in popup open from matter filing approval screen. 
        /// </summary>
        /// <param name="FilingSeq">Filing sequence of matter filing</param>
        /// <param name="PageSize">pagesize of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>GenericExecutionResult object of type list of MatterDocumentEntity</returns>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-01-08</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterDocumentEntity>> GetMatterFilingDocument(System.Int32 nFilingSeq, System.Int32 nPageSize, System.Int32 nPageNumber, System.String OrderBy)
        {
            GenericExecutionResult<List<MatterDocumentEntity>> ObjGenEx = new GenericExecutionResult<List<MatterDocumentEntity>>();
            try
            {
                ResMatter ResMatterMgmt = new ResMatter();
                ObjGenEx = ResMatterMgmt.GetMatterFilingDocument(nFilingSeq, nPageSize, nPageNumber, OrderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Implements wrapper method for the business action - Is Public Doc will be visible to Logged in user or not.
        /// </summary>
        /// <param name="DocRefNum">Document reference number</param>
        /// <param name="UserID">User Id</param>
        /// <returns>string value</returns>
        /// <author>Mukesh K</author>
        /// <creationDate>2008-25-02</creationDate>
        /// <modifications>
        /// <item>2008-02-04;Krishan Kumar Aishpunani;Added Comments</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.String> IsAccessiblePublicDoc(System.String DocRefNum, System.String UserID)
        {
            GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
            try
            {
                ResMatter ObjResMatterMgmt = new ResMatter();
                ObjGenEx = ObjResMatterMgmt.IsAccessiblePublicDoc(DocRefNum, UserID);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

         /// <summary>
        /// IsLoggedInUserActivePartyMember  - returns true or false if the logged in user is an apl member
        /// </summary>
        /// <param name="CaseNumber"></param>
        /// <param name="UserID"></param>
        /// <returns>boolea</returns>
        /// <author>Ritika</author>
        /// <creationDate>2012-10-03</creationDate>
        /// <modifications>
        /// <item></item>
        /// </modifications>
        public Boolean IsLoggedInUserActivePartyMember(System.String CaseNumber, System.String UserID)
        {
            Boolean isLoggedInUserActivePartyMember = false;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                isLoggedInUserActivePartyMember = ObjResMatter.IsLoggedInUserActivePartyMember(CaseNumber, UserID);
            }
            catch (Exception ex)
            {
                throw;
            }
            return isLoggedInUserActivePartyMember;

        }

        #region "AR integration"

        /// <summary>
        /// GetMemberInformationByMemberSeq By MemberSeq
        /// </summary>
        /// <param name="p_MemberSeq"></param>
        /// <returns>GenericExecutionResult</returns>
        /// <author></author>
        /// <creationDate></creationDate>
        /// <modifications>
        /// <item></item>
        /// </modifications>
        public GenericExecutionResult<MemberEntity> GetMemberInformationByMemberSeq(int p_MemberSeq)
        {
            GenericExecutionResult<MemberEntity> result = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                result = ObjResMatter.GetMemberInformationByMemberSeq(p_MemberSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        /// <summary>
        /// UpdateMemberInformationByMemberSeq By MemberSeq
        /// </summary>
        /// <param name="memberEntity"></param>
        /// <returns>GenericExecutionResult</returns>
        /// <author></author>
        /// <creationDate></creationDate>
        /// <modifications>
        /// <item></item>
        /// </modifications>
        public GenericExecutionResult<int> UpdateMemberInformationByMemberSeq(MemberEntity memberEntity)
        {
            GenericExecutionResult<int> ObjGen = null;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGen = ObjResMatter.UpdateMemberInformationByMemberSeq(memberEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGen;
        }

        public int IsDocArchived(System.String DocRefNo)
        {
            System.Int32 iResult = 0;
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                iResult = ObjResMatter.IsDocArchived(DocRefNo);
            }
            catch
            {
                throw;
            }
            return iResult;
        }

        #endregion

        //Start - R2--<DEFW8>--<Modified By - Ritika on 11July2012>
        /// <summary>
        /// The GetStatMPUCReference Implements the business action - to get Statutory Reference
        /// </summary>
        /// <param name="matterNo">The matterNo will contain the Matter Sequence ID</param>
        /// <param name="pageSize">Page Number of the Record</param>
        /// <param name="pageNumber">Page Number</param>
        /// <param name="orderBy">Order By</param>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>07/21/2011</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<ReferenceEntity>> GetStatMPUCReference(System.String matterNo, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy, System.String isStatutory)
        {
            GenericExecutionResult<List<ReferenceEntity>> ObjGenEx = new GenericExecutionResult<List<ReferenceEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetStatMPUCReference(matterNo, pageSize, pageNumber, orderBy, isStatutory);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        //End - R2--<DEFW8>--<Modified By - Ritika on 11July2012>

        //Added By Sunayana Saxena DEFW264 26 august 2014

        public GenericExecutionResult<MatterFilingDocEntity> GetProtectiveOrderDetails(System.Int32 ProtectiveOrderDocSeq)
        {
            GenericExecutionResult<MatterFilingDocEntity> ObjGenEx = new GenericExecutionResult<MatterFilingDocEntity>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetProtectiveOrderDetails(ProtectiveOrderDocSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }
        public GenericExecutionResult<List<MatterContactEntity>> GetProtectiveOrderAccessList(System.String CaseNumber, System.Int32 pageSize, System.Int32 pageNumber, System.String sortExp, System.Int32 DocSeq)
        {
            GenericExecutionResult<List<MatterContactEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactEntity>>();
            try
            {
                ResMatter ObjResMatter = new ResMatter();
                ObjGenEx = ObjResMatter.GetProtectiveOrderAccessList(CaseNumber, pageSize, pageNumber, sortExp, DocSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        //end - Added By SUnayana Saxena DEFW264 26 august 2014
    }
}

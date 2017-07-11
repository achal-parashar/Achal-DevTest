//---------------------------------------------------------------------
// Author: Rajani Gandha Patra
// Version: 1.0.0
// Date: 08/05/2011
// Description:Implement Tariff Bussiness Class
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
    /// Implement Tariff Bussiness Class
    /// </summary>
    /// <author>Jay Prakash/Rajani</author>
    /// <creationDate>08/05/2011</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class Tariff
    {
        /// <summary> 
        /// SubmitTariff implements the business action - SubmitTariff. 
        /// </summary>
        /// <param name="tariffSubEntity">TariffSubmissionEntity object</param>
        /// <param name="IsInternalUser">Flag set to true for Internal User</param>
        /// <returns>GenericExecutionResult object with return value-New added Tariff Seq</returns>
        /// <author>Rajani Patra</author>
        /// <creationDate>2011-08-08</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.String> SubmitTariff(TariffSubmissionEntity tariffSubEntity, bool IsInternalUser)
        {
            GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
            try
            {
                ResTariff ObjResTariff = new ResTariff();
                ObjGenEx = ObjResTariff.SubmitNewTariff(tariffSubEntity, IsInternalUser);
                if (ObjGenEx.IsSuccess)
                {
                    String tariffNumber;
                    String notificationStatus;
                    CQM.Notification.NotificationInputEntity l_ObjNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    l_ObjNotificationInputEntity.EventCode = getEventCode(tariffSubEntity.EventFrom, "Submission");
                    tariffNumber = ObjGenEx.ReturnValue;
                    l_ObjNotificationInputEntity.TrckingReferenceNumber = tariffNumber;
                    CQM.Notification.NotificationAbstract l_ObjNotification = CQM.Notification.NotificationFactory.GetNotification(l_ObjNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement = l_ObjNotification.SendNotification(l_ObjNotification, CQM.Notification.SendMailTo.Individual);
                    //notificationStatus= l_ObjEmailSendAcknowledgement.SendStatus.ToString(); 
                    ObjGenEx.notificationStatus = setNotificationStatus(l_ObjEmailSendAcknowledgement);

                }
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        /// <summary>
        /// ChkValidCaseForTariff: implements the business action. 
        /// </summary>
        /// <param name="caseNo">Case No</param>        
        /// <returns>Returns the case no</returns>
        /// <author>Rajani Patra</author>
        /// <creationDate>2011-08-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public System.String ChkValidCaseForTariff(string caseNo)
        {
            GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
            try
            {
                ResTariff ObjResTariff = new ResTariff();
                ObjGenEx.ReturnValue = ObjResTariff.ChkValidCaseForTariff(caseNo);
            }
            catch
            {
                throw;
            }
            return ObjGenEx.ReturnValue;
        }
        /// CheckDuplicateTariff implements the business action.  
        /// </summary>
        /// <param name="industry">Utility Company Type Name</param>
        /// <param name="subIndustry">Utility Company SubType Name</param>
        /// <param name="companySeq">Company Seq</param>
        /// <param name="tariffType">Tariff Type</param>
        /// <param name="rateOrSection">The Rate or Section Name</param>
        /// <returns>Returns the boolean value for duplicate Rate/Section or not</returns>
        /// <author>Rajani Patra</author>
        /// <creationDate>2011-08-08</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public System.Boolean CheckDuplicateTariff(string industry, string subIndustry, string companySeq, string tariffType, string rateOrSection)
        {
            GenericExecutionResult<System.Boolean> ObjGenEx = new GenericExecutionResult<System.Boolean>();
            try
            {
                ResTariff ObjResTariff = new ResTariff();
                ObjGenEx.ReturnValue = ObjResTariff.CheckDuplicateTariff(industry, subIndustry, companySeq, tariffType, rateOrSection);
            }
            catch
            {
                throw;
            }
            return ObjGenEx.ReturnValue;
        }
        /// <summary>
        /// GetTraiffInformation:implements the business action.  
        /// </summary>
        /// <param name="TraiffNumber">The TraiffNumber will contain the Traiff Number</param>
        /// <returns>Returns the GenericExecutionResult of TariffSubmissionEntity</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-Aug-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<TariffSubmissionEntity> GetTraiffInformation(System.String TraiffNumber)
        {

            GenericExecutionResult<TariffSubmissionEntity> ObjGenEx = new GenericExecutionResult<TariffSubmissionEntity>(); ;
            try
            {
                ResTariff Objcommon = new ResTariff();
                ObjGenEx = Objcommon.GetTraiffInformation(TraiffNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }       
        /// <summary>
        /// GetTariffRateSecDeatil:implements the business action.  
        /// </summary>
        /// <param name="TraiffNumber">The TraiffNumber will contain the Traiff Number</param>
        /// <param name="TraiffDtlNumber">The TraiffNumber will contain the Traiff Detail Number</param>
        ///  <returns>Returns the GenericExecutionResult List  of TariffSubmissionDtlEntity</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-Aug-22</ceationDate>
        /// <updatedBy>Vivek Gupta</updatedBy>
        /// <updatedDate>Dec-27-2011</updatedDate>
        /// <modifications>
        /// <item>Change parameter type</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TariffSubmissionDtlEntity>> GetTariffRateSecDetail(CQM.Entities.TariffRateSection objTariffRateSection)
        {
            GenericExecutionResult<List<TariffSubmissionDtlEntity>> ObjGenEx = new GenericExecutionResult<List<TariffSubmissionDtlEntity>>();
            try
            {
                ResTariff Objcommon = new ResTariff();
                ObjGenEx = Objcommon.GetTariffRateSecDetail(objTariffRateSection);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetTraiffAttachmentDetail:implements the business action.  
        /// </summary>
        /// <param name="DocIdNumber">The TraiffNumber will contain the Traiff Doc ID</param>
        /// <param name="AttachmentType">The AttachmentType will contain the Doc Attachemnt Type(New/Existing/Review/RejectTariff)</param>
        ///  <returns>Returns the GenericExecutionResult List  of TariffSubmissionAttachmentEntity</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-Aug-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TariffSubmissionAttachmentEntity>> GetTraiffAttachmentDetails(TariffBookAttachmentEntity objTariffAttachment)
        {
            GenericExecutionResult<List<TariffSubmissionAttachmentEntity>> ObjGenEx = new GenericExecutionResult<List<TariffSubmissionAttachmentEntity>>();
            try
            {
                ResTariff Objcommon = new ResTariff();
                ObjGenEx = Objcommon.GetTraiffAttachmentDetails(objTariffAttachment);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        /// <summary>
        /// The GetExistingTariffRateSec:implements the business action.
        /// </summary>
        /// <param name="industry">selected Indusrty</param>
        /// <param name="subIndustry">selected Indusrty Subtype</param>
        /// <param name="companySeq">selected Company</param>
        /// <author>Rajani Patra</author>
        /// <creationDate>2011-Aug-30</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TariffRateSection>> GetExistingTariffRateSec(System.String industry, System.String subIndustry, System.String companySeq)
        {
            GenericExecutionResult<List<TariffRateSection>> ObjGenEx = new GenericExecutionResult<List<TariffRateSection>>(); ;
            try
            {
                ResTariff ObjResTariff = new ResTariff();
                ObjGenEx = ObjResTariff.GetExistingTariffRateSec(industry, subIndustry, companySeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        /// <summary>
        /// The GetSearchTariffRecords:implements the business action.
        /// </summary>
        /// <param name="tariffSearchEntity">the search criteria entity</param>       
        /// <author>Rajani Patra</author>
        /// <creationDate>2011-Sep-06</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TariffSearchResultEntity>> GetSearchTariffRecords(TariffSearchEntity tariffSearchEntity)
        {
            GenericExecutionResult<List<TariffSearchResultEntity>> ObjGenEx = new GenericExecutionResult<List<TariffSearchResultEntity>>(); ;
            try
            {
                ResTariff ObjResTariff = new ResTariff();
                ObjGenEx = ObjResTariff.GetSearchTariffRecords(tariffSearchEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        ///// <summary>
        ///// ManageTariffSMetaData:implements the business action. .
        ///// </summary>
        ///// <param name="TarrifsubmEntity">the search criteria entity</param>
        ///// <returns>Returns the GenericExecutionResult of Int16</returns>
        ///// <author>Jay Prakash</author>
        ///// <creationDate>2011-06-09</ceationDate>
        ///// <modifications>
        ///// <item>Date;By;Description</item>
        ///// <item>Date;By;Description</item>
        ///// </modifications>

        //public GenericExecutionResult<System.Int16> ManageTariffSMetaData(TariffSubmissionEntity TarrifsubmEntity)
        //{
        //    GenericExecutionResult<System.Int16> ObjGenEx = null;
        //    try
        //    {
        //        ResTariff ObjResTariff = new ResTariff();
        //        ObjGenEx = ObjResTariff.ManageTariffSMetaData(TarrifsubmEntity);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return ObjGenEx;
        //}       
        /// <summary>
        /// GetActulTariffRateSecDeatil :implements the business action.
        /// </summary>
        /// <param name="TraiffBookNumber">the Tariff Book ID</param>       
        /// <author>Rajani Patra</author>
        /// <creationDate>2011-Oct-07</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TariffBookEntity>> GetActulTariffRateSecDeatil(System.String TraiffBookNumber)
        {
            GenericExecutionResult<List<TariffBookEntity>> ObjGenEx = new GenericExecutionResult<List<TariffBookEntity>>(); ;
            try
            {
                ResTariff ObjResTariff = new ResTariff();
                ObjGenEx = ObjResTariff.GetActulTariffRateSecDeatil(TraiffBookNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }        
        /// <summary> 
        /// SubmitTariff implements the business action - SubmitTariff. 
        /// </summary>
        /// <param name="eventType">eventType String</param>
        /// <param name="action">action String</param>
        /// <returns>String contaning notification event code</returns>
        /// <author>Rajani Patra</author>
        /// <creationDate>2012-01-19</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        private System.String getEventCode(System.String eventType, System.String action)
        {
            System.String eventCode = String.Empty;

            if (action == "Submission")
            {
                switch (eventType)
                {
                    //Submission (Establish New Tariff: Staff)
                    //An email notification should be generated and sent to  the Submitter 
                    //& Clerk of the Commission (CEO) on the Submission.
                    //Refer BR  BR-ISNTE-0008 & BR-ISTE-0009
                    case CQM.Common.Constants.Constants.NewTariffSubmission:
                        eventCode = "E0003";
                        break;
                    //Submission (Establish New Tariff: Staff)
                    //An email notification should be generated and sent to  the 
                    //Submitter & Clerk of the Commission (CEO) on the Submission.
                    //Refer BR   BR-ISNTE-0008 & BR-ISTE-0009 
                    case CQM.Common.Constants.Constants.NewRateSectioninExistingBook:
                        eventCode = "E0004";
                        break;
                    //Submission (Revision to Rate/Section: Staff)
                    //An email notification should be generated and sent to  the Submitter & Clerk of the Commission (CEO) on the Submission.
                    //Refer BR   BR-ISNTE-0008 & BR-ISTE-0009 
                    case CQM.Common.Constants.Constants.RevisionTariff:
                        eventCode = "E0005";
                        break;
                    //Submission (Complete Set of Rates/Sections: Staff)
                    //An email notification should be generated and sent to  the Submitter & Clerk of the Commission (CEO) on the Submission.
                    //Refer BR   BR-ISNTE-0008 & BR-ISTE-0009 
                    case CQM.Common.Constants.Constants.MultipleRateSectionSubmission:
                        eventCode = "E0006";
                        break;

                }

            }           
            return eventCode;

        }
        /// <summary> 
        /// SubmitTariff set the notification status to send it to UI layer. 
        /// </summary>
        /// <param name="tariffSubEntity">EmailSendAcknowledgement object</param>
        /// <returns>CQM.Common.Utility.notificationStatus</returns>
        /// <author>Rajani Patra</author>
        /// <creationDate>2012-19-01</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public CQM.Common.Utility.notificationStatus setNotificationStatus(CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement)
        {
            CQM.Common.Utility.notificationStatus _notificationStatus;
            if (l_ObjEmailSendAcknowledgement.SendStatus == CQM.Notification.AcknowledgementStatus.SendAll)
            {
                _notificationStatus = CQM.Common.Utility.notificationStatus.SendAll;
            }
            else if (l_ObjEmailSendAcknowledgement.SendStatus == CQM.Notification.AcknowledgementStatus.SendPartial)
            {
                _notificationStatus = CQM.Common.Utility.notificationStatus.SendFailed;
            }
            else
            {
                _notificationStatus = CQM.Common.Utility.notificationStatus.SendPartial;
            }

            return _notificationStatus;
        }

    }
}

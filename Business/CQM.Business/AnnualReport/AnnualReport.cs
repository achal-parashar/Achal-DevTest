//---------------------------------------------------------------------
// Author: Amarendra
// Version: 1.0.0
// Date: 11/01/2011
// Description:Implement Report Master Bussiness Class
//
// History:
// Changed By:                        Changed On: 
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

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
    /// This class provide function Definition related to Annual Report.
    /// </summary>
    /// <author>Amarendra Kumar Singh</author>
    /// <creationDate>2011-11-01</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class AnnualReport
    {
        
        private ResAnnualReport resAnnualReport;
        public ResAnnualReport ResAnnualReport 
        { 
            get
            {
                if (resAnnualReport == null)
                {
                    resAnnualReport = new ResAnnualReport();
                    return resAnnualReport;
                }
                else
                {
                    return resAnnualReport;
                }
            }
        }


        #region SubmitAssmntReport
        /// <summary>
        /// Submit Annual Report Assesment
        /// </summary>
        /// <param name="p_AssessmentSubmissionEntity"></param>

        /// <returns>Object of GenericExecutionResult, contains Insert status as string</returns>
        /// <author>Amarendra</author>
        /// <creationDate>2011-08-12</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.String> SubmitAssmntReport(AssessmentSubmissionEntity p_AssessmentSubmissionEntity)
        {
            GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
            try
            {
                ObjGenEx = ResAnnualReport.SubmitAssmntReport(p_AssessmentSubmissionEntity);
                if (ObjGenEx.IsSuccess)
                {
                    CQM.Notification.NotificationInputEntity l_ObjNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    l_ObjNotificationInputEntity.EventCode = CQM.Common.Constants.EmailNotificationEventCode.AnnualReport.Submission;
                    l_ObjNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.ReturnValue;
                    CQM.Notification.NotificationAbstract l_ObjNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(l_ObjNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement = l_ObjNotificationAbstract.SendNotification(l_ObjNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    ObjGenEx.notificationStatus = (notificationStatus)((int)l_ObjEmailSendAcknowledgement.SendStatus);
                }
                //End
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        #endregion

        #region Get Report Type by Industry Sub Type Code
        /// <summary>
        ///  Implement Get Report by IndustrySubtypCode .
        /// </summary>
        /// <param name="p_IndustrySubTypeCode"></param>
        /// <returns>List of report entity.</returns>
        /// <author>Amarendra</author>
        /// <creationDate>2011-08-17</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        /// 

        public List<KeyValueStruct> GetReportbyIndSubTypeCode(string p_IndustrySubTypeCode)
        {
            List<KeyValueStruct> l_objReportTypeList = null;
            try
            {

                l_objReportTypeList = ResAnnualReport.GetReportbyIndSubTypeCode(p_IndustrySubTypeCode);
            }
            catch
            {
                throw;
            }
            return l_objReportTypeList;
        }
        #endregion

        #region Get Report Type List
        /// <summary>
        ///  Implement Get Report List.
        /// </summary>
        /// <returns>List of report entity.</returns>
        /// <author>Amarendra</author>
        /// <creationDate>2011-08-17</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        /// 

        public List<KeyValueStruct> GetReportList()
        {
            List<KeyValueStruct> l_objReportTypeList = null;
            try
            {

                l_objReportTypeList = ResAnnualReport.GetReportList();
            }
            catch
            {
                throw;
            }
            return l_objReportTypeList;
        }
        #endregion

        #region Get Industry Sub Type List
        /// <summary>
        ///  Implement Get Industry Sub Type List.
        /// </summary>
        /// <returns>List of Industry Sub Type entity.</returns>
        /// <author>Kishore</author>
        /// <creationDate>2011-09-12</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        /// 

        public List<KeyValueStruct> GetIndustrySubTypList()
        {
            List<KeyValueStruct> l_objIndustrySubTypList = null;
            try
            {

                l_objIndustrySubTypList = ResAnnualReport.GetIndustrySubTypList();
            }
            catch
            {
                throw;
            }
            return l_objIndustrySubTypList;
        }
        #endregion

         #region SubmitAnalysisDataWater
         /// <summary>
         /// Implement Submit Analysis Data Water Utility.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Insert status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> SubmitAnalysisDataWater(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.SubmitAnalysisDataWater(p_AnalysisSubmissionEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region SubmitAnalysisDataElectric
         /// <summary>
         /// Implement Submit Analysis Data Electric Utility.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Insert status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> SubmitAnalysisDataElectric(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.SubmitAnalysisDataElectric(p_AnalysisSubmissionEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region SubmitAnalysisDataCEP
         /// <summary>
         /// Implement Submit Analysis Data Electric Utility CEP subtype.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Insert status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> SubmitAnalysisDataCEP(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.SubmitAnalysisDataCEP(p_AnalysisSubmissionEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region SubmitAnalysisDataILEC
         /// <summary>
         /// Implement Submit Analysis Data Telephone Utility ILEC subtype.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Insert status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> SubmitAnalysisDataILEC(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.SubmitAnalysisDataILEC(p_AnalysisSubmissionEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region SubmitAnalysisDataCLEC
         /// <summary>
         /// Implement Submit Analysis Data Telephone Utility CLEC subtype.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Insert status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> SubmitAnalysisDataCLEC(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.SubmitAnalysisDataCLEC(p_AnalysisSubmissionEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region SubmitAnalysisDataGas
         /// <summary>
         /// Implement Submit Analysis Data Gas Utility.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Insert status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> SubmitAnalysisDataGas(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.SubmitAnalysisDataGas(p_AnalysisSubmissionEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region Search Annual Report
         /// <summary>
         /// The GetAnnualReportSearchResult function will facilitate to get Annual Report results 
         /// </summary>
         /// <param name="p_ReportEntity"></param>
         /// <author>Kumar</author>
         /// <creationDate>2011-09-05</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>
         public GenericExecutionResult<List<ReportEntity>> GetAnnualReportSearchResult(ReportEntity p_ReportEntity)
         {
             GenericExecutionResult<List<ReportEntity>> ObjGenEx = new GenericExecutionResult<List<ReportEntity>>();
             try
             {

                 ObjGenEx = ResAnnualReport.GetAnnualReportSearchResult(p_ReportEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;

         }
#endregion

         #region Search Annual Report Not Recieved For
         /// <summary>
         /// The GetAnnualReportSearchResultNRF function will facilitate to get company list who not filed Annual Report 
         /// </summary>
         /// <param name="p_ReportEntity"></param>
         /// <author>Kumar</author>
         /// <creationDate>2011-09-05</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>
         public GenericExecutionResult<List<ReportEntity>> GetAnnualReportSearchResultNRF(ReportEntity p_ReportEntity)
         {
             GenericExecutionResult<List<ReportEntity>> ObjGenEx = new GenericExecutionResult<List<ReportEntity>>();
             try
             {

                 ObjGenEx = ResAnnualReport.GetAnnualReportSearchResultNRF(p_ReportEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;

         }
         #endregion

         #region Get State List
         /// <summary>
         /// Get State List.
         /// </summary>
         /// <param name=""></param>
         /// <returns>List of States.</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-05</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>        
         public List<KeyValueStruct> GetStateList()
         {
             List<KeyValueStruct> l_objStateList = null;
             try
             {

                 l_objStateList = ResAnnualReport.GetStateList();
             }
             catch
             {
                 throw;
             }
             return l_objStateList;
         }
        #endregion

         #region Get Industry Sub Type for Annual Reoprt
         /// <summary>
         ///  Implement Get Industry-Sub Type List for Annual Report.
         /// </summary>
         /// <param name="p_IndustryTypeCode"></param>
         /// <returns>List of report entity.</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-17</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>
         /// 


         public List<KeyValueStruct> GetARIndSubTypeList(string p_IndustryTypeCode)
         {
             List<KeyValueStruct> l_objIndSubTypeList = null;
             try
             {

                 l_objIndSubTypeList = ResAnnualReport.GetARIndSubTypeList(p_IndustryTypeCode);
             }
             catch
             {
                 throw;
             }
             return l_objIndSubTypeList;
         }
         #endregion

         #region Get Annaul Report Assessment Details by tracking Number
         /// <summary>
         /// Get Annaul Report Assessment Details by tracking Number
         /// </summary>
         /// <param name="p_TrackingNumber"></param>
         /// <param name="p_CompanySeqList"></param> 
        /// <returns>AssessmentSubmissionEntity entity.</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-07</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public AssessmentSubmissionEntity GetAnnualReportAssessmentDetails(string p_TrackingNumber, string p_CompanySeqList)
         {
             AssessmentSubmissionEntity l_ObjAssessmentSubmissionEntity = null;
             try
             {
                 l_ObjAssessmentSubmissionEntity = ResAnnualReport.GetAnnualReportAssessmentDetails(p_TrackingNumber, p_CompanySeqList);
             }
             catch
             {
                 throw;
             }
             return l_ObjAssessmentSubmissionEntity;
         }
         #endregion

         #region Get Analysis Field Data for Utility Type Electric and Sub-Type T&D
         /// <summary>
         /// Get Analysis Field Data for Utility Type Electric and Sub-Type T&D.
         /// </summary>
         /// <param name="p_TrackingNumber"></param>
         /// <returns>AnalysisSubmissionEntity entity.</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-07</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public AnalysisSubmissionEntity GetAnalysisDataElectricDetails(string p_TrackingNumber)
         {
             AnalysisSubmissionEntity l_ObjAnalysisSubmissionEntity = null;
             try
             {
                 l_ObjAnalysisSubmissionEntity = ResAnnualReport.GetAnalysisDataElectricDetails(p_TrackingNumber);
             }
             catch
             {
                 throw;
             }
             return l_ObjAnalysisSubmissionEntity;
         }
         #endregion

         #region Get Analysis Field Data for Utility Type Electric and Sub-Type CEP
         /// <summary>
         /// Get Analysis Field Data for Utility Type Electric and Sub-Type CEP.
         /// </summary>
         /// <param name="p_TrackingNumber"></param>
         /// <returns>AnalysisSubmissionEntity entity.</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-07</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public AnalysisSubmissionEntity GetAnalysisDataCEPDetails(string p_TrackingNumber)
         {
             AnalysisSubmissionEntity l_ObjAnalysisSubmissionEntity = null;
             try
             {
                 l_ObjAnalysisSubmissionEntity = ResAnnualReport.GetAnalysisDataCEPDetails(p_TrackingNumber);
             }
             catch
             {
                 throw;
             }
             return l_ObjAnalysisSubmissionEntity;
         }
         #endregion

         #region Get Analysis Field Data for Utility Type Communication and Sub-Type ILEC
         /// <summary>
         /// Get Analysis Field Data for Utility Type Communication and Sub-Type ILEC.
         /// </summary>
         /// <param name="p_TrackingNumber"></param>
         /// <returns>AnalysisSubmissionEntity entity.</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-07</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public AnalysisSubmissionEntity GetAnalysisDataILECDetails(string p_TrackingNumber)
         {
             AnalysisSubmissionEntity l_ObjAnalysisSubmissionEntity = null;
             try
             {
                 l_ObjAnalysisSubmissionEntity = ResAnnualReport.GetAnalysisDataILECDetails(p_TrackingNumber);
             }
             catch
             {
                 throw;
             }
             return l_ObjAnalysisSubmissionEntity;
         }
         #endregion

         #region Get Analysis Field Data for Utility Type Communication and Sub-Type CLEC
         /// <summary>
         /// Get Analysis Field Data for Utility Type Communication and Sub-Type CLEC.
         /// </summary>
         /// <param name="p_TrackingNumber"></param>
         /// <returns>AnalysisSubmissionEntity entity.</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-07</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public AnalysisSubmissionEntity GetAnalysisDataCLECDetails(string p_TrackingNumber)
         {
             AnalysisSubmissionEntity l_ObjAnalysisSubmissionEntity = null;
             try
             {
                 l_ObjAnalysisSubmissionEntity = ResAnnualReport.GetAnalysisDataCLECDetails(p_TrackingNumber);
             }
             catch
             {
                 throw;
             }
             return l_ObjAnalysisSubmissionEntity;
         }
         #endregion

         #region Get Analysis Field Data for Utility Type Gas
         /// <summary>
         /// Get Analysis Field Data for Utility Type Gas.
         /// </summary>
         /// <param name="p_TrackingNumber"></param>
         /// <returns>AnalysisSubmissionEntity entity.</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-07</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public AnalysisSubmissionEntity GetAnalysisDataGasDetails(string p_TrackingNumber)
         {
             AnalysisSubmissionEntity l_ObjAnalysisSubmissionEntity = null;
             try
             {
                 l_ObjAnalysisSubmissionEntity = ResAnnualReport.GetAnalysisDataGasDetails(p_TrackingNumber);
             }
             catch
             {
                 throw;
             }
             return l_ObjAnalysisSubmissionEntity;
         }
         #endregion

         #region Get Analysis Field Data for Utility Type Water
         /// <summary>
         /// Get Analysis Field Data for Utility Type Water.
         /// </summary>
         /// <param name="p_TrackingNumber"></param>
         /// <returns>AnalysisSubmissionEntity entity.</returns>
         /// <author>Kishore</author>
         /// <creationDate>2011-09-12</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public AnalysisSubmissionEntity GetAnalysisDataWaterDetails(string p_TrackingNumber)
         {
             AnalysisSubmissionEntity l_ObjAnalysisSubmissionEntity = null;
             try
             {
                 l_ObjAnalysisSubmissionEntity = ResAnnualReport.GetAnalysisDataWaterDetails(p_TrackingNumber);
             }
             catch
             {
                 throw;
             }
             return l_ObjAnalysisSubmissionEntity;
         }
         #endregion

         //Added By Anuj For DEFW270
         #region UpdateAnalysisDataCEP
         /// <summary>
         /// Implement Update Analysis Data Electric Utility CEP subtype.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Update status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</creationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> UpdateAnalysisDataCEP(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.UpdateAnalysisDataCEP(p_AnalysisSubmissionEntity);
                 //// Start Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014
                 //if (ObjGenEx.IsSuccess)
                 //{
                 //    CQM.Notification.NotificationInputEntity l_ObjNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                 //    //l_ObjNotificationInputEntity.EventCode = CQM.Common.Constants.EmailNotificationEventCode.AnnualReport.ReviseSubmission;

                 //    l_ObjNotificationInputEntity.EventCode = "E0113";

                 //    //Line no 687 updated by Amarendra on 2012-01-20
                 //    //l_ObjNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.ReturnValue;
                 //    l_ObjNotificationInputEntity.TrckingReferenceNumber = p_AnalysisSubmissionEntity.TrackingNumber;
                 //    //End Line no 690 updated by Amarendra on 2012-01-20

                 //    CQM.Notification.NotificationAbstract l_ObjNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(l_ObjNotificationInputEntity);
                 //    CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement = l_ObjNotificationAbstract.SendNotification(l_ObjNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                 //    ObjGenEx.notificationStatus = (notificationStatus)((int)l_ObjEmailSendAcknowledgement.SendStatus);
                 //}
                 //// End Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014 
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion
         //Added By Anuj For DEFW270

         #region UpdateAnalysisDataElectric
         /// <summary>
         /// Implement Update Analysis Data Electric Utility.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Update status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> UpdateAnalysisDataElectric(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.UpdateAnalysisDataElectric(p_AnalysisSubmissionEntity);
                 //// Start Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014
                 //if (ObjGenEx.IsSuccess)
                 //{
                 //    CQM.Notification.NotificationInputEntity l_ObjNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                 //    //l_ObjNotificationInputEntity.EventCode = CQM.Common.Constants.EmailNotificationEventCode.AnnualReport.ReviseSubmission;

                 //    l_ObjNotificationInputEntity.EventCode = "E0113";

                 //    //Line no 687 updated by Amarendra on 2012-01-20
                 //    //l_ObjNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.ReturnValue;
                 //    l_ObjNotificationInputEntity.TrckingReferenceNumber = p_AnalysisSubmissionEntity.TrackingNumber;
                 //    //End Line no 690 updated by Amarendra on 2012-01-20

                 //    CQM.Notification.NotificationAbstract l_ObjNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(l_ObjNotificationInputEntity);
                 //    CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement = l_ObjNotificationAbstract.SendNotification(l_ObjNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                 //    ObjGenEx.notificationStatus = (notificationStatus)((int)l_ObjEmailSendAcknowledgement.SendStatus);
                 //}
                 //// End Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014 
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region UpdateAnalysisDataILEC
         /// <summary>
         /// Implement Update Analysis Data Telephone Utility ILEC subtype.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Update status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> UpdateAnalysisDataILEC(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.UpdateAnalysisDataILEC(p_AnalysisSubmissionEntity);
                 //// Start Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014
                 //if (ObjGenEx.IsSuccess)
                 //{
                 //    CQM.Notification.NotificationInputEntity l_ObjNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                 //    //l_ObjNotificationInputEntity.EventCode = CQM.Common.Constants.EmailNotificationEventCode.AnnualReport.ReviseSubmission;

                 //    l_ObjNotificationInputEntity.EventCode = "E0113";

                 //    //Line no 687 updated by Amarendra on 2012-01-20
                 //    //l_ObjNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.ReturnValue;
                 //    l_ObjNotificationInputEntity.TrckingReferenceNumber = p_AnalysisSubmissionEntity.TrackingNumber;
                 //    //End Line no 690 updated by Amarendra on 2012-01-20

                 //    CQM.Notification.NotificationAbstract l_ObjNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(l_ObjNotificationInputEntity);
                 //    CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement = l_ObjNotificationAbstract.SendNotification(l_ObjNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                 //    ObjGenEx.notificationStatus = (notificationStatus)((int)l_ObjEmailSendAcknowledgement.SendStatus);
                 //}
                 //// End Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014 
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region UpdateAnalysisDataCLEC
         /// <summary>
         /// Implement Update Analysis Data Telephone Utility CLEC subtype.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Update status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> UpdateAnalysisDataCLEC(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.UpdateAnalysisDataCLEC(p_AnalysisSubmissionEntity);
                 //// Start Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014
                 //if (ObjGenEx.IsSuccess)
                 //{
                 //    CQM.Notification.NotificationInputEntity l_ObjNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                 //    //l_ObjNotificationInputEntity.EventCode = CQM.Common.Constants.EmailNotificationEventCode.AnnualReport.ReviseSubmission;

                 //    l_ObjNotificationInputEntity.EventCode = "E0113";

                 //    //Line no 687 updated by Amarendra on 2012-01-20
                 //    //l_ObjNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.ReturnValue;
                 //    l_ObjNotificationInputEntity.TrckingReferenceNumber = p_AnalysisSubmissionEntity.TrackingNumber;
                 //    //End Line no 690 updated by Amarendra on 2012-01-20

                 //    CQM.Notification.NotificationAbstract l_ObjNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(l_ObjNotificationInputEntity);
                 //    CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement = l_ObjNotificationAbstract.SendNotification(l_ObjNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                 //    ObjGenEx.notificationStatus = (notificationStatus)((int)l_ObjEmailSendAcknowledgement.SendStatus);
                 //}
                 //// End Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014 
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region UpdateAnalysisDataGas
         /// <summary>
         /// Implement Update Analysis Data Gas Utility.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Update status as string</returns>
         /// <author>Amarendra</author>
         /// <creationDate>2011-08-25</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> UpdateAnalysisDataGas(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.UpdateAnalysisDataGas(p_AnalysisSubmissionEntity);
                 //// Start Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014
                 //if (ObjGenEx.IsSuccess)
                 //{
                 //    CQM.Notification.NotificationInputEntity l_ObjNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                 //    //l_ObjNotificationInputEntity.EventCode = CQM.Common.Constants.EmailNotificationEventCode.AnnualReport.ReviseSubmission;

                 //    l_ObjNotificationInputEntity.EventCode = "E0113";

                 //    //Line no 687 updated by Amarendra on 2012-01-20
                 //    //l_ObjNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.ReturnValue;
                 //    l_ObjNotificationInputEntity.TrckingReferenceNumber = p_AnalysisSubmissionEntity.TrackingNumber;
                 //    //End Line no 690 updated by Amarendra on 2012-01-20

                 //    CQM.Notification.NotificationAbstract l_ObjNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(l_ObjNotificationInputEntity);
                 //    CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement = l_ObjNotificationAbstract.SendNotification(l_ObjNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                 //    ObjGenEx.notificationStatus = (notificationStatus)((int)l_ObjEmailSendAcknowledgement.SendStatus);
                 //}
                 //// End Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014 
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion

         #region UpdateAnalysisDataWater
         /// <summary>
         /// Implement Update Analysis Data Water Utility.
         /// </summary>
         /// <param name="p_AnalysisSubmissionEntity"></param>
         /// <returns>Object of GenericExecutionResult, contains Update status as string</returns>
         /// <author>Kishore</author>
         /// <creationDate>2011-09-12</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications>

         public GenericExecutionResult<System.String> UpdateAnalysisDataWater(AnalysisSubmissionEntity p_AnalysisSubmissionEntity)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ObjGenEx = ResAnnualReport.UpdateAnalysisDataWater(p_AnalysisSubmissionEntity);
                 //// Start Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014
                 //if (ObjGenEx.IsSuccess)
                 //{
                 //    CQM.Notification.NotificationInputEntity l_ObjNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                 //    //l_ObjNotificationInputEntity.EventCode = CQM.Common.Constants.EmailNotificationEventCode.AnnualReport.ReviseSubmission;

                 //    l_ObjNotificationInputEntity.EventCode = "E0113";

                 //    //Line no 687 updated by Amarendra on 2012-01-20
                 //    //l_ObjNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.ReturnValue;
                 //    l_ObjNotificationInputEntity.TrckingReferenceNumber = p_AnalysisSubmissionEntity.TrackingNumber;
                 //    //End Line no 690 updated by Amarendra on 2012-01-20

                 //    CQM.Notification.NotificationAbstract l_ObjNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(l_ObjNotificationInputEntity);
                 //    CQM.Notification.EmailSendAcknowledgement l_ObjEmailSendAcknowledgement = l_ObjNotificationAbstract.SendNotification(l_ObjNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                 //    ObjGenEx.notificationStatus = (notificationStatus)((int)l_ObjEmailSendAcknowledgement.SendStatus);
                 //}
                 //// End Added By Ashish Srivastava For CQM70(revision notification) on 17-11-2014 
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion


         #region Search Case
         /// <summary>
         /// The GetCaseSearchResult function will facilitate to get case result
         /// </summary>
         /// <param name="p_CaseSearchEntity"></param>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-12</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications> 
         public GenericExecutionResult<List<CaseSearchEntity>> GetCaseSearchResult(CaseSearchEntity p_CaseSearchEntity)
         {
             GenericExecutionResult<List<CaseSearchEntity>> ObjGenEx = null;
             try
             {

                 ObjGenEx = ResAnnualReport.GetCaseSearchResult(p_CaseSearchEntity);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;

         }
         #endregion

         #region Get Protective Order List
         /// <summary>
         /// The GetProtectiveOrderList function will facilitate to get Protective Order List
         /// </summary>
         /// <param name="p_caseNumber"></param>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-12</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications> 
         /// 
        //public GenericExecutionResult<List<CaseSearchEntity>> GetProtectiveOrderList(string p_caseNumber)
         public GenericExecutionResult<List<CaseSearchEntity>> GetProtectiveOrderList(CaseSearchEntity p_CaseSearchEntity)
             {
             GenericExecutionResult<List<CaseSearchEntity>> ObjGenEx = null;
             try
                 {
                     //Start by Rajbir for DEFW47 on 1/2/2013
                     //ObjGenEx = ResAnnualReport.GetProtectiveOrderList(p_caseNumber);
                     ObjGenEx = ResAnnualReport.GetProtectiveOrderList(p_CaseSearchEntity);
                     //End by Rajbir for DEFW47 on 1/2/2013                 
                 }
             catch
                 {
                 throw;
                 }
             return ObjGenEx;

             }
         #endregion

         #region Get Mime Type Image Path
         /// <summary>
         /// The GetMimeTypeImagePath function will get Mime Type Image Path on the basis of File Extn
         /// </summary>
         /// <param name="p_fileExtn"></param>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-12</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications> 
         public string GetMimeTypeImagePath(string p_fileExtn)
         {
             string l_strMimiImagePath = "";
             try
             {

                 l_strMimiImagePath = ResAnnualReport.GetMimeTypeImagePath(p_fileExtn);
             }
             catch
             {
                 throw;
             }
             return l_strMimiImagePath;

         }
         #endregion

         #region Get Attached Document List
         /// <summary>
         ///  Implement Attached Document List .
         /// </summary>
         /// <param name="p_TrackingNumber"></param>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-12</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications> 
         public List<AttachDocumentEntity> GetAttachedDocumentList(string p_TrackingNumber)
         {
             List<AttachDocumentEntity> l_objAttachDocumentList = null;
             try
             {
                 decimal l_TtlDocSize = 0m;
                 l_objAttachDocumentList = ResAnnualReport.GetAttachedDocumentList(p_TrackingNumber, ref l_TtlDocSize);
             }
             catch
             {
                 throw;
             }
             return l_objAttachDocumentList;

         }
         #endregion

         #region Get Protective Order List By Pro Document Sequence List
         /// <summary>
         /// The GetProtectiveOrderList function will facilitate to get Protective Order List
         /// </summary>
         /// <param name="p_ProDocumentSeqList"></param>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-12</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications> 
         public GenericExecutionResult<List<CaseSearchEntity>> GetProtectiveOrderListByProSeqList(string p_ProDocumentSeqList)
             {
             GenericExecutionResult<List<CaseSearchEntity>> ObjGenEx = null;
             try
                 {

                 ObjGenEx = ResAnnualReport.GetProtectiveOrderListByProSeqList(p_ProDocumentSeqList);
                 }
             catch
                 {
                 throw;
                 }
             return ObjGenEx;

             }
         #endregion

         #region Get Protective Order List By Document Sequence
         /// <summary>
         /// The GetProtectiveOrderList function will facilitate to get Protective Order List
         /// </summary>
         /// <param name="p_DocumentSeq"></param>
         /// <author>Amarendra</author>
         /// <creationDate>2011-09-12</ceationDate>
         /// <modifications>
         /// <item>Date;By;Description</item>
         /// <item>Date;By;Description</item>
         /// </modifications> 
         public GenericExecutionResult<List<CaseSearchEntity>> GetProtectiveOrderListByDocumentSeq(int p_DocumentSeq)
             {
             GenericExecutionResult<List<CaseSearchEntity>> ObjGenEx = null;
             try
                 {

                 ObjGenEx = ResAnnualReport.GetProtectiveOrderListByDocumentSeq(p_DocumentSeq);
                 }
             catch
                 {
                 throw;
                 }
             return ObjGenEx;

             }
         #endregion


         //Added by Piyush | 16 May 2012 | Secure doc view scenario
         #region Check accessibility of documents
         /// <summary>
         /// Implements wrapper method for the business action - Is confidential Doc will be visible to Logged in user or not.
         /// </summary>
         /// <param name="DocRefNum">Document Reference Number</param>
         /// <param name="UserID">User Id</param>
         /// <returns>string value</returns>
         /// <author>Piyush Bajpai</author>
         /// <creationDate>16 May 2012</ceationDate>
         /// <modifications>
         /// <item></item>
         /// <item>Date;By;Description</item>
         /// </modifications>
         public GenericExecutionResult<System.String> IsDocAccessible(System.String DocRefNum, System.String UserID)
         {
             GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>();
             try
             {
                 ResAnnualReport ObjResMatterMgmt = new ResAnnualReport();
                 ObjGenEx = ObjResMatterMgmt.IsDocAccessible(DocRefNum, UserID);
             }
             catch
             {
                 throw;
             }
             return ObjGenEx;
         }
         #endregion
    }

    
}

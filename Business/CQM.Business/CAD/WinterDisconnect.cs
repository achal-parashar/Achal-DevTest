//---------------------------------------------------------------------
// Author: Jay Prakash  
// Version: 1.0.0
// Date: 05/19/2011
// Description:  Implement Case Subtype Bussiness Class
//
// History:
// Changed By                       
//Changed On
//
//---------------------------------------------------------------------
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using CQM.Entities;
using CQM.Resource;
using CQM.Common.ExecutionResults;

using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;

namespace CQM.Business
{
    /// <summary>
    /// This class provide functions related to Case Subtype.
    /// </summary>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-05-19</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
   public class WinterDisconnect
    {
        /// <summary>
        /// Get Case Sub Type as per the Case Type
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return List of Case SubType</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-05-19</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<WinterDisEntity>> GetCADCaseSubtype(System.String Case_Type)
        {
            GenericExecutionResult<List<WinterDisEntity>> ObjGenEx = new GenericExecutionResult<List<WinterDisEntity>>();
            try
            {
                //Process object data
                ResWinterDisconnect ObjResWinterDisconnectMaster = new ResWinterDisconnect();
                ObjGenEx = ObjResWinterDisconnectMaster.GetCADCaseSubtype(Case_Type);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Get Utility Sub Type as per the Case Type
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return List of Utility SubType</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-05-20</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<WinterDisEntity>> GetUtilitySubtype(System.String Utility_Type_Code)
        {
            GenericExecutionResult<List<WinterDisEntity>> ObjGenEx = new GenericExecutionResult<List<WinterDisEntity>>();
            try
            {
                //Process object data
                ResWinterDisconnect ObjResWinterDisconnectMaster = new ResWinterDisconnect();
                ObjGenEx = ObjResWinterDisconnectMaster.GetUtilitySubtype(Utility_Type_Code);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Submit Winter Disconnect
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Submit Winter Disconnect</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-05-20</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int32> SubmitWinterDisconnect(WinterDisEntity WinterDisEntity, bool IsInternalUser)
        {
            //Entity level Validation
            //bool bValidationRequired = false;
            //if (bValidationRequired)
            //{
            //    ValidationResults validationResults = Validation.ValidateFromConfiguration(WinterDisEntity);
            //    if (!validationResults.IsValid)
            //    {
            //        StringBuilder strmessage = new StringBuilder();
            //        foreach (ValidationResult validationResult in validationResults)
            //        {
            //            System.String strvalidationResultMessage = validationResult.Message;
            //            strmessage.AppendLine(String.Format("{0}", strvalidationResultMessage));
            //        }
            //        throw new InvalidOperationException(strmessage.ToString());
            //    }
            //}
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResWinterDisconnect ObjWinterDis = new ResWinterDisconnect();
                ObjGenEx = ObjWinterDis.SubmitWinterDisconnect(WinterDisEntity, IsInternalUser);

                //EMail notification added by Rajbir on 3/3/2013
                if (ObjGenEx.IsSuccess)
                {
                    CQM.Notification.NotificationInputEntity objNotificationInputEntity = new CQM.Notification.NotificationInputEntity();
                    objNotificationInputEntity.EventCode = "E0033";
                    objNotificationInputEntity.TrckingReferenceNumber = ObjGenEx.Messages[1];
                    CQM.Notification.NotificationAbstract objNotificationAbstract = CQM.Notification.NotificationFactory.GetNotification(objNotificationInputEntity);
                    CQM.Notification.EmailSendAcknowledgement ObjEmailSendAcknowledgement = objNotificationAbstract.SendNotification(objNotificationAbstract, CQM.Notification.SendMailTo.Individual);
                    //ObjGenEx.notificationStatus = (notificationStatus)((int)ObjEmailSendAcknowledgement.SendStatus);
                    int notificationStatus = (int)ObjEmailSendAcknowledgement.SendStatus;
                }

                //Change end added by Rajbir on 3/3/2013

            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
    }
}

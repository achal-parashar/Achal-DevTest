//---------------------------------------------------------------------
// Author: Jay Prakash  
// Version: 1.0.0
// Date: 05/19/2011
// Description:  Implement Generate Letter Bussiness Class
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
using System.Net.Sockets;
namespace CQM.Business
{
    /// <summary>
    /// This class provide functions related to Generate Letter.
    /// </summary>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-05-19</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class CadGenerateLetter
    {
        public void GenerateLetter(TemplateEntity TempEntity)
        {
            ResGenerateLetter objgenerateletter = new ResGenerateLetter();
            objgenerateletter.GenerateLetter(TempEntity);
        }
        /// <summary>
        /// UploadLetterInFilenet
        /// </summary>
        /// <returns>Upload Letters in FileNet</returns>
        /// <author>Shailendra Tripathi</author>
        /// <creationDate>23 Aug 2011</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.String> UploadLetterInFilenet(LetterEntity cadLetterEntity, String CaseNumber, String CaseTypeInitial)
        {
            GenericExecutionResult<System.String> ObjGen = new GenericExecutionResult<System.String>();
            try
            {
                ResGenerateLetter ObjResGenerateLetter = new ResGenerateLetter();
                ObjGen = ObjResGenerateLetter.UploadLetterInFilenet(cadLetterEntity, CaseNumber, CaseTypeInitial);
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }

        /// <summary>
        /// Update the Print Queue and notification Information
        /// </summary>
        /// <param name="LetterDecisionSeq">LetterDecisionSeq for letter which is to be sent for Notification/PrintQueue</param>
        /// <param name="CadCaseNumber">CadCaseNumber</param>
        /// <param name="CaseTypeInitial">Action which is taken by user i.e. "CheckIn","CheckOut" or "UndoCheckOut".</param>
        /// <param name="UpdatedBy">Name of the user who has taken action.</param>
        /// <author>Shailendra tripathi</author>
        /// <creationDate>8 Sep 2011</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int32> UpdatePrintQueueAndNotification(System.Int32 LetterDecisionSeq, System.String CadCaseNumber, System.String CaseTypeInitial, System.String CreatedBy)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResGenerateLetter objResGenerateLetter = new ResGenerateLetter();
                ObjGenEx = objResGenerateLetter.UpdatePrintQueueAndNotification(LetterDecisionSeq, CadCaseNumber, CaseTypeInitial, CreatedBy);

                //Added for notification
                //Ping Letter notification service | Piyush | 28 Feb 2012
                if (ObjGenEx.IsSuccess)
                {
                    string textToSend;
                    string ReturnStatus = "";
                    NetworkStream nwStream;
                    int portNo;
                    string mstrIpAddress;
                    portNo = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("LetterNotificationPortNumber"));
                    mstrIpAddress = System.Configuration.ConfigurationManager.AppSettings.Get("LetterNotifcationIPAddress");

                    textToSend = LetterDecisionSeq + "|" + CadCaseNumber + "|" + CreatedBy;
                    if (LetterDecisionSeq > 0 && !String.IsNullOrEmpty(CadCaseNumber))
                    {
                        System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                        lock (tcpclient)
                        {
                            tcpclient.Connect(mstrIpAddress, portNo);
                            nwStream = tcpclient.GetStream();
                            byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                            byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                            object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                            ReturnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                            nwStream.Close();
                            tcpclient.Close();
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


    }
}

//---------------------------------------------------------------------
// Author: Deepak Kumar Singh
// Version: 1.0.0
// Date: 10/22/2007
// Description:Implement Document Class
//
// History:
// Changed By                       Changed On
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
using CQM.Common.MessageRepository;
using CQM.Common.ExecutionResults;

namespace CQM.Business
{

    /// <summary>
    /// This class provide functions related to manage document.
    /// </summary>
    /// <author>Deepak Kumar Singh</author>
    /// <creationDate>2007-12-01</ceationDate>
    /// <modifications>
    /// <item>2007-12-01;Deepak Singh;Added new Functions</item>
    /// <item>2007-12-22;Deepak Singh;Modified according to new database structure.</item>
    /// </modifications>
    public class Document
    {
        /// <summary>
        /// Get all document information.
        /// </summary>
        /// <returns></returns>
        /// <author>Deepak Kumar Singh</author>
        /// <creationDate>2007-12-01</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<DocumentEntity>> GetAllDocument()
        {
            //Process object data
            GenericExecutionResult<List<DocumentEntity>> result = null;
            try
            {
                ResDocument objResDocument = new ResDocument();
                result = objResDocument.GetAllDocument();
            }
            catch
            {
                throw;
            }
            return result;
        }

        /// <summary>
        /// Get document information by DocId.
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageNumber"></param>
        /// <param name="OrderBy"></param>
        /// <param name="DocID"></param>
        /// <returns></returns>
        /// <author>Deepak Kumar Singh</author>
        /// <creationDate>2007-12-01</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<DocumentEntity> GetWorkproductInfoByWorkproductSeq(System.Decimal WorkproductSeq)
        {
            //Process object data
            GenericExecutionResult<DocumentEntity> result = null;
            try
            {
                ResDocument objResDocument = new ResDocument();
                result = objResDocument.GetWorkproductInfoByWorkproductSeq(WorkproductSeq);
            }
            catch
            {
                throw;
            }
            return result;
        }

        /// <summary>
        /// Get document information by DocId.
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageNumber"></param>
        /// <param name="OrderBy"></param>
        /// <param name="DocID"></param>
        /// <returns></returns>
        /// <author>Deepak Kumar Singh</author>
        /// <creationDate>2007-12-01</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<DocumentEntity>> GetPagedDocumentByDocId(System.Int32 PageSize, System.Int32 PageNumber, System.String OrderBy, System.String DocID, System.Int32 AgendaSeq)
        {
            //Process object data
            GenericExecutionResult<List<DocumentEntity>> result = null;
            try
            {
                ResDocument objResDocument = new ResDocument();
                result = objResDocument.GetPagedDocumentByDocId(PageSize, PageNumber, OrderBy, DocID, AgendaSeq);
            }
            catch
            {
                throw;
            }
            return result;
        }


        /// <summary>
        /// Get workproduct information by workproductSeq.
        /// </summary>
        /// <param name="WorkproductSeq"></param>
        /// <returns></returns>
        /// <author>Deepak Kumar Singh</author>
        /// <creationDate>2007-12-01</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<DocumentEntity> GetWorkProductInfoByWorkProductSeq(System.Decimal WorkproductSeq)
        {
            //Process object data
            GenericExecutionResult<DocumentEntity> result = null;
            try
            {
                ResDocument objResDocument = new ResDocument();
                result = objResDocument.GetWorkProductInfoByWorkProductSeq(WorkproductSeq);
            }
            catch
            {
                throw;
            }
            return result;
        }

        /// <summary>
        /// Get Session items by Agenda Seq.
        /// </summary>
        /// <param name="AgendaSeq"></param>
        /// <returns></returns>
        /// <author>Deepak Kumar Singh</author>
        /// <creationDate>2007-12-01</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<DocumentEntity>> GetSessionItemsByAgendaSeq(System.Decimal AgendaSeq)
        {
            //Process object data
            GenericExecutionResult<List<DocumentEntity>> result = null;
            try
            {
                ResDocument objResDocument = new ResDocument();
                result = objResDocument.GetSessionItemsByAgendaSeq(AgendaSeq);
            }
            catch
            {
                throw;
            }
            return result;
        }

        /// <summary>
        /// Check out the document.
        /// </summary>
        /// <param name="DocumentID"></param>
        /// <param name="UserID"></param>
        /// <returns></returns>
        //public bool Checkout(ContentEntity contentEntity)
        //{
        //    //Entity level Validation
        //    bool bValidationRequired = false;
        //    if (bValidationRequired)
        //    {
        //        ValidationResults validationResults = Validation.ValidateFromConfiguration(contentEntity);
        //        if (!validationResults.IsValid)
        //        {
        //            StringBuilder strmessage = new StringBuilder();
        //            foreach (ValidationResult validationResult in validationResults)
        //            {
        //                System.String strValidationResultMessage = validationResult.Message;
        //                strmessage.AppendLine(String.Format("{0}", strValidationResultMessage));
        //            }
        //            throw new InvalidOperationException(strmessage.ToString());
        //        }
        //    }
        //    //Process object data
        //    try
        //    {
        //        ResContentEngine ObjResContentEngine = new ResContentEngine();
        //        bool ObjContentEntityRet = ObjResContentEngine.CheckOut(contentEntity);
        //        return ObjContentEntityRet;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        /// <summary>
        /// View the document.
        /// </summary>
        /// <param name="ObjContentEntity"></param>
        /// <returns></returns>
        public ContentEntity ViewDocument(ContentEntity contentEntity)
        {
            //Entity level Validation
            bool bValidationRequired = false;
            if (bValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(contentEntity);
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
            //Process object data
            try
            {
                ResContentEngine ObjResContentEngine = new ResContentEngine();
                ContentEntity ObjContentEntityRet = ObjResContentEngine.ViewDocument(contentEntity);
                return ObjContentEntityRet;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check In the document.
        /// </summary>
        /// <param name="DocumentId"></param>
        /// <param name="DocumentName"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        //public bool CheckIn(ContentEntity contentEntity)
        //{
        //    //Entity level Validation
        //    bool bValidationRequired = false;
        //    if (bValidationRequired)
        //    {
        //        ValidationResults validationResults = Validation.ValidateFromConfiguration(contentEntity);
        //        if (!validationResults.IsValid)
        //        {
        //            StringBuilder strmessage = new StringBuilder();
        //            foreach (ValidationResult validationResult in validationResults)
        //            {
        //                System.String strValidationResultMessage = validationResult.Message;
        //                strmessage.AppendLine(String.Format("{0}", strValidationResultMessage));
        //            }
        //            throw new InvalidOperationException(strmessage.ToString());
        //        }
        //    }
        //    //Process object data
        //    bool boolRetCheckIn = false;
        //    try
        //    {
        //        ResContentEngine ObjResContentEngine = new ResContentEngine();
        //        boolRetCheckIn = ObjResContentEngine.CheckIn(contentEntity);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return boolRetCheckIn;
        //}

        /// <summary>
        /// Check out the document.
        /// </summary>
        /// <param name="DocumentId"></param>
        /// <param name="UserID"></param>
        /// <returns></returns>
        //public bool CancelCheckOut(ContentEntity contentEntity)
        //{
        //    //Entity level Validation
        //    bool bValidationRequired = false;
        //    if (bValidationRequired)
        //    {
        //        ValidationResults validationResults = Validation.ValidateFromConfiguration(contentEntity);
        //        if (!validationResults.IsValid)
        //        {
        //            StringBuilder strmessage = new StringBuilder();
        //            foreach (ValidationResult validationResult in validationResults)
        //            {
        //                System.String strValidationResultMessage = validationResult.Message;
        //                strmessage.AppendLine(String.Format("{0}", strValidationResultMessage));
        //            }
        //            throw new InvalidOperationException(strmessage.ToString());
        //        }
        //    }
        //    //Process object data
        //    bool boolRetUndoCheckOut = false;
        //    try
        //    {
        //        ResContentEngine ObjResContentEngine = new ResContentEngine();
        //        boolRetUndoCheckOut = ObjResContentEngine.CancelCheckOut(contentEntity);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return boolRetUndoCheckOut;
        //}

        /// <summary>
        /// Update the status of checkout field into table CQM_WORKPRODUCT.
        /// </summary>
        /// <param name="RefNoDoc">Reference number of document.</param>
        /// <param name="Status">Check out status of document.</param>
        /// <param name="Action">Action which is taken by user i.e. "CheckIn","CheckOut" or "UndoCheckOut".</param>
        /// <param name="UpdatedBy">Name of the user who has taken action.</param>
        /// <author>Deepak Kumar Singh</author>
        /// <creationDate>2007-12-01</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public void UpdateCheckOutStatus(System.String RefNoDoc, System.String Status, System.String Action, System.String UpdatedBy)
        {
            //Process object data
            try
            {
                ResDocument objResDocument = new ResDocument();
                objResDocument.UpdateCheckOutStatus(RefNoDoc, Status, Action, UpdatedBy);
            }
            catch
            {
                throw;
            }
        }

        public GenericExecutionResult<List<DocumentEntity>> GetSessionItemDetail(System.Decimal SessionItemSeq)
        {
            //Process object data
            GenericExecutionResult<List<DocumentEntity>> result = null;
            try
            {
                ResDocument objResDocument = new ResDocument();
                result = objResDocument.GetSessionItemDetail(SessionItemSeq);
            }
            catch
            {
                throw;
            }
            return result;
        }

        
        public void GetBackupForSignedDocument(System.String DocName)
        {
            try
            {
                ResDocument objResDocument = new ResDocument();
                objResDocument.GetBackupForSignedDocument(DocName);
            }
            catch
            {
                throw;
            }
        }
    }
}

//---------------------------------------------------------------------
// Author: Deepshikha 
// Version: 1.0.0
// Date: 12/21/2011
// Description:Implement Pre 97 Matter Bussiness Class
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
    /// Implements Pre 97 Matter business class
    /// </summary>
    /// <author>Deepshikha</author>
    /// <creationDate>2011-12-21</creationDate>
    /// <modifications>
    /// <item>Date ;By ;Description</item>
    /// <item>Date ;By ;Description</item>
    /// </modifications>
    public class Pre97Matter
    {
        /// <summary>
        /// Search Pre97 Matter implements the business action - SearchPre97Matter. 
        /// </summary>
        /// <param name="searchMatterEntity">searchpre97MatterEntity object</param>
        /// <param name="PageNumber">The current page number</param>
        /// <param name="PageSize">The Page Size</param>
        /// <param name="SortOrder">The sorting expression</param>
        /// <returns>GenericExecutionResult object with return value-List of Matters as List of MatterResultEntity objects</returns>
        /// <author>Deepshikha</author>
        /// <creationDate>2011-12-21</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<Pre97MatterResultEntity>> SearchPre97Matter(Pre97SearchMatterEntity pre97SearchMatterEntity, System.Int32 PageSize, System.Int32 PageNumber, System.String SortOrder)
        {
            GenericExecutionResult<List<Pre97MatterResultEntity>> ObjGenEx = new GenericExecutionResult<List<Pre97MatterResultEntity>>();
            try
            {
                Pre97ResMatter ObjResMatter = new Pre97ResMatter();
                ObjGenEx = ObjResMatter.SearchPre97Matter(pre97SearchMatterEntity, PageSize, PageNumber, SortOrder);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// SearchDocument method is used to search Pre 1997 document from CE as well as from database Used for dispaly record.
        /// </summary>
        /// <param name="searchDocumentEntity"></param>
        /// <param name="SrchdDcmntPageSize"></param>
        /// <param name="SrchdDcmntPageNumber"></param>
        /// <param name="SrchdDcmntSortExp"></param>      
        /// <param name="ClickValue"></param>
        /// <returns></returns>
        public GenericExecutionResult<List<Pre97SearchDocumentResultEntity>> Pre97SearchDocumentDisplay(Pre97SearchDocumentEntity searchDocumentEntity, System.Int32 SrchdDcmntPageSize, System.Int32 SrchdDcmntPageNumber, System.String SrchdDcmntSortExp)
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
            GenericExecutionResult<List<Pre97SearchDocumentResultEntity>> ObjGenEx = new GenericExecutionResult<List<Pre97SearchDocumentResultEntity>>();
            try
            {
                Pre97ResMatter objResMatter = new Pre97ResMatter();
                ObjGenEx = objResMatter.Pre97SearchDocumentDisplay(searchDocumentEntity, SrchdDcmntPageSize, SrchdDcmntPageNumber, SrchdDcmntSortExp);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        /// <summary>
        /// SearchDocument method is used to disply Pre 1997 document from CE as well as from database Used for dispaly on the popup.
        /// </summary>
        /// <param name="searchDocumentEntity"></param>
        /// <param name="SrchdDcmntPageSize"></param>
        /// <param name="SrchdDcmntPageNumber"></param>
        /// <param name="SrchdDcmntSortExp"></param>      
        /// <param name="ClickValue"></param>
        /// <returns></returns>
       public GenericExecutionResult<List<Pre97SearchDocumentResultEntity>> Pre97PopUpDocumentDisplay(Pre97SearchDocumentEntity popUpDocumentEntity, System.Int32 SrchdDcmntPageSize, System.Int32 SrchdDcmntPageNumber, System.String SrchdDcmntSortExp)
        {
            GenericExecutionResult<List<Pre97SearchDocumentResultEntity>> ObjGenEx = new GenericExecutionResult<List<Pre97SearchDocumentResultEntity>>();
            try
            {
                Pre97ResMatter ObjResMatter = new Pre97ResMatter();
                ObjGenEx = ObjResMatter.Pre97PopUpDocumentDisplay(popUpDocumentEntity, SrchdDcmntPageSize, SrchdDcmntPageNumber, SrchdDcmntSortExp);
         
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        //public GenericExecutionResult<List<Pre97MatterResultEntity>> Pre97PopUpMatterDisplay(Pre97MatterResultEntity popUpMatterEntity, System.Int32 SrchdMatterPageSize, System.Int32 SrchdMatterCurrentPageNumber, System.String strSrchdMatterSortExp)
        public GenericExecutionResult<List<Pre97MatterResultEntity>> Pre97PopUpMatterDisplay(Pre97MatterResultEntity popUpMatterEntity)
        {
            GenericExecutionResult<List<Pre97MatterResultEntity>> ObjGenEx = new GenericExecutionResult<List<Pre97MatterResultEntity>>();
            try
            {
                Pre97ResMatter ObjResMatter = new Pre97ResMatter();
                //ObjGenEx = ObjResMatter.Pre97PopUpMatterDisplay(popUpMatterEntity, SrchdMatterPageSize, SrchdMatterCurrentPageNumber, strSrchdMatterSortExp);
                ObjGenEx = ObjResMatter.Pre97PopUpMatterDisplay(popUpMatterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

    }
}

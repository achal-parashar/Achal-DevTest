//---------------------------------------------------------------------
// Author: Ashish Mamodia
// Version: 1.0.0
// Date: 05/25/2011
// Description:Implement Disposition Type Master Bussiness Class
//
// History:
// Changed By                       Changed On

using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;

using CQM.Entities;
using CQM.Resource;
using CQM.Common.ExecutionResults;

namespace CQM.Business
{
    public class DispositionType
    {
        /// <summary>
        /// Delete DispositionType By DispositionSeq.
        /// </summary>
        /// <param name="DispositionSeq"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-25</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> DeleteDispositionType(System.Int32 DispositionSeq)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResDisposition ObjResDisposition = new ResDisposition();
                ObjGenEx = ObjResDisposition.DeleteDispositionType(DispositionSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Insert Disposition.
        /// </summary>
        /// <param name="dispositionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-25</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> InsertDispositionType(DispositionEntity dispositionEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(dispositionEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        String str = validationResult.Message;
                        message.AppendLine(String.Format("{0}", str));
                    }
                    throw new InvalidOperationException(message.ToString());
                }
            }
            try
            {
                //Process object data
                ResDisposition ObjResDisposition = new ResDisposition();
                ObjGenEx = ObjResDisposition.InsertDispositionType(dispositionEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Update Disposition .
        /// </summary>
        /// <param name="dispositionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-25</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> UpdateDispositionType(DispositionEntity dispositionEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(dispositionEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        String str = validationResult.Message;
                        message.AppendLine(String.Format("{0}", str));
                    }
                    throw new InvalidOperationException(message.ToString());
                }
            }
            try
            {
                //Process object data
                ResDisposition ObjResDisposition = new ResDisposition();
                ObjGenEx = ObjResDisposition.UpdateDispositionType(dispositionEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Get all Disposition with paging and sorting functionality .
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-25</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<DispositionEntity>> GetDispositionType(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            GenericExecutionResult<List<DispositionEntity>> ObjGenEx = new GenericExecutionResult<List<DispositionEntity>>(); ;
            try
            {
                //Process object data
                ResDisposition ObjResDisposition = new ResDisposition();
                ObjGenEx = ObjResDisposition.GetDispositionType(pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
    }
}





 
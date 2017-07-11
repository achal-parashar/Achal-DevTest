//---------------------------------------------------------------------
// Author: Yugal Kishore
// Version: 1.0.0
// Date: 05/13/2011
// Description:Implement Subsection Master Bussiness Class
//
// History:
// Changed By                       Changed On
//


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
    public class CADCountIssue
    {
        /// <summary>
        /// Delete Subsection By CaseSubsectionSeq.
        /// </summary>
        /// <param name="SubsectionSeq"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> DeleteCADCountIssue(System.Int32 CountIssueSeq)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResCADCountIssue ObjResSubsection = new ResCADCountIssue();
                ObjGenEx = ObjResSubsection.DeleteCADCountIssue(CountIssueSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Insert Subsection.
        /// </summary>
        /// <param name="SubsectionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> InsertCADCountIssue(CADCountIssueEntity cADCountIssueEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(cADCountIssueEntity);
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
                ResCADCountIssue ObjResSubsection = new ResCADCountIssue();
                ObjGenEx = ObjResSubsection.InsertCADCountIssue(cADCountIssueEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Update Subsection .
        /// </summary>
        /// <param name="SubsectionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> UpdateCADCountIssue(CADCountIssueEntity cADCountIssueEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(cADCountIssueEntity);
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
                ResCADCountIssue ObjResSubsection = new ResCADCountIssue();
                ObjGenEx = ObjResSubsection.UpdateCADCountIssue(cADCountIssueEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        
        /// <summary>
        /// Get all Subsection  with paging and sorting functionality .
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return List of SubsectionEntity</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public List<CADCountIssueEntity> GetCADCountIssue(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            List<CADCountIssueEntity> ObjSubsectionEntity = null;
            try
            {
                //Process object data
                ResCADCountIssue ObjResSubsection = new ResCADCountIssue();
                ObjSubsectionEntity = ObjResSubsection.GetCADCountIssue(pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjSubsectionEntity;
        }
    }
}

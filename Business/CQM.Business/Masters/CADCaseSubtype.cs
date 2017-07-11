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
    public class CADCaseSubtype
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

        public GenericExecutionResult<System.Int16> DeleteCADCaseSubtype(System.Int32 CaseSubtypeSeq)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResCADCaseSubtype ObjResSubsection = new ResCADCaseSubtype();
                ObjGenEx = ObjResSubsection.DeleteCADCaseSubtype(CaseSubtypeSeq);
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

        public GenericExecutionResult<System.Int16> InsertCADCaseSubtype(CADCaseSubtypeEntity cADCaseSubtypeEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(cADCaseSubtypeEntity);
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
                ResCADCaseSubtype ObjResSubsection = new ResCADCaseSubtype();
                ObjGenEx = ObjResSubsection.InsertCADCaseSubtype(cADCaseSubtypeEntity);
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

        public GenericExecutionResult<System.Int16> UpdateCADCaseSubtype(CADCaseSubtypeEntity cADCaseSubtypeEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(cADCaseSubtypeEntity);
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
                ResCADCaseSubtype ObjResSubsection = new ResCADCaseSubtype();
                ObjGenEx = ObjResSubsection.UpdateCADCaseSubtype(cADCaseSubtypeEntity);
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

        public List<CADCaseSubtypeEntity> GetCADCaseSubtype(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            List<CADCaseSubtypeEntity> ObjSubsectionEntity = null;
            try
            {
                //Process object data
                ResCADCaseSubtype ObjResSubsection = new ResCADCaseSubtype();
                ObjSubsectionEntity = ObjResSubsection.GetCADCaseSubtype(pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjSubsectionEntity;
        }
    }
}

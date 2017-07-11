//---------------------------------------------------------------------
// Author: Ashish Mamodia
// Version: 1.0.0
// Date: 05/23/2011
// Description:Implement Section Master Bussiness Class
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
    public class CADSection
    {
        /// <summary>
        /// Delete Section By CaseSectionSeq.
        /// </summary>
        /// <param name="CaseSectionSeq"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-23</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> DeleteCADSection(System.Int32 CaseSectionSeq)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResCADSection ObjResSection = new ResCADSection();
                ObjGenEx = ObjResSection.DeleteCADSection(CaseSectionSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Insert Section.
        /// </summary>
        /// <param name="CADSectionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-23</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> InsertCADSection(CADSectionEntity cadSectionEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(cadSectionEntity);
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
                ResCADSection ObjResSection = new ResCADSection();
                ObjGenEx = ObjResSection.InsertCADSection(cadSectionEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Update Section .
        /// </summary>
        /// <param name="CADSectionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-23</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> UpdateCADSection(CADSectionEntity cadSectionEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(cadSectionEntity);
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
                ResCADSection ObjResSection = new ResCADSection();
                ObjGenEx = ObjResSection.UpdateCADSection(cadSectionEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Get all Section  with paging and sorting functionality .
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-23</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<CADSectionEntity>> GetCADSection(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            GenericExecutionResult<List<CADSectionEntity>> ObjGenEx = new GenericExecutionResult<List<CADSectionEntity>>(); ;
            try
            {
                //Process object data
                ResCADSection ObjResSection = new ResCADSection();
                ObjGenEx = ObjResSection.GetCADSection(pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


        /// <summary>
        /// Get all Section  with paging and sorting functionality .
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-23</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<CADSectionEntity>> GetCADSectionList()
        {
            GenericExecutionResult<List<CADSectionEntity>> ObjGenEx = new GenericExecutionResult<List<CADSectionEntity>>(); ;
            try
            {
                //Process object data
                ResCADSection ObjResSection = new ResCADSection();
                ObjGenEx = ObjResSection.GetCADSectionList();
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
    }
}

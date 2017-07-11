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
    public class CADCaseType
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

        public GenericExecutionResult<System.Int16> DeleteCADCaseType(System.Int32 CADCaseTypeSeq)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResCADCaseType ObjResSubsection = new ResCADCaseType();
                ObjGenEx = ObjResSubsection.DeleteCADCaseType(CADCaseTypeSeq);
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

        public GenericExecutionResult<System.Int16> InsertCADCaseType(CADCaseTypeEntity cADCaseTypeEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(cADCaseTypeEntity);
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
                ResCADCaseType ObjResSubsection = new ResCADCaseType();
                ObjGenEx = ObjResSubsection.InsertCADCaseType(cADCaseTypeEntity);
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

        public GenericExecutionResult<System.Int16> UpdateCADCaseType(CADCaseTypeEntity cADCaseTypeEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(cADCaseTypeEntity);
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
                ResCADCaseType ObjResSubsection = new ResCADCaseType();
                ObjGenEx = ObjResSubsection.UpdateCADCaseType(cADCaseTypeEntity);
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

        public List<CADCaseTypeEntity> GetCADCaseType(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            List<CADCaseTypeEntity> ObjSubsectionEntity = null;
            try
            {
                //Process object data
                ResCADCaseType ObjResSubsection = new ResCADCaseType();
                ObjSubsectionEntity = ObjResSubsection.GetCADCaseType(pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjSubsectionEntity;
        }

        public List<CADCaseTypeEntity> GetCADCaseTypeList()
        {
            List<CADCaseTypeEntity> ObjCADCaseTypeEntity = null;
            try
            {
                ResCADCaseType ObjResCADCaseType = new ResCADCaseType();
                ObjCADCaseTypeEntity = ObjResCADCaseType.GetCADCaseTypeList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjCADCaseTypeEntity;
        }
        /// <summary>
        /// Get all Subsection  with paging and sorting functionality .
        /// </summary>
        /// <param name="CadCaseType"></param>
        /// <returns>Return List of CadCaseType</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public CADCaseTypeEntity GetCADCaseTypeByInit(System.String CadCaseType)
        {
            CADCaseTypeEntity ObjCADCaseTypeEntity = null;
            try
            {
                ResCADCaseType ObjResCADCaseType = new ResCADCaseType();
                ObjCADCaseTypeEntity = ObjResCADCaseType.GetCADCaseTypeByInit(CadCaseType);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjCADCaseTypeEntity;
        }

        /// <summary>
        /// Implementto get CAD Case Type for Intake Specialist Form.
        /// </summary>
        /// <returns>List of CADCaseTypeEntity</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-06-14</ceationDate>
        /// <modifications>
        /// <item></item>
        /// <item></item>
        /// </modifications>
        public List<CADCaseTypeEntity> GetCADCaseTypeListForIntakeForm()
        {
            List<CADCaseTypeEntity> ObjCADCaseTypeEntity = null;
            try
            {
                ResCADCaseType ObjResCADCaseType = new ResCADCaseType();
                ObjCADCaseTypeEntity = ObjResCADCaseType.GetCADCaseTypeListForIntakeForm();
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjCADCaseTypeEntity;
        }
    }
}

//---------------------------------------------------------------------
// Author: Yugal Kishore  
// Version: 1.0.0
// Date: 06/10/2011
// Description:  Implement Intake Specialist Form 
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
    /// This class provide functions related to Intake Specialist Form.
    /// </summary>
    /// <author>Yugal Kishore</author>
    /// <creationDate>2011-06-10</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class IntakeForm
    {        
        /// <summary>
        /// Submit web page
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>GenericExecutionResult</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-06-10</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>       
        public GenericExecutionResult<System.Int32> SubmitIntakeFormBusiness(IntakeFormEntity intakeFormEntity)
        {
            GenericExecutionResult<System.Int32> ObjGen = new GenericExecutionResult<System.Int32>();

            try
            {
                ResIntakeForm ObjIntakeForm = new ResIntakeForm();
                ObjGen = ObjIntakeForm.SubmitIntakeFormBusiness(intakeFormEntity);
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }

        public GenericExecutionResult<System.Int32> SubmitIntakeFormResidential(IntakeFormEntity intakeFormEntity)
        {
            GenericExecutionResult<System.Int32> ObjGen = new GenericExecutionResult<System.Int32>();

            try
            {
                ResIntakeForm ObjIntakeForm = new ResIntakeForm();
                ObjGen = ObjIntakeForm.SubmitIntakeFormResidential(intakeFormEntity);
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }
    }
}

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
  public class Variance
    {
        /// <summary>
        /// Submit Variance
        /// </summary>
        /// <returns>Submit Variance</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-05-20</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int32> SubmitVariance(VarianceEntity VarianceEntity, bool IsInternalUser)
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
                ResVariance ObjVariance = new ResVariance();
                ObjGenEx = ObjVariance.SubmitVariance(VarianceEntity, IsInternalUser);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
    }
}

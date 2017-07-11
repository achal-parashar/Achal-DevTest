
//---------------------------------------------------------------------
// Author: Jay Prakash  
// Version: 1.0.0
// Date: 05/31/2011
// Description:  Implement Case Bussiness Class
//
// History:
// Changed By                       
//Changed On
//
//---------------------------------------------------------------------using System;
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
    /// This class provide functions related to Case .
    /// </summary>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-05-31</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
   public class CadCommon
    {
        /// <summary>
        /// ValidRelatedCase
        /// </summary>
        /// <returns>Valid Case Detaile</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-05-31</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
       public GenericExecutionResult<CadInfoEntity> GetValidRelatedCase(System.String CaseNumber, System.String IsExternalFiling)
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
           GenericExecutionResult<CadInfoEntity> ObjGenEx = new GenericExecutionResult<CadInfoEntity>(); ;
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetValidRelatedCase(CaseNumber, IsExternalFiling);
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }

       /// <summary>
       /// ValidRelatedCase
       /// </summary>
       /// <returns>Get Case Detaile</returns>
       /// <author>Jay Prakash</author>
       /// <creationDate>2011-06-02</ceationDate>
       /// <modifications>
       /// <item>Date;By;Description</item>
       /// <item>Date;By;Description</item>
       /// </modifications>
       public GenericExecutionResult<CadInfoEntity> GetCaseInformation(System.Int32 Caseseq, System.String CaseTypeInitial)
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
           GenericExecutionResult<CadInfoEntity> ObjGenEx = new GenericExecutionResult<CadInfoEntity>(); ;
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetCaseInformation(Caseseq, CaseTypeInitial);
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }

       /// <summary>
       /// ValidRelatedCase
       /// </summary>
       /// <returns>Get Case Detaile</returns>
       /// <author>Jay Prakash</author>
       /// <creationDate>2011-06-02</ceationDate>
       /// <modifications>
       /// <Modified By>Shailendra Tripathi</Modified>
       /// <Date>2011-08-16</Date>
       /// <item>Date;By;Description</item>
       /// <item>Date;By;Description</item>
       /// </modifications>
       public GenericExecutionResult<CadInfoEntity> GetCaseAllInformation(System.String CadCaseNumber, System.String RecipientType, System.String UserID)
       {
           GenericExecutionResult<CadInfoEntity> ObjGenEx = new GenericExecutionResult<CadInfoEntity>(); ;
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetCaseAllInformation(CadCaseNumber, RecipientType, UserID);
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }

       /// <summary>
       /// ValidRelatedCase
       /// </summary>
       /// <returns>Get Case detail for external users</returns>
       /// <author>Anuj Singh</author>
       /// <creationDate>2013-11-25</ceationDate>
       /// <modifications>
       /// <item>Date;By;Description</item>
       /// <item>Date;By;Description</item>
       /// </modifications>
       /// 

       public GenericExecutionResult<CadInfoEntity> GetCaseAllWinterInformation(System.String CadCaseNumber, System.String RecipientType)
       {
           GenericExecutionResult<CadInfoEntity> ObjGenEx = new GenericExecutionResult<CadInfoEntity>(); ;
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetCaseAllWinterInformation(CadCaseNumber, RecipientType);
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }
      

       /// <summary>
       /// ValidRelatedCase
       /// </summary>
       /// <returns>Get Letter Type Detaile</returns>
       /// <author>Jay Prakash</author>
       /// <creationDate>2011-06-02</ceationDate>
       /// <modifications>
       /// <item>Date;By;Description</item>
       /// <item>Date;By;Description</item>
       /// </modifications>
       public GenericExecutionResult<List<LetterEntity>> GetCADLetterType()
       {
           GenericExecutionResult<List<LetterEntity>> ObjGenEx = new GenericExecutionResult<List<LetterEntity>>(); ;
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetCADLetterType();
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }
       /// <summary>
       /// ValidRelatedCase
       /// </summary>
       /// <returns>Get Letter Type Title</returns>
       /// <author>Jay Prakash</author>
       /// <creationDate>2011-06-02</ceationDate>
       /// <modifications>
       /// <item>Date;By;Description</item>
       /// <item>Date;By;Description</item>
       /// </modifications>
       public GenericExecutionResult<List<LetterEntity>> GetCADLetterTitleList(System.Int32 Letter_Type_Seq)
       {
           GenericExecutionResult<List<LetterEntity>> ObjGenEx = new GenericExecutionResult<List<LetterEntity>>(); ;
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetCADLetterTitleList(Letter_Type_Seq);
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }
      

       //Added By: Ashish
       public List<IDNameEntity> GetCADUserList()
       {
           List<IDNameEntity> ObjGenEx = new List<IDNameEntity>();
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetCADUserList();
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }

       /// <summary>
       /// Get Assignable CADUser for Cad Case Winter Request Submission.
       /// </summary>
       /// <returns>Assignable User.</returns>
       /// <author>Ashish</author>
       /// <creationDate>2013-06-24</ceationDate>
       /// <modifications>
       /// <item>Date;By;Description</item>
       /// <item>Date;By;Description</item>
       /// </modifications>
       public GenericExecutionResult<System.String> GetCadAssinableUserForWRD()
       {
           GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>(); ;
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetCadAssinableUserForWRD();
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }

       /// <summary>
       /// Get Assignable CADUser for Cad Case Variance Request Submission.
       /// </summary>
       /// <returns>Assignable User.</returns>
       /// <author>Ashish</author>
       /// <creationDate>2013-06-24</ceationDate>
       /// <modifications>
       /// <item>Date;By;Description</item>
       /// <item>Date;By;Description</item>
       /// </modifications>
       public GenericExecutionResult<System.String> GetCadAssinableUserForVAR()
       {
           GenericExecutionResult<System.String> ObjGenEx = new GenericExecutionResult<System.String>(); ;
           try
           {
               ResCadCommon Objcommon = new ResCadCommon();
               ObjGenEx = Objcommon.GetCadAssinableUserForVAR();
           }
           catch
           {
               throw;
           }
           return ObjGenEx;
       }
    }
}
 
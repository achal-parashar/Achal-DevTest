//---------------------------------------------------------------------
// Author: Ashish Mamodia
// Version: 1.0.0
// Date: 05/17/2011
// Description:  Implement Issue Question Master Bussiness Class
//
// History:
// Changed By                       Changed On
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
    public class IssueQuestion
    {
        /// <summary>
        /// Get all Issue Question
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return List of IssueQuestionEntity</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-17</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<IssueQuestionEntity>> GetIssueQuestion(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            GenericExecutionResult<List<IssueQuestionEntity>> ObjGenEx = new GenericExecutionResult<List<IssueQuestionEntity>>();
            try
            {
                //Process object data
                ResIssueQuestion ObjResIssueQuestion = new ResIssueQuestion();
                ObjGenEx = ObjResIssueQuestion.GetIssueQuestion(pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Update Issue Question .
        /// </summary>
        /// <param name="industrySubtypeEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-18</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> UpdateIssueQuestion(IssueQuestionEntity issueQuestionEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(issueQuestionEntity);
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
                ResIssueQuestion ObjResIssueQuestion = new ResIssueQuestion();
                ObjGenEx = ObjResIssueQuestion.UpdateIssueQuestion(issueQuestionEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Delete Issue Question.
        /// </summary>
        /// <param name="IssueQuestionSeq"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-18</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> DeleteIssueQuestion(System.Int32 IssueQuestionSeq)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResIssueQuestion ObjResIssueQuestion = new ResIssueQuestion();
                ObjGenEx = ObjResIssueQuestion.DeleteIssueQuestion(IssueQuestionSeq);               
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Insert Issue Question.
        /// </summary>
        /// <param name="issueQuestionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-18</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> InsertIssueQuestion(IssueQuestionEntity issueQuestionEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(issueQuestionEntity);
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
                ResIssueQuestion ObjResIssueQuestion = new ResIssueQuestion();
                ObjGenEx = ObjResIssueQuestion.InsertIssueQuestion(issueQuestionEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<IDNameEntity>> GetIssueQuestionList()
        {
            GenericExecutionResult<List<IDNameEntity>> ObjGenEx = new GenericExecutionResult<List<IDNameEntity>>();
            try
            {
                ResIssueQuestion ObjResIssueQuestion = new ResIssueQuestion();
                ObjGenEx = ObjResIssueQuestion.GetIssueQuestionList();
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
    }
}

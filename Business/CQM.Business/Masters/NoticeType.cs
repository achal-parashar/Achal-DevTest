//---------------------------------------------------------------------
// Author: Ashish Mamodia
// Version: 1.0.0
// Date: 05/24/2011
// Description:  Implement Industry Subtype Master Bussiness Class
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
    public class NoticeType
    {
         /// <summary>
        /// Get all Notice Type
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return List of NoticeTypeEntity</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-24</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<NoticeTypeEntity>> GetNoticeType(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            GenericExecutionResult<List<NoticeTypeEntity>> ObjGenEx = new GenericExecutionResult<List<NoticeTypeEntity>>();
            try
            {
                //Process object data
                ResNoticeType ObjResNoticeTypeMaster = new ResNoticeType();
                ObjGenEx = ObjResNoticeTypeMaster.GetNoticeType(pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        /// <summary>
        /// Update Notice Type .
        /// </summary>
        /// <param name="noticeTypeEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-24</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        //public GenericExecutionResult<System.Int16> UpdateNoticeType(NoticeTypeEntity noticeTypeEntity)
        //{
        //    GenericExecutionResult<System.Int16> ObjGenEx = null;
        //    //Entity level Validation
        //    bool ValidationRequired = false;
        //    if (ValidationRequired)
        //    {
        //        ValidationResults validationResults = Validation.ValidateFromConfiguration(noticeTypeEntity);
        //        if (!validationResults.IsValid)
        //        {
        //            StringBuilder message = new StringBuilder();
        //            foreach (ValidationResult validationResult in validationResults)
        //            {
        //                String str = validationResult.Message;
        //                message.AppendLine(String.Format("{0}", str));
        //            }
        //            throw new InvalidOperationException(message.ToString());
        //        }
        //    }
        //    try
        //    {
        //        //Process object data
        //        ResNoticeType ObjResNoticeTypeMaster = new ResNoticeType();
        //        ObjGenEx = ObjResNoticeTypeMaster.UpdateNoticeType(noticeTypeEntity);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return ObjGenEx;
        //}

        /// <summary>
        /// Delete Notice Type.
        /// </summary>
        /// <param name="NoticeSeq"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-24</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        //public GenericExecutionResult<System.Int16> DeleteNoticeType(System.Int32 NoticeSeq)
        //{
        //    GenericExecutionResult<System.Int16> ObjGenEx = null;
        //    try
        //    {
        //        //Process object data
        //        ResNoticeType ObjResNoticeTypeMaster = new ResNoticeType();
        //        ObjGenEx = ObjResNoticeTypeMaster.DeleteNoticeType(NoticeSeq);              
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return ObjGenEx;
        //}

        /// <summary>
        /// Insert Notice Type.
        /// </summary>
        /// <param name="noticeTypeEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-24</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        //public GenericExecutionResult<System.Int16> InsertNoticeType(NoticeTypeEntity noticeTypeEntity)
        //{
        //    GenericExecutionResult<System.Int16> ObjGenEx = null;
        //    //Entity level Validation
        //    bool ValidationRequired = false;
        //    if (ValidationRequired)
        //    {
        //        ValidationResults validationResults = Validation.ValidateFromConfiguration(noticeTypeEntity);
        //        if (!validationResults.IsValid)
        //        {
        //            StringBuilder message = new StringBuilder();
        //            foreach (ValidationResult validationResult in validationResults)
        //            {
        //                String str = validationResult.Message;
        //                message.AppendLine(String.Format("{0}", str));
        //            }
        //            throw new InvalidOperationException(message.ToString());
        //        }
        //    }
        //    try
        //    {
        //        //Process object data
        //        ResNoticeType ObjResNoticeTypeMaster = new ResNoticeType();
        //        ObjGenEx = ObjResNoticeTypeMaster.InsertNoticeType(noticeTypeEntity);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return ObjGenEx;
        //}

    }
}

//---------------------------------------------------------------------
// Author: Yugal Kishore
// Version: 1.0.0
// Date: 05/13/2011
// Description:Implement Chapter Master Bussiness Class
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
    public class Chapter
    {
        /// <summary>
        /// Delete Chapter By CaseChapterSeq.
        /// </summary>
        /// <param name="ChapterSeq"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> DeleteChapter(System.Int32 CaseChapterSeq)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResChapter ObjResChapter = new ResChapter();
                ObjGenEx = ObjResChapter.DeleteChapter(CaseChapterSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Insert Chapter.
        /// </summary>
        /// <param name="ChapterEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> InsertChapter(ChapterEntity chapterEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(chapterEntity);
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
                ResChapter ObjResChapter = new ResChapter();
                ObjGenEx = ObjResChapter.InsertChapter(chapterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Update Chapter .
        /// </summary>
        /// <param name="ChapterEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> UpdateChapter(ChapterEntity chapterEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(chapterEntity);
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
                ResChapter ObjResChapter = new ResChapter();
                ObjGenEx = ObjResChapter.UpdateChapter(chapterEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        
        /// <summary>
        /// Get all Chapter  with paging and sorting functionality .
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return List of ChapterEntity</returns>
        /// <author>Yugal Kishore</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public List<ChapterEntity> GetChapter(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            List<ChapterEntity> ObjChapterEntity = null;
            try
            {
                //Process object data
                ResChapter ObjResChapter = new ResChapter();
                ObjChapterEntity = ObjResChapter.GetChapter(pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjChapterEntity;
        }

        /// <summary>
        /// Get all Chapter  with paging and sorting functionality .
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <returns>Return List of ChapterEntity</returns>
        /// <author>Jay Prakash</author>
        /// <creationDate>2011-05-13</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<List<ChapterEntity>> GetCADChapterList()
        {
            GenericExecutionResult<List< ChapterEntity >> ObjChapterEntity = null;
            try
            {
                //Process object data
                ResChapter ObjResChapter = new ResChapter();
                ObjChapterEntity = ObjResChapter.GetCADChapterList();
            }
            catch
            {
                throw;
            }
            return ObjChapterEntity;
        }
    }
}

//---------------------------------------------------------------------
// Author: Jay Prakash
// Version: 1.0.0
// Date: 07/22/2011
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
    /// <summary>
    /// Delete Chapter By CaseChapterSeq.
    /// </summary>
    /// <param name="ChapterSeq"></param>
    /// <returns>Return object of GenericExecutionResult</returns>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-07-22</ceationDate>
    /// <modifications>
    /// <item>Date;By;Description</item>
    /// <item>Date;By;Description</item>
    /// </modifications>
   public class ChptrSecSubSection
    {
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

       public GenericExecutionResult<List<ChptrSecSubSecEntity>> GetCADCptrSecSubSecList(System.String Code)
        {
            GenericExecutionResult<List<ChptrSecSubSecEntity>> ObjChapterEntity = null;
            try
            {
                //Process object data
                ResChptrSecSubSection ObjResChapter = new ResChptrSecSubSection();
                ObjChapterEntity = ObjResChapter.GetCADCptrSecSubSecList(Code);
            }
            catch
            {
                throw;
            }
            return ObjChapterEntity;
        }
    }
}

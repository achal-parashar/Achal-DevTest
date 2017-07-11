//---------------------------------------------------------------------
// Author: Jay Prakash
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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="SubsectionSeq"></param>
    /// <returns>Return object of GenericExecutionResult</returns>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-05-13</ceationDate>
    /// <modifications>
    /// <item>Date;By;Description</item>
    /// <item>Date;By;Description</item>
    /// </modifications>
  public  class UserType
    {
        /// <summary>
        /// Implement Get UserSeq.
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns>integer</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-08</ceationDate>
        /// <modifications>       
        /// </modifications>
        public System.Int32 GetUserSeq(System.String UserID)
        {
            Int32 UserSeq = 0;
            try
            {
                ResUser ObjResuser = new ResUser();
                //@@@@  For Comment - aaded parameter IsFinalReviewer
                UserSeq = ObjResuser.GetUserSeq(UserID);
            }
            catch
            {
                throw;
            }
            return UserSeq;
        }
    }
}

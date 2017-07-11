//---------------------------------------------------------------------
// Author: Yugal Kishore
// Version: 1.0.0
// Date: 05/13/2011
// Description: Arrangement Type Master Entity
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about chapter.
    /// </summary>
    /// <author>Yugal Kishore</author>
    /// <creationDate>2011-05-13</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 

    public class CADCountIssueEntity
    {
        private System.Decimal countIssueSeq;
        public System.Decimal CountIssueSeq
        {
            get { return countIssueSeq; }
            set { countIssueSeq = value; }
        }

        private System.String countIssueDesc;
        public System.String CountIssueDesc
        {
            get { return countIssueDesc; }
            set { countIssueDesc = value; }
        }

        private System.String countIssueCode;
        public System.String CountIssueCode
        {
            get { return countIssueCode; }
            set { countIssueCode = value; }
        }

       
        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private System.DateTime createdDate;
        public System.DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private System.DateTime updatedDate;
        public System.DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

    }
}

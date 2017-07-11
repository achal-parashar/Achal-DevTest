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

    public class CADCaseTypeEntity
    {
        private System.Decimal caseTypeSeq;
        public System.Decimal CaseTypeSeq
        {
            get { return caseTypeSeq; }
            set { caseTypeSeq = value; }
        }

        private System.String caseTypeCode;
        public System.String CaseTypeCode
        {
            get { return caseTypeCode; }
            set { caseTypeCode = value; }
        }


        private System.String caseTypeInit;
        public System.String CaseTypeInit
        {
            get { return caseTypeInit; }
            set { caseTypeInit = value; }
        }

        private System.String caseTypeDesc;
        public System.String CaseTypeDesc
        {
            get { return caseTypeDesc; }
            set { caseTypeDesc = value; }
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

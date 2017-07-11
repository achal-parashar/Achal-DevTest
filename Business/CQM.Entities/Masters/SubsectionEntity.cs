//---------------------------------------------------------------------
// Author: Yugal Kishore
// Version: 1.0.0
// Date: 05/13/2011
// Description: Subsection Master Entity
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
    /// This entity class stores the information about Subsection.
    /// </summary>
    /// <author>Yugal Kishore</author>
    /// <creationDate>2011-05-13</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>

    public class SubsectionEntity
    {
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
       
        private System.String caseSubsectionCode;
        public System.String CaseSubsectionCode
        {
            get { return caseSubsectionCode; }
            set { caseSubsectionCode = value; }
        }

        private System.Decimal caseSubsectionSeq;
        public System.Decimal CaseSubsectionSeq
        {
            get { return caseSubsectionSeq; }
            set { caseSubsectionSeq = value; }
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

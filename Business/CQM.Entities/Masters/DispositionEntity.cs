//---------------------------------------------------------------------
// Author: Ashish Mamodia
// Version: 1.0.0
// Date: 05/25/2011
// Description: Disposition Master Entity
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
    /// This entity class stores the information about disposition.
    /// </summary>
    /// <author>Ashish Mamodia</author>
    /// <creationDate>2011-05-25</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 

    public class DispositionEntity
    {
        private System.Decimal dispositionTypeSeq;
        public System.Decimal DispositionTypeSeq
        {
            get { return dispositionTypeSeq; }
            set { dispositionTypeSeq = value; }
        }

        private System.String dispositionTypeDesc;
        public System.String DispositionTypeDesc
        {
            get { return dispositionTypeDesc; }
            set { dispositionTypeDesc = value; }
        }

        private System.String dispositionTypeCode;
        public System.String DispositionTypeCode
        {
            get { return dispositionTypeCode; }
            set { dispositionTypeCode = value; }
        }
        
        private System.Decimal caseTypeSeq;
        public System.Decimal CaseTypeSeq
        {
            get { return caseTypeSeq; }
            set { caseTypeSeq = value; }
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
//---------------------------------------------------------------------
// Author: Jay Prakash
// Version: 1.0.0
// Date: 07/22/2011
// Description: Chapter/Section/SubSection Master Entity
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
    public class ChptrSecSubSecEntity
    {
        private System.String sNo;
        public System.String SNo
        {
            get { return sNo; }
            set { sNo = value; }
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

        private System.String chaptr_sctn_subs_Code;
        public System.String ChptrSecSubSecCode
        {
            get { return chaptr_sctn_subs_Code; }
            set { chaptr_sctn_subs_Code = value; }
        }

        private System.String codevalue;
        public System.String CodeValue
        {
            get { return codevalue; }
            set { codevalue = value; }
        }
        private System.String chaptrsode;
        public System.String ChaptrCode
        {
            get { return chaptrsode; }
            set { chaptrsode = value; }
        }

        private System.String sctnCode;
        public System.String SctnCode
        {
            get { return sctnCode; }
            set { sctnCode = value; }
        }
        private System.String subs_Code;
        public System.String SubSecCode
        {
            get { return subs_Code; }
            set { subs_Code = value; }
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

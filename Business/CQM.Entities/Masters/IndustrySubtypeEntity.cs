//---------------------------------------------------------------------
// Author: Ashish Mamodia
// Version: 1.0.0
// Date: 05/11/2011
// Description: Industry Subtype Master Entity
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    public class IndustrySubtypeEntity
    {
        /// <summary>
        /// This entity class stores the information about Industry Subtype.
        /// </summary>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-11</ceationDate>
        /// <modifications>
        /// <item></item>
        /// <item></item>
        /// </modifications>
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

        private System.Int32 industrySeq;
        public System.Int32 IndustrySeq
        {
            get { return industrySeq; }
            set { industrySeq = value; }
        }

        private System.String industrySubtype;
        public System.String IndustrySubtype
        {
            get { return industrySubtype; }
            set { industrySubtype = value; }
        }

        private System.Decimal industrySubtypeSeq;
        public System.Decimal IndustrySubtypeSeq
        {
            get { return industrySubtypeSeq; }
            set { industrySubtypeSeq = value; }
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
        private string industryType;
        public string IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        private System.String industrySubTypeCode;
        public System.String IndustrySubTypeCode
        {
            get { return industrySubTypeCode; }
            set { industrySubTypeCode = value; }
        }

        private System.String industrySubtypeCode;
        public System.String IndustrySubtypeCode
        {
            get { return industrySubtypeCode; }
            set { industrySubtypeCode = value; }
        }
        
    }
}


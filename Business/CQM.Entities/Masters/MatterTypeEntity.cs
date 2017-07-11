//---------------------------------------------------------------------
// Author: Ajeet Kumar
// Version: 1.0.0
// Date: 10/22/2007
// Description: Matter Type Master Entity
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
    /// This entity class stores the information about MatterType.
    /// </summary>
    /// <author>Ajeet Kumar</author>
    /// <creationDate>2007-10-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
	public class MatterTypeEntity
	{
		private System.String createdBy;
		public System.String CreatedBy
		{
			get{ return createdBy; }
			set{ createdBy = value; }
		}

		private System.DateTime createdDate;
		public System.DateTime CreatedDate
		{
			get{ return createdDate; }
			set{ createdDate = value; }
		}

		private System.String isDeleted;
		public System.String IsDeleted
		{
			get{ return isDeleted; }
			set{ isDeleted = value; }
		}

		private System.String matterType;
		public System.String MatterType
		{
			get{ return matterType; }
			set{ matterType = value; }
		}

		private System.Decimal matterTypeSeq;
		public System.Decimal MatterTypeSeq
		{
			get{ return matterTypeSeq; }
			set{ matterTypeSeq = value; }
		}

		private System.String updatedBy;
		public System.String UpdatedBy
		{
			get{ return updatedBy; }
			set{ updatedBy = value; }
		}

		private System.DateTime updatedDate;
		public System.DateTime UpdatedDate
		{
			get{ return updatedDate; }
			set{ updatedDate = value; }
		}
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String industryTypeCode;
        public System.String IndustryTypeCode
        {
            get { return industryTypeCode; }
            set { industryTypeCode = value; }
        }

        private System.String industryType;
        public System.String IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        private System.String matterTypeCode;
        public System.String MatterTypeCode
        {
            get { return matterTypeCode; }
            set { matterTypeCode = value; }
        }
        private System.String caseTypeDesc;
        public System.String CaseTypeDesc
        {
            get { return caseTypeDesc; }
            set { caseTypeDesc = value; }
        }
        private System.String caseTypeCode;
        public System.String CaseTypeCode
        {
            get { return caseTypeCode; }
            set { caseTypeCode = value; }
        }
	}

}


 

//---------------------------------------------------------------------
// Author: Ajeet Kumar
// Version: 1.0.0
// Date: 10/22/2007
// Description: Section Master Entity
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
    /// This entity class stores the information about Section.
    /// </summary>
    /// <author>Ajeet Kumar</author>
    /// <creationDate>2007-10-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
	public class SectionEntity
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

		private System.String isActive;
		public System.String IsActive
		{
			get{ return isActive; }
			set{ isActive = value; }
		}
        private System.String checkedTrue;
        public System.String CheckedTrue
        {
            get { return checkedTrue; }
            set { checkedTrue = value; }
        }
        private System.String checkedfalse;
        public System.String Checkedfalse
        {
            get { return checkedfalse; }
            set { checkedfalse = value; }
        }

		private System.String isDeleted;
		public System.String IsDeleted
		{
			get{ return isDeleted; }
			set{ isDeleted = value; }
		}

		private System.Decimal officeSeq;
		public System.Decimal OfficeSeq
		{
			get{ return officeSeq; }
			set{ officeSeq = value; }
		}
        private System.String officeName;
        public System.String OfficeName
        {
            get { return officeName; }
            set { officeName = value; }
        }

		private System.String sectionName;
		public System.String SectionName
		{
			get{ return sectionName; }
			set{ sectionName = value; }
		}
        private System.String sectionShortName;
        public System.String SectionShortName
        {
            get { return sectionShortName; }
            set { sectionShortName = value; }
        }

		private System.Decimal sectionSeq;
		public System.Decimal SectionSeq
		{
			get{ return sectionSeq; }
			set{ sectionSeq = value; }
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


	}

}

        

	


      



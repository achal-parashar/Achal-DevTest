//---------------------------------------------------------------------
// Author: Ajeet Kumar
// Version: 1.0.0
// Date: 10/22/2007
// Description: Document Type Master Entity
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
    /// This entity class stores the information about DocumentType.
    /// </summary>
    /// <author>Ajeet Kumar</author>
    /// <creationDate>2007-10-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
	public class DocumentTypeEntity
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

		private System.String documentType;
		public System.String DocumentType
		{
			get{ return documentType; }
			set{ documentType = value; }
		}

		private System.Decimal documentTypeSeq;
		public System.Decimal DocumentTypeSeq
		{
			get{ return documentTypeSeq; }
			set{ documentTypeSeq = value; }
		}

		private System.String isDeleted;
		public System.String IsDeleted
		{
			get{ return isDeleted; }
			set{ isDeleted = value; }
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
        private System.String documentTypeCode;
        public System.String DocumentTypeCode
        {
            get { return documentTypeCode; }
            set { documentTypeCode = value; }
        }

	}

}

      

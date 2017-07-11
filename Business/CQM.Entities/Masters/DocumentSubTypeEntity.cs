//---------------------------------------------------------------------
// Author: Suruchi Saxena
// Version: 1.0.0
// Date: 06/20/2011
// Description: Document SubType Master Entity
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
    /// This entity class stores the information about Document Sub Type.
    /// </summary>
    /// <author>Suruchi Saxena</author>
    /// <creationDate>06/20/2011</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class DocumentSubTypeEntity
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

        private System.String documentSubType;
        public System.String DocumentSubType
        {
            get { return documentSubType; }
            set { documentSubType = value; }
        }

        private System.Decimal documentSubTypeSeq;
        public System.Decimal DocumentSubTypeSeq
        {
            get { return documentSubTypeSeq; }
            set { documentSubTypeSeq = value; }
        }

        private System.Decimal documentTypeSeq;
        public System.Decimal DocumentTypeSeq
        {
            get { return documentTypeSeq; }
            set { documentTypeSeq = value; }
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
        private System.String documentSubTypeCode;
        public System.String DocumentSubTypeCode
        {
            get { return documentSubTypeCode; }
            set { documentSubTypeCode = value; }
        }
        private System.String documentTypeCode;
        public System.String DocumentTypeCode
        {
            get { return documentTypeCode; }
            set { documentTypeCode = value; }
        }

        private System.String documentType;
        public System.String DocumentType
        {
            get { return documentType; }
            set { documentType = value; }
        }

    }

}
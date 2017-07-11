//---------------------------------------------------------------------
// Author: Rajani Gandha Patra
// Version: 1.0.0
// Date: 08/05/2011
// Description:TariffBookAttachmentEntity Class
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about "Tariff Attachemnt property of any Entity specified.
    /// </summary>
    /// <author>Rajani Patra</author>
    /// <creationDate>2011-08-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class TariffBookAttachmentEntity
    {
        private System.String trfBookNumber;
        public System.String TrfBookNumber
        {
            get { return trfBookNumber; }
            set { trfBookNumber = value; }
        }       
        private System.String documentExtn;
        public System.String DocumentExtn
        {
            get { return documentExtn; }
            set { documentExtn = value; }
        }
        private System.String documentSize;
        public System.String DocumentSize
        {
            get { return documentSize; }
            set { documentSize = value; }
        }
        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        private System.String attachmentName;
        public System.String AttachmentName
        {
            get { return attachmentName; }
            set { attachmentName = value; }
        }
        private System.String attachmentStatus;
        public System.String AttachmentStatus
        {
            get { return attachmentStatus; }
            set { attachmentStatus = value; }
        }
        private System.String mimeTypeSeq;
        public System.String MimeTypeSeq
        {
            get { return mimeTypeSeq; }
            set { mimeTypeSeq = value; }
        }
        private System.String documentRefNo;
        public System.String DocumentRefNo
        {
            get { return documentRefNo; }
            set { documentRefNo = value; }
        }
        private System.Boolean isWronglyClassified;
        public System.Boolean IsWronglyClassified
        {
            get { return isWronglyClassified; }
            set { isWronglyClassified = value; }
        }
        private System.String refDocGuidName;
        public System.String RefDocGuidName
        {
            get { return refDocGuidName; }
            set { refDocGuidName = value; }
        }
        private System.Decimal docId;
        public System.Decimal DocId
        {
            get { return docId; }
            set { docId = value; }
        }

        private IDNameEntity doctype = new IDNameEntity();
        public IDNameEntity DocType
        {
            get { return doctype; }
            set { doctype = value; }
        }

        private IDNameEntity docSubType = new IDNameEntity();
        public IDNameEntity DocSubType
        {
            get { return docSubType; }
            set { docSubType = value; }
        }
        private System.Decimal totalRecords;
        public System.Decimal TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String sNo;
        public System.String SNo
        {
            get { return sNo; }
            set { sNo = value; }
        }
        private System.String guidno;
        public System.String GUIDno
        {
            get { return guidno; }
            set { guidno = value; }
        }
        private IndexValuesEntity indexValues = new IndexValuesEntity();
        public IndexValuesEntity IndexValues
        {
            get { return indexValues; }
            set { indexValues = value; }
        }

        //Vivek-29-Dec-2011
        private System.Int32 pageSize;
        public System.Int32 PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
        private System.Int32 pageNumber;
        public System.Int32 PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }
        private System.String sortBy;
        public System.String SortBy
        {
            get { return sortBy; }
            set { sortBy = value; }
        }

        private System.String _attachmentType;
        public System.String AttachmentType
        {
            get { return _attachmentType; }
            set { _attachmentType = value; }
        }
        //End
    }
}

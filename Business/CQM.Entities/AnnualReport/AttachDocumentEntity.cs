//---------------------------------------------------------------------
// Author: Amarendra
// Version: 1.0.0
// Date: 11/01/2011
// Description:Implement Annual Report Attached Document Properties
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Annual Report Attached Document.
    /// </summary>
    /// <author>Amarendra</author>
    /// <creationDate>2011-11-01</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class AttachDocumentEntity
    {
        private string isConfidential;
        public string IsConfidential
        {
            get { return isConfidential; }
            set { isConfidential = value; }
        }
        private string reportYear;
        public string ReportYear
        {
            get { return reportYear; }
            set { reportYear = value; }
        }

        private int companySeq;
        public int CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }

        private string reportTypeCode;
        public string ReportTypeCode
        {
            get { return reportTypeCode; }
            set { reportTypeCode = value; }
        }
        private System.String documentName;
        public System.String DocumentName
        {
            get { return documentName; }
            set { documentName = value; }
        }

        private System.String documentTitle;
        public System.String DocumentTitle
        {
            get { return documentTitle; }
            set { documentTitle = value; }
        }

        private System.Decimal docId;
        public System.Decimal DocId
        {
            get { return docId; }
            set { docId = value; }
        }

        private System.String sizetoDisplay;
        public System.String SizetoDisplay
        {
            get { return sizetoDisplay; }
            set { sizetoDisplay = value; }
        }
        private IDNameEntity doctype = new IDNameEntity();
        public IDNameEntity DocType
        {
            get { return doctype; }
            set { doctype = value; }
        }

        private System.String documentExtn;
        public System.String DocumentExtn
        {
            get { return documentExtn; }
            set { documentExtn = value; }
        }

        private System.String documentRefNo;
        public System.String DocumentRefNo
        {
            get { return documentRefNo; }
            set { documentRefNo = value; }
        }

        private System.Decimal documentSize;
        public System.Decimal DocumentSize
        {
            get { return documentSize; }
            set { documentSize = value; }
        }

        private int documentSeq;
        public int DocumentSeq
        {
            get { return documentSeq; }
            set { documentSeq = value; }
        }

        private int proDocumentSeq;
        public int ProDocumentSeq
        {
            get { return proDocumentSeq; }
            set { proDocumentSeq = value; }
        }

        private string proDocumentSeqList;
        public string ProDocumentSeqList
            {
            get { return proDocumentSeqList; }
            set { proDocumentSeqList = value; }
            }
        private System.String proDocumentTitle;
        public System.String ProDocumentTitle
        {
            get { return proDocumentTitle; }
            set { proDocumentTitle = value; }
        }

        private System.String proDocumentRefNo;
        public System.String ProDocumentRefNo
        {
            get { return proDocumentRefNo; }
            set { proDocumentRefNo = value; }
        }

        private System.String proDocumentName;
        public System.String ProDocumentName
        {
            get { return proDocumentName; }
            set { proDocumentName = value; }
        }
        private System.String mimeTypeImagePath;
        public System.String MimeTypeImagePath
        {
            get { return mimeTypeImagePath; }
            set { mimeTypeImagePath = value; }
        }

        private System.String securityImageDisplay;
        public System.String SecurityImageDisplay
        {
            get { return securityImageDisplay; }
            set { securityImageDisplay = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String documentGuidName;
        public System.String DocumentGuidName
        {
            get { return documentGuidName; }
            set { documentGuidName = value; }
        }

        private string trackingNumber;
        public string TrackingNumber
            {
            get { return trackingNumber; }
            set { trackingNumber = value; }
            }

        private System.String sNo;
        public System.String SNo
        {
            get { return sNo; }
            set { sNo = value; }
        }
        private IndexValuesEntity indexValues = new IndexValuesEntity();
        public IndexValuesEntity IndexValues
        {
            get { return indexValues; }
            set { indexValues = value; }
        }

        public bool IsVisible { get; set; }
    }
}

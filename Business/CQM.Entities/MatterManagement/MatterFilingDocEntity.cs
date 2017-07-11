//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/22/2007
// Description: Matter Filing Document Entity
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
    /// This entity class stores the information about Matter Filing Documents Entity
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-11-22</ceationDate>
    /// <modifications>
    /// <item>2008-02-02;Ritika Fakay;Added comments</item>
    /// <item></item>
    /// </modifications>

    public class MatterFilingDocEntity
    {
        private System.String securityFlag;
        public System.String SecurityFlag
        {
            get { return securityFlag; }
            set { securityFlag = value; }
        }

        private System.String docGuidName;
        public System.String DocGuidName
        {
            get { return docGuidName; }
            set { docGuidName = value; }
        }

        private System.String docTitle;
        public System.String DocTitle
        {
            get { return docTitle; }
            set { docTitle = value; }
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

        private System.String docExtn;
        public System.String DocExtn
        {
            get { return docExtn; }
            set { docExtn = value; }
        }

        private System.String docRefNo;
        public System.String DocRefNo
        {
            get { return docRefNo; }
            set { docRefNo = value; }
        }

        private System.Decimal docSize;
        public System.Decimal DocSize
        {
            get { return docSize; }
            set { docSize = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private System.Boolean isWronglyClassified;
        public System.Boolean IsWronglyClassified
        {
            get { return isWronglyClassified; }
            set { isWronglyClassified = value; }
        }

        private System.String mimeTypeImagePath;
        public System.String MimeTypeImagePath
        {
            get { return mimeTypeImagePath; }
            set { mimeTypeImagePath = value; }
        }

        private System.String sizetoDisplay;
        public System.String SizetoDisplay
        {
            get { return sizetoDisplay; }
            set { sizetoDisplay = value; }
        }

        private System.String docTypeDisplay;
        public System.String DocTypeDisplay
        {
            get { return docTypeDisplay; }
            set { docTypeDisplay = value; }
        }

        private System.String securityImageDisplay;
        public System.String SecurityImageDisplay
        {
            get { return securityImageDisplay; }
            set { securityImageDisplay = value; }
        }

        private System.Decimal workProductSeq;
        public System.Decimal WorkProductSeq
        {
            get { return workProductSeq; }
            set { workProductSeq = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String docName;
        public System.String DocName
        {
            get { return docName; }
            set { docName = value; }
        }

        private System.Boolean isJustificationDoc;
        public System.Boolean IsJustificationDoc
        {
            get { return isJustificationDoc; }
            set { isJustificationDoc = value; }
        }

        private System.String confidentialJustDocSeq;
        public System.String ConfidentialJustDocSeq
        {
            get { return confidentialJustDocSeq; }
            set { confidentialJustDocSeq = value; }
        }

        private System.String sNo;
        public System.String SNo
        {
            get { return sNo; }
            set { sNo = value; }
        }
        private IDNameEntity docSubType = new IDNameEntity();
        public IDNameEntity DocSubType
        {
            get { return docSubType; }
            set { docSubType = value; }
        }
        private System.Decimal docSeq;
        public System.Decimal DocSeq
        {
            get { return docSeq; }
            set { docSeq = value; }
        }
        private System.DateTime createdDate;
        public System.DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private System.String protectiveOrdersNames;
        public System.String ProtectiveOrdersNames
        {
            get { return protectiveOrdersNames; }
            set { protectiveOrdersNames = value; }
        }
        private System.String protectiveOrdersIDs;
        public System.String ProtectiveOrdersIDs
        {
            get { return protectiveOrdersIDs; }
            set { protectiveOrdersIDs = value; }
        }

        private System.Int32 filingSeq;
        public System.Int32 FilingSeq
        {
            get { return filingSeq; }
            set { filingSeq = value; }
        }

        private System.Int32 filingNumber;
        public System.Int32 FilingNumber
        {
            get { return filingNumber; }
            set { filingNumber = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        private CodeNameEntity documentSubtype;
        public CodeNameEntity DocumentSubtype
        {
            get { return documentSubtype; }
            set { documentSubtype = value; }
        }
    }
}

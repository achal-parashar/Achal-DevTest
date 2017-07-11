//---------------------------------------------------------------------
// Author: JAY PRAKASH
// Version: 1.0.0
// Date: 05/23/2011
// Description: CAD Doc Entity
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
    /// <author>JAY PRAKASH</author>
    /// <creationDate>2007-11-22</ceationDate>
    /// <modifications>
        /// <item></item>
    /// </modifications>
   public class CadFilingDocEntity
    {
       

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

        private System.Decimal docSeq;
        public System.Decimal DocSeq
        {
            get { return docSeq; }
            set { docSeq = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
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

        private System.String docTitleURL;
        public System.String DocTitleURL
        {
            get { return docTitleURL; }
            set { docTitleURL = value; }
        }
      

        private System.String refDocGuidName;
        public System.String RefDocGuidName
        {
            get { return refDocGuidName; }
            set { refDocGuidName = value; }
        }
        private System.String sNo;
        public System.String SNo
        {
            get { return sNo; }
            set { sNo = value; }
        }
        private System.String versionNo;
        public System.String VersionNo
        {
            get { return versionNo; }
            set { versionNo = value; }
        }
        private System.String letterDecisionDesc;
        public System.String LetterDecisionDesc
        {
            get { return letterDecisionDesc; }
            set { letterDecisionDesc = value; }
        }
        private IndexValuesEntity indexValues = new IndexValuesEntity();
        public IndexValuesEntity IndexValues
        {
            get { return indexValues; }
            set { indexValues = value; }
        }

        private Nullable<System.DateTime> createddate;
        public Nullable<System.DateTime> CreatedDate
        {
            get { return createddate; }
            set { createddate = value; }
        }
        private System.String signedBy;
        public System.String SignedBy
        {
            get { return signedBy; }
            set { signedBy = value; }
        }
        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }
        private System.String pendingWith;
        public System.String PendingWith
        {
            get { return pendingWith; }
            set { pendingWith = value; }
        }
        private System.String isCheckedOut;
        public System.String IsCheckedOut
        {
            get { return isCheckedOut; }
            set { isCheckedOut = value; }
        }
        
        private System.String checkedUserID;
        public System.String CheckedUserID
        {
            get { return checkedUserID; }
            set { checkedUserID = value; }
        }
    }
}

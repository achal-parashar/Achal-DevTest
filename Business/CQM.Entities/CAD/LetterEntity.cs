//---------------------------------------------------------------------
// Author: JAY Prakash  
// Version: 1.0.0
// Date: 18/May/2011
// Description: Letter Entity
//
// History:
// Changed By          
// Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Letter Type and Title.
    /// </summary>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-18-May</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class LetterEntity
    {
        private System.String lettertype;
        public System.String LetterType
        {
            get { return lettertype; }
            set { lettertype = value; }
        }
        private System.Int32 lettertypeseq;
        public System.Int32 LetterType_Seq
        {
            get { return lettertypeseq; }
            set { lettertypeseq = value; }
        }
        private System.String lettertitle;
        public System.String LetterTitle
        {
            get { return lettertitle; }
            set { lettertitle = value; }
        }
        private System.Int32 lettertitleseq;
        public System.Int32 LetterTitle_Seq
        {
            get { return lettertitleseq; }
            set { lettertitleseq = value; }
        }
        private System.String letterTypeSeqNTempName;
        public System.String LetterTypeSeqNTempName
        {
            get { return letterTypeSeqNTempName; }
            set { letterTypeSeqNTempName = value; }
        }
        private System.String trackCaseNumber;
        public System.String TrackCaseNumber
        {
            get { return trackCaseNumber; }
            set { trackCaseNumber = value; }
        }
        private System.Int32 templatedetailSeq;
        public System.Int32 TemplatedetailSeq
        {
            get { return templatedetailSeq; }
            set { templatedetailSeq = value; }
        }
        private List<CadFilingDocEntity> docEntity;
        public List<CadFilingDocEntity> DocEntity
        {
            get { return docEntity; }
            set { docEntity = value; }
        }

        private System.Int32 letterDecisionSeq;
        public System.Int32 LetterDecisionSeq
        {
            get { return letterDecisionSeq; }
            set { letterDecisionSeq = value; }
        }
        private System.String recipientCode;
        public System.String RecipientCode
        {
            get { return recipientCode; }
            set { recipientCode = value; }
        }
        private System.String sentTo;
        public System.String SentTo
        {
            get { return sentTo; }
            set { sentTo = value; }
        }
        private System.String sentVia;
        public System.String SentVia
        {
            get { return sentVia; }
            set { sentVia = value; }
        }

        private System.String printedBy;
        public System.String PrintedBy
        {
            get { return printedBy; }
            set { printedBy = value; }
        }

        private System.DateTime printedDate;
        public System.DateTime PrintedDate
        {
            get { return printedDate; }
            set { printedDate = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private System.DateTime createDate;
        public System.DateTime CreatedDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        private System.String isPrinted;
        public System.String IsPrinted
        {
            get { return isPrinted; }
            set { isPrinted = value; }
        }
        private System.String emailId;
        public System.String EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        private System.String address;
        public System.String Address
        {
            get { return address; }
            set { address = value; }
        }
        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private Nullable<System.DateTime> updatedDate;
        public Nullable<System.DateTime> UpdatedDate
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

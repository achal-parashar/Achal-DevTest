//---------------------------------------------------------------------
// Author: Jatin Maradia
// Version: 1.0.0
// Date: 06/03/2007
// Description: SearchDocumentEntity
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
    /// This entity class stores the information about SearchDocumentEntity required for search document.
    /// </summary>
    /// <author>Jatin Maradia</author>
    /// <creationDate>2008-03-06</ceationDate>
    /// <modifications>
    /// <item></item>
    /// </modifications>
    public class SearchDocumentEntity
    {
        private System.DateTime dateFiledFrom;
        public System.DateTime DateFiledFrom
        {
            get { return dateFiledFrom; }
            set { dateFiledFrom = value; }
        }

        private System.DateTime dateFiledTo;
        public System.DateTime DateFiledTo
        {
            get { return dateFiledTo; }
            set { dateFiledTo = value; }
        }

        private IDNameEntity documentType;
        public IDNameEntity DocumentType
        {
            get { return documentType; }
            set { documentType = value; }
        }

        private IDNameEntity documentSubType;
        public IDNameEntity DocumentSubType
        {
            get { return documentSubType; }
            set { documentSubType = value; }
        }

        private IDNameEntity documentClassification;
        public IDNameEntity DocumentClassification
        {
            get { return documentClassification; }
            set { documentClassification = value; }
        }

        private System.String fullText;
        public System.String FullText
        {
            get { return fullText; }
            set { fullText = value; }
        }

        private System.String userType;
        public System.String UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        private System.String userID;
        public System.String UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private System.String officeShortName;
        public System.String OfficeShortName
        {
            get { return officeShortName; }
            set { officeShortName = value; }
        }

        //@@@@
        private System.String fullTextPhrase;
        public System.String FullTextPhrase
        {
            get { return fullTextPhrase; }
            set { fullTextPhrase = value; }
        }
        private System.Int32 docCompanyID;
        public System.Int32 DocCompanyID
        {
            get { return docCompanyID; }
            set { docCompanyID = value; }
        }
        private System.String docCompanyName;
        public System.String DocCompanyName
        {
            get { return docCompanyName; }
            set { docCompanyName = value; }
        }
        private System.String documentTitle;
        public System.String DocumentTitle
        {
            get { return documentTitle; }
            set { documentTitle = value; }
        }

        //@@@@
        //START CODE ADDED BY ACHAL 3rd JUNE 2015  For CQM84
        private System.String isCommissionIssued;
        public System.String IsCommissionIssued
        {
            get { return isCommissionIssued; }
            set { isCommissionIssued = value; }
        }
        //END CODE ADDED BY ACHAL 3rd JUNE 2015  For CQM84
    }
}

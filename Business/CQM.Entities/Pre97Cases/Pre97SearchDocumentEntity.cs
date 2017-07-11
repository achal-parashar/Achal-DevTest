//---------------------------------------------------------------------
// Author: Deepshikha
// Version: 1.0.0
// Date: 12/21/2011
// Description: Pre97SearchDocumentEntity
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
    /// This entity class stores the information about SearchPre97DocumentEntity required for searching pre97 document.
    /// </summary>
    /// <author>Deepshikha</author>
    /// <creationDate>2011-12-21</ceationDate>
    /// <modifications>
    /// <item></item>
    /// </modifications>
    public class Pre97SearchDocumentEntity
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

        private System.String documentType;
        public System.String DocumentType
        {
            get { return documentType; }
            set { documentType = value; }
        }

        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        private System.String documentTitle;
        public System.String DocumentTitle
        {
            get { return documentTitle; }
            set { documentTitle = value; }
        }

        private System.String fullText;
        public System.String FullText
        {
            get { return fullText; }
            set { fullText = value; }
        }

        private System.String caseTitle;
        public System.String CaseTitle
        {
            get { return caseTitle; }
            set { caseTitle = value; }
        }

        private System.String initialFilingParty ;
        public System.String InitialFilingParty
        {
            get { return initialFilingParty; }
            set { initialFilingParty = value; }
        }


        private System.String filingParty;
        public System.String FilingParty
        {
            get { return filingParty; }
            set { filingParty = value; }
        }

        private System.String fullTextPhrase;
        public System.String FullTextPhrase
        {
            get { return fullTextPhrase; }
            set { fullTextPhrase = value; }
        }
        private System.String userID;
        public System.String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private System.String documentSubtype;
        public System.String DocumentSubtype
        {
            get { return documentSubtype; }
            set { documentSubtype = value; }
        }
    }
}

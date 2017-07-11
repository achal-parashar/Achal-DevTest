//---------------------------------------------------------------------
// Author: Deepshikha Varshney
// Version: 1.0.0
// Date: 12-22-2011
// Description: Pre97SearchDocumentResultEntity Entity
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
    /// This entity class stores the information about the result sets of the Pre 1997 SearchDocument 
    /// </summary>
    /// <author>Deepshikha Varshney</author>
    /// <creationDate>12-21-2011</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class Pre97SearchDocumentResultEntity
    {
        private System.DateTime dateFiled;
        public System.DateTime DateFiled
        {
            get { return dateFiled; }
            set { dateFiled = value; }
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

        private System.String initialFilingParty;
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
        private System.Int16 totalrecords;
        public System.Int16 TotalRecords
        {
            get { return totalrecords; }
            set { totalrecords = value; }
        }

        private System.Int16 securityflag;
        public System.Int16 SecurityFlag
        {
            get { return securityflag; }
            set { securityflag = value; }
        }
        private System.Int16 versionNo;
        public System.Int16 VersionNo
        {
            get { return versionNo; }
            set { versionNo = value; }
        }

        private System.Int16 fillingseq;
        public System.Int16 FillingSeq
        {
            get { return fillingseq; }
            set { fillingseq = value; }
        }
        private System.String documentRefNo;
        public System.String DocumentRefNo
        {
            get { return documentRefNo; }
            set { documentRefNo = value; }
        }
        private System.String documentSubtype;
        public System.String DocumentSubtype
        {
            get { return documentSubtype; }
            set { documentSubtype = value; }
        }
        private System.String documentExtension;
        public System.String DocumentExtension
        {
            get { return documentExtension; }
            set { documentExtension = value; }
        }
        private List<MatterDocumentEntity> publicDocuments;

        public List<MatterDocumentEntity> PublicDocuments
        {
            get { return publicDocuments; }
            set { publicDocuments = value; }
        }

    }
}

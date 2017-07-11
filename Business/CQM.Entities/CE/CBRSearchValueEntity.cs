using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    public class CBRSearchValue
    {
        private String m_strContentToSearch;
        private String m_strDocumentType;
        private String m_strDocumentClassification;
        private String m_strUserID;
        private DateTime m_dtDateFrom;
        private DateTime m_dtDateTo;
        //Added By Richa for CAD
        private String m_strCaseNumber;
        private DateTime m_dtFiledDate;
        private String m_strUtilityType;
        private String m_strCompanyName;
        private String m_strCaseType;
        private String m_strIssueType;
        private String m_strAgencyType;
        private String m_strModuleType;
        private String m_strFolderName;
        //End of CAD Entries
        //Added By Richa for CMS
        private string m_strFilingParty;
        //End of CMS Entries

        //Added By Richa for DR
        private System.String drQuestionIdField;
        //End of DR Entries
        /// <summary>
        /// ContentToSearch in the Filenet Document.
        /// </summary>
        /// <param name="",""></param>
        /// <author>Reetu Singh</author>
        /// <creationDate>2008-01-08</ceationDate>
        /// <modifications>
        /// </modifications>
        public string ContentToSearch
        {
            get
            {
                return m_strContentToSearch;
            }
            set
            {
                this.m_strContentToSearch = value;
            }
        }
        /// <summary>
        /// Document type.
        /// </summary>
        /// <param name="",""></param>
        /// <author>Reetu Singh</author>
        /// <creationDate>2008-01-08</ceationDate>
        /// <modifications>
        /// </modifications>
        public string DocumentType
        {
            get
            {
                return m_strDocumentType;
            }
            set
            {
                this.m_strDocumentType = value;
            }
        }
        /// <summary>
        /// DocumentClassification.
        /// </summary>
        /// <param name="",""></param>
        /// <author>Reetu Singh</author>
        /// <creationDate>2008-01-08</ceationDate>
        /// <modifications>
        /// </modifications>
        public string DocumentClassification
        {
            get
            {
                return m_strDocumentClassification;
            }
            set
            {
                this.m_strDocumentClassification = value;
            }
        }
        /// <summary>
        /// UserID.
        /// </summary>
        /// <param name="",""></param>
        /// <author>Reetu Singh</author>
        /// <creationDate>2008-01-08</ceationDate>
        /// <modifications>
        /// </modifications>
        public string UserID
        {
            get
            {
                return m_strUserID;
            }
            set
            {
                this.m_strUserID = value;
            }
        }
        /// <summary>
        /// Range of DateFrom where to search begin.
        /// </summary>
        /// <param name="",""></param>
        /// <author>Reetu Singh</author>
        /// <creationDate>2008-01-08</ceationDate>
        /// <modifications>
        /// </modifications>
        public DateTime DateFrom
        {
            get
            {
                return m_dtDateFrom;
            }
            set
            {
                this.m_dtDateFrom = value;
            }
        }
        /// <summary>
        /// Range of DateTo where to search will stop.
        /// </summary>
        /// <param name="",""></param>
        /// <author>Reetu Singh</author>
        /// <creationDate>2008-01-08</ceationDate>
        /// <modifications>
        /// </modifications>
        public DateTime DateTo
        {
            get
            {
                return m_dtDateTo;
            }
            set
            {
                this.m_dtDateTo = value;
            }
        }
        //----------------------------Added by Richa For CAD--------------------------------------------- 
        public string CaseNumber
        {
            get
            {
                return m_strCaseNumber;
            }
            set
            {
                this.m_strCaseNumber = value;
            }
        }

        public DateTime FiledDate
        {
            get
            {
                return m_dtFiledDate;
            }
            set
            {
                this.m_dtFiledDate = value;
            }
        }

        public string UtilityType
        {
            get
            {
                return m_strUtilityType;
            }
            set
            {
                this.m_strUtilityType = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return m_strCompanyName;
            }
            set
            {
                this.m_strCompanyName = value;
            }
        }

        public string CaseType
        {
            get
            {
                return m_strCaseType;
            }
            set
            {
                this.m_strCaseType = value;
            }
        }

        public string IssueType
        {
            get
            {
                return m_strIssueType;
            }
            set
            {
                this.m_strIssueType = value;
            }
        }
        //----------------------------End of CAD Entries-------------------------------------------------
        //----------------------------Added by Richa For CMS---------------------------------------------
        public string FilingParty
        {
            get
            {
                return m_strFilingParty;
            }
            set
            {
                this.m_strFilingParty = value;
            }
        }

        //----------------------------End of CMS Entries-------------------------------------------------

        //----------------------------Added by Richa For DR---------------------------------------------
        public string DrQuestionId
        {
            get
            {
                return this.drQuestionIdField;
            }
            set
            {
                this.drQuestionIdField = value;
            }
        }
        //----------------------------End of DR Entries-------------------------------------------------
        public string AgencyType
        {
            get
            {
                return m_strAgencyType;
            }
            set
            {
                this.m_strAgencyType = value;
            }
        }

        public string ModuleType
        {
            get
            {
                return m_strModuleType;
            }
            set
            {
                this.m_strModuleType = value;
            }
        }

        public string FolderName
        {
            get
            {
                return m_strFolderName;
            }
            set
            {
                this.m_strFolderName = value;
            }
        }
    }
}

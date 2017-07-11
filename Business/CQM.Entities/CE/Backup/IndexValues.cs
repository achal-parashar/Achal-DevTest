//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 02/12/2008
// Description: IndexValues Entity
//
// History:
// Changed By                       Changed On
//Ritika                            17/12/2001
//Modified to add Tariff attributes 
//Ritika                            01/06/2012
//Modified for tariff
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Index Entity 
    /// being used for Adding/indexing documents in FileNet
    /// mapping entity with IndexValues of FileNet
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2008-02-12</creationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class IndexValuesEntity
    {
        private System.String companyName;
        public System.String CompanyName
        {
            get { return companyName; }
            set { this.companyName = value; }
        }

        private System.String documentType;
        public System.String DocumentType
        {
            get { return documentType; }
            set { this.documentType = value; }
        }

        private System.String industryAffected;
        public System.String IndustryAffected
        {
            get { return industryAffected; }
            set { this.industryAffected = value; }
        }

        private System.String industrySubtype;
        public System.String IndustrySubtype
        {
            get { return industrySubtype; }
            set { this.industrySubtype = value; }
        }

        private System.String matterNumber;
        public System.String MatterNumber
        {
            get { return matterNumber; }
            set { this.matterNumber = value; }
        }

        private System.String matterSubType;
        public System.String MatterSubType
        {
            get { return matterSubType; }
            set { this.matterSubType = value; }
        }

        private System.String matterType;
        public System.String MatterType
        {
            get { return matterType; }
            set { this.matterType = value; }
        }

        private System.String county;
        public System.String County
        {
            get { return county; }
            set { this.county = value; }
        }
        private System.String municipality;
        public System.String Municipality
        {
            get { return municipality; }
            set { this.municipality = value; }
        }

        private System.String franchise;
        public System.String Franchise
        {
            get { return franchise; }
            set { this.franchise = value; }
        }

        private Nullable<System.DateTime> filedDate;
        public Nullable<System.DateTime> FiledDate
        {
            get { return filedDate; }
            set { this.filedDate = value; }
        }

        private System.String documentSecurity;
        public System.String DocumentSecurity
        {
            get { return documentSecurity; }
            set { this.documentSecurity = value; }
        }

        private System.String documentTitle;
        public System.String DocumentTitle
        {
            get { return documentTitle; }
            set { this.documentTitle = value; }
        }

        private System.String documentClassification;
        public System.String DocumentClassification
        {
            get { return documentClassification; }
            set { this.documentClassification = value; }
        }

        private System.String documentId;
        public System.String DocumentId
        {
            get { return documentId; }
            set { this.documentId = value; }
        }

        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { this.caseNumber = value; }
        }

        private System.DateTime purgeDate;
        public System.DateTime PurgeDate
        {
            get { return purgeDate; }
            set { this.purgeDate = value; }
        }

        private System.Boolean isMigrated;
        public System.Boolean IsMigrated
        {
            get { return isMigrated; }
            set { this.isMigrated = value; }
        }

        private System.String userID;
        public System.String UserID
        {
            get { return userID; }
            set { this.userID = value; }
        }

        private System.String documentExtension;
        public System.String DocumentExtension
        {
            get { return documentExtension; }
            set { this.documentExtension = value; }
        }

        private System.String documentMimeType;
        public System.String DocumentMimeType
        {
            get { return documentMimeType; }
            set { this.documentMimeType = value; }
        }

        private System.String documentName;
        public System.String DocumentName
        {
            get { return documentName; }
            set { this.documentName = value; }
        }

        private System.String contentElement;
        public System.String ContentElement
        {
            get { return contentElement; }
            set { this.contentElement = value; }
        }
        /*------------------------------------------------------------------------------------------------------------------
        // New Paramaters added for CAD by Richa - 21st July 11
         -------------------------------------------------------------------------------------------------------------------*/
        private System.String utilityType;
        public System.String UtilityType
        {
            get { return utilityType; }
            set { this.utilityType = value; }
        }
        private System.String utilitySubType;
        public System.String UtilitySubType
        {
            get { return utilitySubType; }
            set { this.utilitySubType = value; }
        }
        private System.String caseType;
        public System.String CaseType
        {
            get { return caseType; }
            set { this.caseType = value; }
        }
        private System.String caseSubType;
        public System.String CaseSubType
        {
            get { return caseSubType; }
            set { this.caseSubType = value; }
        }
        private System.String trackingNumber;
        public System.String TrackingNumber
        {
            get { return trackingNumber; }
            set { this.trackingNumber = value; }
        }
        private System.String utilityCompany;
        public System.String UtilityCompany
        {
            get { return utilityCompany; }
            set { this.utilityCompany = value; }
        }
        private System.String issueType;
        public System.String IssueType
        {
            get { return issueType; }
            set { this.issueType = value; }
        }
        private System.Boolean isBusiness;
        public System.Boolean IsBusiness
        {
            get { return isBusiness; }
            set { this.isBusiness = value; }
        }
        private System.String customerName;
        public System.String CustomerName
        {
            get { return customerName; }
            set { this.customerName = value; }
        }
        private System.String status;
        public System.String Status
        {
            get { return status; }
            set { this.status = value; }
        }
        private System.String dispositionStatus;
        public System.String DispositionStatus
        {
            get { return dispositionStatus; }
            set { this.dispositionStatus = value; }
        }
        private System.Boolean isAppealed;
        public System.Boolean IsAppealed
        {
            get { return isAppealed; }
            set { this.isAppealed = value; }
        }
        private System.String accountNumber;
        public System.String AccountNumber
        {
            get { return accountNumber; }
            set { this.accountNumber = value; }
        }
        private System.String moduleType;
        public System.String ModuleType
        {
            get { return moduleType; }
            set { this.moduleType = value; }
        }
        private System.String folderName;
        public System.String FolderName
        {
            get { return folderName; }
            set { this.folderName = value; }
        }
        private System.String agencyType;
        public System.String AgencyType
        {
            get { return agencyType; }
            set { this.agencyType = value; }
        }

        /*------------------------------------------------------------------------------------------------------------------
      // New Paramaters added for AR by Richa - 19th Aug 11
       -------------------------------------------------------------------------------------------------------------------*/
        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { this.updatedBy = value; }
        }

        private Nullable<System.DateTime> updatedDate;
        public Nullable<System.DateTime> UpdatedDate
        {
            get { return updatedDate; }
            set { this.updatedDate = value; }
        }

        private System.Decimal revenueAssmtSub;
        public System.Decimal RevenueAssmtSub
        {
            get { return revenueAssmtSub; }
            set { this.revenueAssmtSub = value; }
        }

        private System.Decimal reportYear;
        public System.Decimal ReportYear
        {
            get { return reportYear; }
            set { this.reportYear = value; }
        }

        private System.String reportType;
        public System.String ReportType
        {
            get { return reportType; }
            set { this.reportType = value; }
        }

        private System.String perCompletingAR;
        public System.String PerCompletingAR
        {
            get { return perCompletingAR; }
            set { this.perCompletingAR = value; }
        }

        private System.String filingTitle;
        public System.String FilingTitle
        {
            get { return filingTitle; }
            set { this.filingTitle = value; }
        }

        private System.Boolean filedExternally;
        public System.Boolean FiledExternally
        {
            get { return filedExternally; }
            set { this.filedExternally = value; }
        }

        private Nullable<System.DateTime> createdDate;
        public Nullable<System.DateTime> CreatedDate
        {
            get { return createdDate; }
            set { this.createdDate = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { this.createdBy = value; }
        }
        /*------------------------------------------------------------------------------------------------------------------
    // New Paramaters added for CMS by Richa - 29th Aug 11
     -------------------------------------------------------------------------------------------------------------------*/
        private System.String documentSubType;
        public System.String DocumentSubType
        {
            get { return documentSubType; }
            set { this.documentSubType = value; }
        }
        private System.String filingParty;
        public System.String FilingParty
        {
            get { return filingParty; }
            set { this.filingParty = value; }
        }
        private System.String documentCategory;
        public System.String DocumentCategory
        {
            get { return documentCategory; }
            set { this.documentCategory = value; }
        }
        private System.String documentDescription;
        public System.String DocumentDescription
        {
            get { return documentDescription; }
            set { this.documentDescription = value; }
        }
        private System.Decimal filingNumber;
        public System.Decimal FilingNumber
        {
            get { return filingNumber; }
            set { this.filingNumber = value; }
        }

        /*------------------------------------------------------------------------------------------------------------------
       // New Paramaters added for Tarrif by Richa - 31th Aug 11
        -------------------------------------------------------------------------------------------------------------------*/
        private System.String attachmentStatus;
        public System.String AttachmentStatus
        {
            get { return attachmentStatus; }
            set { this.attachmentStatus = value; }
        }
        private System.String tarrifType;
        public System.String TarrifType
        {
            get { return tarrifType; }
            set { this.tarrifType = value; }
        }
        private System.String rateSectionName;
        public System.String RateSectionName
        {
            get { return rateSectionName; }
            set { this.rateSectionName = value; }
        }
        private System.String sectionNumber;
        public System.String SectionNumber
        {
            get { return sectionNumber; }
            set { this.sectionNumber = value; }
        }
        private System.String rateSectionDescription;
        public System.String RateSectionDescription
        {
            get { return rateSectionDescription; }
            set { this.rateSectionDescription = value; }
        }
        private System.Decimal tarrifID;
        public System.Decimal TarrifID
        {
            get { return tarrifID; }
            set { this.tarrifID = value; }
        }
        private Nullable<System.DateTime> cancellationDate;
        public Nullable<System.DateTime> CancellationDate
        {
            get { return cancellationDate; }
            set { this.cancellationDate = value; }
        }
        private Nullable<System.DateTime> lastRevisionDate;
        public Nullable<System.DateTime> LastRevisionDate
        {
            get { return lastRevisionDate; }
            set { this.lastRevisionDate = value; }
        }

        /*------------------------------------------------------------------------------------------------------------------
     // New Paramaters added for DR by Richa - 5th Sep 11
      -------------------------------------------------------------------------------------------------------------------*/

        private Nullable<System.DateTime> drQuestionDueDate;
        public Nullable<System.DateTime> DrQuestionDueDate
        {
            get { return drQuestionDueDate; }
            set { this.drQuestionDueDate = value; }
        }

        private System.String drQuestionId;
        public System.String DrQuestionId
        {
            get { return drQuestionId; }
            set { this.drQuestionId = value; }
        }

        private Nullable<System.DateTime> drSetDueDate;
        public Nullable<System.DateTime> DrSetDueDate
        {
            get { return drSetDueDate; }
            set { this.drSetDueDate = value; }
        }

        private System.String drSetId;
        public System.String DrSetId
        {
            get { return drSetId; }
            set { this.drSetId = value; }
        }
        private System.String drType;
        public System.String DrType
        {
            get { return drType; }
            set { this.drType = value; }
        }
        private System.String requesteeCode;
        public System.String RequesteeCode
        {
            get { return requesteeCode; }
            set { this.requesteeCode = value; }
        }
        private System.String requesterCode;
        public System.String RequesterCode
        {
            get { return requesterCode; }
            set { this.requesterCode = value; }
        }

        //Start Tariff attributes for tariff integration
        private System.String rateSecdescription;
        public System.String RateSecDescription
        {
            get { return rateSecdescription; }
            set { this.rateSecdescription = value; }
        }

        private System.String tarrifbookid;
        public System.String TarrifBookId
        {
            get { return tarrifbookid; }
            set { this.tarrifbookid = value; }

        }
        private System.String ratesecname;
        public System.String RateSecName
        {
            get { return ratesecname; }
            set { this.ratesecname = value; }
        }

        //End Tariff attributes for tariff integration
        //Start Tariff 01062012
        //DocumentIdArray stores Array of Doc IDs
        private System.String[] documentIdArray;
        public System.String[] DocumentIdArray
        {
            get { return documentIdArray; }
            set
            {
                if (documentIdArray != null)
                {
                    for (int i = 0; i < documentIdArray.Length; i++)
                    {
                        this.documentIdArray[i] = value[i];
                    }
                }
            }
        }
        //end tariff 01062012
    }
}

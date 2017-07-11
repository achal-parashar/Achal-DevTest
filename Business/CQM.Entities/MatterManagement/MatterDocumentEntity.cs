//---------------------------------------------------------------------
// Author: Amitava Sinha
// Version: 1.0.0
// Date: 01/09/2008
// Description: This MatterDocumentEntity class stores the information about Matter Document.
//
// History:
// Changed By                       Changed On
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace CQM.Entities
{
    /// <summary>
    /// This MatterDocumentEntity class stores the information about Matter Document.
    /// </summary>
    /// <author>Amitava Sinha</author>
    /// <creationDate>2007-09-01</ceationDate>
    /// <modifications>
    /// <item>2007-09-01;Amitava Sinha;Added new Functions</item>
    /// <item>Date;By;Description</item>
    /// </modifications>
    /// 
    public class MatterDocumentEntity
    {
        private System.Int32 itemNo;
        public System.Int32 ItemNo
        {
            get { return itemNo; }
            set { itemNo = value; }
        }
        private System.Int32 filingSeq;
        public System.Int32 FilingSeq
        {
            get { return filingSeq; }
            set { filingSeq = value; }
        }
        private System.DateTime filedDate;
        public System.DateTime FiledDate
        {
            get { return filedDate; }
            set { filedDate = value; }
        }
        private System.String securityFlag;
        public System.String SecurityFlag
        {
            get { return securityFlag; }
            set { securityFlag = value; }
        }
        private System.String filingCompany;
        public System.String FilingCompany
        {
            get { return filingCompany; }
            set { filingCompany = value; }
        }
        private System.Int32 docSeq;
        public System.Int32 DocSeq
        {
            get { return docSeq; }
            set { docSeq = value; }
        }
        private System.String docTitle;
        public System.String DocTitle
        {
            get { return docTitle; }
            set { docTitle = value; }
        }
        private System.String docName;
        public System.String DocName
        {
            get { return docName; }
            set { docName = value; }
        }
        private System.String doctype;
        public System.String Doctype
        {
            get { return doctype; }
            set { doctype = value; }
        }
        private System.String mimeType;
        public System.String MimeType
        {
            get { return mimeType; }
            set { mimeType = value; }
        }
        private System.String includeAgenda;
        public System.String IncludeAgenda
        {
            get { return includeAgenda; }
            set { includeAgenda = value; }
        }
        private System.String docRefNo;
        public System.String DocRefNo
        {
            get { return docRefNo; }
            set { docRefNo = value; }
        }
        private System.String docSize;
        public System.String DocSize
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
        private System.String createdById;
        public System.String CreatedById
        {
            get { return createdById; }
            set { createdById = value; }
        }
        private System.String authorName;
        public System.String AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        private System.DateTime createdDate;
        public System.DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        private System.String modifiedBy;
        public System.String ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }
        private System.DateTime modifiedDate;
        public System.DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
        private System.Int32 versionNo;
        public System.Int32 VersionNo
        {
            get { return versionNo; }
            set { versionNo = value; }
        }
        private System.Int32 requestCount;
        public System.Int32 RequestCount
        {
            get { return requestCount; }
            set { requestCount = value; }
        }
        private System.Int32 reviewedCount;
        public System.Int32 ReviewedCount
        {
            get { return reviewedCount; }
            set { reviewedCount = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String imageAccess;
        public System.String ImageAccess
        {
            get { return imageAccess; }
            set { imageAccess = value; }
        }
        private System.String imageRead;
        public System.String ImageRead
        {
            get { return imageRead; }
            set { imageRead = value; }
        }
        private System.String uRLCheck;
        public System.String URLCheck
        {
            get { return uRLCheck; }
            set { uRLCheck = value; }
        }
        private System.String imagePath;
        public System.String ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        private System.String docExt;
        public System.String DocExt
        {
            get { return docExt; }
            set { docExt = value; }
        }
        private System.String confidentialDocImage;
        public System.String ConfidentialDocImage
        {
            get { return confidentialDocImage; }
            set { confidentialDocImage = value; }
        }
        private System.String protectiveOrderImage;
        public System.String ProtectiveOrderImage
        {
            get { return protectiveOrderImage; }
            set { protectiveOrderImage = value; }
        }
        
        private System.String docDesc;
        public System.String DocDesc
        {
            get { return docDesc; }
            set { docDesc = value; }
        }
        private System.Int32 matterSeq;
        public System.Int32 MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
        }
        private System.String athrName;
        public System.String AthrName
        {
            get { return athrName; }
            set { athrName = value; }
        }
        private System.String checkOut;
        public System.String CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
        private System.String matterNumber;
        public System.String MatterNumber
        {
            get { return matterNumber; }
            set { matterNumber = value; }
        }
        private System.String author;
        public System.String Author
        {
            get { return author; }
            set { author = value; }
        }
        private System.String limitedAcces;
        public System.String LimitedAcces
        {
            get { return limitedAcces; }
            set { limitedAcces = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.String strDocSeq;
        public System.String StrDocSeq
        {
            get { return strDocSeq; }
            set { strDocSeq = value; }
        }
        private System.String docStatus;
        public System.String DocStatus
        {
            get { return docStatus; }
            set { docStatus = value; }
        }
        private System.String isRead;
        public System.String IsRead
        {
            get { return isRead; }
            set { isRead = value; }
        }
        private System.String docSecurity;
        public System.String DocSecurity
        {
            get { return docSecurity; }
            set { docSecurity = value; }
        }
        private System.String docSecurityValue;
        public System.String DocSecurityValue
        {
            get { return docSecurityValue; }
            set { docSecurityValue = value; }
        }
        private List<IDNameEntity> relatedFilingList = new List<IDNameEntity>();
        public List<IDNameEntity> RelatedFilingList
        {
            get { return relatedFilingList; }
            set { relatedFilingList = value; }
        }

        private System.String justificationDocExt;
        public System.String JustificationDocExt
        {
            get { return justificationDocExt; }
            set { justificationDocExt = value; }
        }
        private System.String justificationDocRefNo;
        public System.String JustificationDocRefNo
        {
            get { return justificationDocRefNo; }
            set { justificationDocRefNo = value; }
        }
        private System.String justificationImagePath;
        public System.String JustificationImagePath
        {
            get { return justificationImagePath; }
            set { justificationImagePath = value; }
        }
        private System.String justificationsecurityFlag;
        public System.String JustificationSecurityFlag
        {
            get { return justificationsecurityFlag; }
            set { justificationsecurityFlag = value; }
        }

        private System.String etsSubmissionID;
        public System.String EtsSubmissionID
        {
            get { return etsSubmissionID; }
            set { etsSubmissionID = value; }
        }

        private System.Boolean isTariff;
        public System.Boolean IsTariff
        {
            get { return isTariff; }
            set { isTariff = value; }
        }

        private System.String pSCNumbers;
        public System.String PSCNumbers
        {
            get { return pSCNumbers; }
            set { pSCNumbers = value; }
        }

        private System.String tariffTitle;
        public System.String TariffTitle
        {
            get { return tariffTitle; }
            set { tariffTitle = value; }
        }

        private System.String purposeOfFiling;
        public System.String PurposeOfFiling
        {
            get { return purposeOfFiling; }
            set { purposeOfFiling = value; }
        }

        private System.String detailsOfRevision;
        public System.String DetailsOfRevision
        {
            get { return detailsOfRevision; }
            set { detailsOfRevision = value; }
        }

        private System.DateTime issueDate;
        public System.DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        private System.DateTime effectiveDate;
        public System.DateTime EffectiveDate
        {
            get { return effectiveDate; }
            set { effectiveDate = value; }
        }

        private System.DateTime tariffDateFiled;
        public System.DateTime TariffDateFiled
        {
            get { return tariffDateFiled; }
            set { tariffDateFiled = value; }
        }

        private System.String officeShortName;
        public System.String OfficeShortName
        {
            get { return officeShortName; }
            set { officeShortName = value; }
        }
        private System.String complianceFiling;
        public System.String ComplianceFiling
        {
            get { return complianceFiling; }
            set { complianceFiling = value; }
        }

        private System.Boolean exceedsMaxRecord;
        public System.Boolean ExceedsMaxRecord
        {
            get { return exceedsMaxRecord; }
            set { exceedsMaxRecord = value; }
        }
        private System.String isAccessible;
        public System.String IsAccessible
        {
            get { return isAccessible; }
            set { isAccessible = value; }
        }

        private System.String filingCompanyWithSeq;
        public System.String FilingCompanyWithSeq
        {
            get { return filingCompanyWithSeq; }
            set { filingCompanyWithSeq = value; }
        }

        private System.String isRepSelf;
        public System.String IsRepSelf
        {
            get { return isRepSelf; }
            set { isRepSelf = value; }
        }

        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }

        private System.String doctypesubtype;
        public System.String DocTypeSubtype
        {
            get { return doctypesubtype; }
            set { doctypesubtype = value; }
        }
        //Start --R2 Added By Ashish Mamodia on 24 July 2012 for DEFW50
        private System.String docSubTypeDesc;
        public System.String DocSubTypeDesc
        {
            get { return docSubTypeDesc; }
            set { this.docSubTypeDesc = value; }
        }
        //End --R2 Added By Ashish Mamodia on 24 July 2012 for DEFW50
    }
}

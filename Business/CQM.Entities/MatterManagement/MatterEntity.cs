//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/22/2007
// Description: Matter Entity
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
    /// This entity class stores the information about Matter Entity
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-11-22</ceationDate>
    /// <modifications>
    /// <item>2008-02-02;Ritika Fakay;Added comments</item>
    /// <item></item>
    /// </modifications>

    public class MatterEntity
    {
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private System.DateTime createdDate;
        public System.DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private System.DateTime exptCompDate;
        public System.DateTime ExptCompDate
        {
            get { return exptCompDate; }
            set { exptCompDate = value; }
        }

        private IDNameEntity industryAffected = new IDNameEntity();
        public IDNameEntity IndustryAffected
        {
            get { return industryAffected; }
            set { industryAffected = value; }
        }

        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        private System.String isFormal;
        public System.String IsFormal
        {
            get { return isFormal; }
            set { isFormal = value; }
        }

        private System.String matterNumber;
        public System.String MatterNumber
        {
            get { return matterNumber; }
            set { matterNumber = value; }
        }

        private System.Decimal matterID;
        public System.Decimal MatterID
        {
            get { return matterID; }
            set { matterID = value; }
        }

        private IDNameEntity matterSubtype = new IDNameEntity();
        public IDNameEntity MatterSubtype
        {
            get { return matterSubtype; }
            set { matterSubtype = value; }
        }

        private System.String matterTitle;
        public System.String MatterTitle
        {
            get { return matterTitle; }
            set { matterTitle = value; }
        }

        private IDNameEntity matterType = new IDNameEntity();
        public IDNameEntity MatterType
        {
            get { return matterType; }
            set { matterType = value; }
        }

        private System.String isSapaReq;
        public System.String IsSapaReq
        {
            get { return isSapaReq; }
            set { isSapaReq = value; }
        }

        private System.String sourceCode;
        public System.String SourceCode
        {
            get { return sourceCode; }
            set { sourceCode = value; }
        }

        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }

        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private System.DateTime updatedDate;
        public System.DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }

        private System.String isHearingReq;
        public System.String IsHearingReq
        {
            get { return isHearingReq; }
            set { isHearingReq = value; }
        }

        private System.Int32 contactID;
        public System.Int32 ContactID
        {
            get { return contactID; }
            set { contactID = value; }
        }

        private System.String filingDesc;
        public System.String FilingDesc
        {
            set { filingDesc = value; }
            get { return filingDesc; }
        }

        private System.DateTime filedDate;
        public System.DateTime FiledDate
        {
            set { filedDate = value; }
            get { return filedDate; }
        }

        private System.String filingStatusCode;
        public System.String FilingStatusCode
        {
            set { filingStatusCode = value; }
            get { return filingStatusCode; }
        }

        private List<IDNameEntity> companyIDs = new List<IDNameEntity>();
        public List<IDNameEntity> CompanyIDs
        {
            get { return companyIDs; }
            set { companyIDs = value; }
        }

        private List<System.Int32> assocMatterIDs = new List<System.Int32>();
        public List<System.Int32> AssocMatterIDs
        {
            get { return assocMatterIDs; }
            set { assocMatterIDs = value; }
        }

        private List<IDNameEntity> franchiseeIDs = new List<IDNameEntity>();
        public List<IDNameEntity> FranchiseeIDs
        {
            get { return franchiseeIDs; }
            set { franchiseeIDs = value; }
        }

        private List<MatterFilingDocEntity> docInfo;
        public List<MatterFilingDocEntity> DocInfo
        {
            get { return docInfo; }
            set { docInfo = value; }
        }

        private System.String isTariff;
        public System.String IsTariff
        {
            get { return isTariff; }
            set { isTariff = value; }
        }

        private System.String etsNum;
        public System.String EtsNum
        {
            get { return etsNum; }
            set { etsNum = value; }
        }

        private System.String tariffNum;
        public System.String TariffNum
        {
            get { return tariffNum; }
            set { tariffNum = value; }
        }

        private System.String tariffTitle;
        public System.String TariffTitle
        {
            get { return tariffTitle; }
            set { tariffTitle = value; }
        }
        private System.String filingPurpose;
        public System.String FilingPurpose
        {
            get { return filingPurpose; }
            set { filingPurpose = value; }
        }

        private System.String revisionDetails;
        public System.String RevisionDetails
        {
            get { return revisionDetails; }
            set { revisionDetails = value; }
        }

        private System.DateTime issueDate;
        public System.DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        private System.DateTime reqdEffDate;
        public System.DateTime ReqdEffDate
        {
            get { return reqdEffDate; }
            set { reqdEffDate = value; }
        }

        private List<System.Int32> relatedMatterIDs = new List<System.Int32>();
        public List<System.Int32> RelatedMatterIDs
        {
            get { return relatedMatterIDs; }
            set { relatedMatterIDs = value; }
        }

        private List<System.Int32> filingCompanyIDs = new List<System.Int32>();
        public List<System.Int32> FilingCompanyIDs
        {
            get { return filingCompanyIDs; }
            set { filingCompanyIDs = value; }
        }

        private List<System.Int32> prevFilingNum = new List<System.Int32>();
        public List<System.Int32> PrevFilingNum
        {
            get { return prevFilingNum; }
            set { prevFilingNum = value; }
        }

        private System.String comments;
        public System.String Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        private System.String autoClose;
        public System.String AutoClose
        {
            get { return autoClose; }
            set { autoClose = value; }
        }

        private System.String county;
        public System.String County
        {
            get { return county; }
            set { county = value; }
        }

        private System.String municipality;
        public System.String Municipality
        {
            get { return municipality; }
            set { municipality = value; }
        }

        private System.String industryInitial;
        public System.String IndustryInitial
        {
            get { return industryInitial; }
            set { industryInitial = value; }
        }

        private System.Int32 filingSeq;
        public System.Int32 FilingSeq
        {
            get { return filingSeq; }
            set { filingSeq = value; }
        }

        private System.DateTime startDate;
        public System.DateTime StartDate
        {
            set { startDate = value; }
            get { return startDate; }
        }

        private System.Int16 noFiling;
        public System.Int16 NoFiling
        {
            get { return noFiling; }
            set { noFiling = value; }
        }

        //@@@@ Start: For Compliance
        private System.String complianceFiling;
        public System.String ComplianceFiling
        {
            get { return complianceFiling; }
            set { complianceFiling = value; }
        }
        //@@@@ End: For Compliance

        //@@@@ Start: For DOC RETENTION
        private System.Int32 retentionPeriod;
        public System.Int32 RetentionPeriod
        {
            get { return retentionPeriod; }
            set { retentionPeriod = value; }
        }
        //@@@@ End: For DOC RETENTION

        //@@@@ Start: For Contract Utility
        private System.String contractNumber;
        public System.String ContractNumber
        {
            get { return contractNumber; }
            set { contractNumber = value; }
        }
        private System.String supplementNumber;
        public System.String SupplementNumber
        {
            get { return supplementNumber; }
            set { supplementNumber = value; }
        }
        private System.String contractStatus;
        public System.String ContractStatus
        {
            get { return contractStatus; }
            set { contractStatus = value; }
        }
        private System.DateTime contractEffectiveDate;
        public System.DateTime ContractEffectiveDate
        {
            get { return contractEffectiveDate; }
            set { contractEffectiveDate = value; }
        }
        private System.DateTime cancelledEndingDate;
        public System.DateTime CancelledEndingDate
        {
            get { return cancelledEndingDate; }
            set { cancelledEndingDate = value; }
        }
        private IDNameEntity utilityCompany;
        public IDNameEntity UtilityCompany
        {
            get { return utilityCompany; }
            set { utilityCompany = value; }
        }
        private System.String commentsContract;
        public System.String CommentsContract
        {
            get { return commentsContract; }
            set { commentsContract = value; }
        }
        private System.String contractType;
        public System.String ContractType
        {
            get { return contractType; }
            set { contractType = value; }
        }
        private System.String isContract;
        public System.String IsContract
        {
            get { return isContract; }
            set { isContract = value; }
        }
        //@@@@ End: For Contract Utility
        private List<ReferenceEntity> referenceInfo;
        public List<ReferenceEntity> ReferenceInfo
        {
            get { if (referenceInfo == null) { referenceInfo = new List<ReferenceEntity>(); } return referenceInfo; }
            set { referenceInfo = value; }
        }
        private IDNameEntity industrySubtype = new IDNameEntity();
        public IDNameEntity IndustrySubtype
        {
            get { return industrySubtype; }
            set { industrySubtype = value; }
        }
        private System.String isRepSelf;
        public System.String IsRepSelf
        {
            get { return isRepSelf; }
            set { isRepSelf = value; }
        }
        private System.String companyNameIDs;
        public System.String CompanyNameIDs
        {
            get { return companyNameIDs; }
            set { companyNameIDs = value; }
        }

        private System.String filingPartyNameIDs;
        public System.String FilingPartyNameIDs
        {
            get { return filingPartyNameIDs; }
            set { filingPartyNameIDs = value; }
        }

        private System.String isSecured;
        public System.String IsSecured
        {
            get { return isSecured; }
            set { isSecured = value; }
        }

        private System.String isAdjudicatory;
        public System.String IsAdjudicatory
        {
            get { return isAdjudicatory; }
            set { isAdjudicatory = value; }
        }
    }
}

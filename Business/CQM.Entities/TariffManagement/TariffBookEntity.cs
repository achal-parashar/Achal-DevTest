//---------------------------------------------------------------------
// Author: Rajani Gandha Patra
// Version: 1.0.0
// Date: 08/05/2011
// Description:TariffBookEntity Class
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
    /// This entity class stores the information about TariffBook property of any Entity specified.
    /// </summary>
    /// <author>Rajani Patra</author>
    /// <creationDate>2011-08-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class TariffBookEntity
    {
        private System.String trfBookID;
        public System.String TrfBookID
        {
            get { return trfBookID; }
            set { trfBookID = value; }
        }
        private System.String industryType;
        public System.String IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        private System.String industryTypeName;
        public System.String IndustryTypeName
        {
            get { return industryTypeName; }
            set { industryTypeName = value; }
        }
        private System.String industrySubType;
        public System.String IndustrySubType
        {
            get { return industrySubType; }
            set { industrySubType = value; }
        }
        private System.String industrySubTypeName;
        public System.String IndustrySubTypeName
        {
            get { return industrySubTypeName; }
            set { industrySubTypeName = value; }
        }
        private System.String companySeq;
        public System.String CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }
        private System.String companyName;
        public System.String CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private System.String filedById;
        public System.String FiledById
        {
            get { return filedById; }
            set { filedById = value; }
        }
        private System.String trfType;
        public System.String TrfType
        {
            get { return trfType; }
            set { trfType = value; }
        }
        private System.String rateSectionName;
        public System.String RateSectionName
        {
            get { return rateSectionName; }
            set { rateSectionName = value; }
        }
        private System.String caseSeq;
        public System.String CaseSeq
        {
            get { return caseSeq; }
            set { caseSeq = value; }
        }      
        private System.String expTariffChange;
        public System.String ExpTariffChange
        {
            get { return expTariffChange; }
            set { expTariffChange = value; }
        }
        private System.String rateSecDesc;
        public System.String RateSecDesc
        {
            get { return rateSecDesc; }
            set { rateSecDesc = value; }
        }
        private System.String createdDate;
        public System.String CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        private System.String trfDtlStatus;
        public System.String TrfDtlStatus
        {
            get { return trfDtlStatus; }
            set { trfDtlStatus = value; }
        }
        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        private List<TariffSubmissionAttachmentEntity> attachmentInfo = new List<TariffSubmissionAttachmentEntity>();
        public List<TariffSubmissionAttachmentEntity> AttachmentInfo
        {
            get { return attachmentInfo; }
            set { attachmentInfo = value; }
        }
        //Added to show the Industry , Industry Subtype , Company name        
        private System.String lastRevisedDate;
        public System.String LastRevisedDate
        {
            get { return lastRevisedDate; }
            set { lastRevisedDate = value; }
        }
        private System.String cancelDate;
        public System.String CancelDate
        {
            get { return cancelDate; }
            set { cancelDate = value; }
        }
        private System.String effectiveDate;
        public System.String EffectiveDate
        {
            get { return effectiveDate; }
            set { effectiveDate = value; }
        }
    }
}

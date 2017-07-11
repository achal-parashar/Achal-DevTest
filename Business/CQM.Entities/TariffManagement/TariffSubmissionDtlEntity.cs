//---------------------------------------------------------------------
// Author: Rajani Gandha Patra
// Version: 1.0.0
// Date: 08/05/2011
// Description:TariffSubmissionDtlEntity Class
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about TariffSubmissionDtlEntity  property of any Entity specified.
    /// </summary>
    /// <author>Rajani Patra</author>
    /// <creationDate>2011-08-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class TariffSubmissionDtlEntity
    {
        private System.String trfBookID;
        public System.String TrfBookID
        {
            get { return trfBookID; }
            set { trfBookID = value; }
        }
        private System.String trfSubmissionNumber;
        public System.String TrfSubmissionNumber
        {
            get { return trfSubmissionNumber; }
            set { trfSubmissionNumber = value; }
        }
        private System.Decimal trfsubmissiondtlid;
        public System.Decimal TrfSubmissionDtlId
        {
            get { return trfsubmissiondtlid; }
            set { trfsubmissiondtlid = value; }
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
        private System.DateTime effDate;
        public System.DateTime EffDate
        {
            get { return effDate; }
            set { effDate = value; }
        }
        private System.String trfSubDtlStatus;
        public System.String TrfSubDtlStatus
        {
            get { return trfSubDtlStatus; }
            set { trfSubDtlStatus = value; }
        }
        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        private System.Char isScanned;
        public System.Char IsScanned
        {
            get { return isScanned; }
            set { isScanned = value; }
        }
        private System.String guidno;
        public System.String GUIDno
        {
            get { return guidno; }
            set { guidno = value; }
        }
        private System.Decimal totalRecords;
        public System.Decimal TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String attachment;
        public System.String Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }
        private System.String property1;
        public System.String Property1
        {
            get { return property1; }
            set { property1 = value; }
        }
        private System.String property2;
        public System.String Property2
        {
            get { return property2; }
            set { property2 = value; }
        }
        
        private List<TariffSubmissionAttachmentEntity> attachmentInfo = new List<TariffSubmissionAttachmentEntity>();
        public List<TariffSubmissionAttachmentEntity> AttachmentInfo
        {
            get { return attachmentInfo; }
            set { attachmentInfo = value; }
        }       
        private System.Decimal totalAttachmentSizeAttached;
        public System.Decimal TotalAttachmentSizeAttached
        {
            get { return totalAttachmentSizeAttached; }
            set { totalAttachmentSizeAttached = value; }
        }

    }
}

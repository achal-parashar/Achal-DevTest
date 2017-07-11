//---------------------------------------------------------------------
// Author: Amarendra
// Version: 1.0.0
// Date: 11/01/2011
// Description:Implement Annual Report Assessment Submission Properties
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Annual Report Assessment Submission.
    /// </summary>
    /// <author>Amarendra</author>
    /// <creationDate>2011-11-01</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class AssessmentSubmissionEntity
    {
        private decimal? annualRevenueSubToAssessment;
        public decimal? AnnualRevenueSubToAssessment
        {
            get { return Common.Utility.Common.Round(annualRevenueSubToAssessment); }
            set { annualRevenueSubToAssessment = value; }
        }
        private string comments;
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        private string personCompletingAnnualReport;
        public string PersonCompletingAnnualReport
        {
            get { return personCompletingAnnualReport; }
            set { personCompletingAnnualReport = value; }
        }

        private int companySeq;
        public int CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }

        private string reportYear;
        public string ReportYear
        {
            get { return reportYear; }
            set { reportYear = value; }
        }

        private string reportTypeCode;
        public string ReportTypeCode
        {
            get { return reportTypeCode; }
            set { reportTypeCode = value; }
        }

        private string industrySubTypeCode;
        public string IndustrySubTypeCode
        {
            get { return industrySubTypeCode; }
            set { industrySubTypeCode = value; }
        }

        private string industryTypeCode;
        public string IndustryTypeCode
        {
            get { return industryTypeCode; }
            set { industryTypeCode = value; }
        }

        private string docketNumber;
        public string DocketNumber
        {
            get { return docketNumber; }
            set { docketNumber = value; }
        }
        private string isCompany;
        public string IsCompany
        {
            get { return isCompany; }
            set { isCompany = value; }
        }
        private string trackingNumber;
        public string TrackingNumber
        {
            get { return trackingNumber; }
            set { trackingNumber = value; }
        }
        private int personCompletingARSeq;
        public int PersonCompletingARSeq
        {
            get { return personCompletingARSeq; }
            set { personCompletingARSeq = value; }
        }
        private string filedExternally;
        public string FiledExternally
        {
            get { return filedExternally; }
            set { filedExternally = value; }
        }
        private string createdBy;
        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private string updatedBy;
        public string UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private DateTime updatedDate;
        public DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }
        private string isDeleted;
        public string IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        private string billingContactname;
        public string BillingContactname
        {
            get { return billingContactname; }
            set { billingContactname = value; }

        }

        private string billingAddress;
        public string BillingAddress
        {
            get { return billingAddress; }
            set { billingAddress = value; }

        }

        private string billingAddresscont;
        public string BillingAddresscont
        {
            get { return billingAddresscont; }
            set { billingAddresscont = value; }

        }

        private string billingcity;
        public string BillingCity
        {
            get { return billingcity; }
            set { billingcity = value; }

        }

        private string billingState;
        public string BillingState
        {
            get { return billingState; }
            set { billingState = value; }

        }

        private string billingStateCode;
        public string BillingStateCode
        {
            get { return billingStateCode; }
            set { billingStateCode = value; }

        }

        private string billingZip;
        public string BillingZip
        {
            get { return billingZip; }
            set { billingZip = value; }

        }

        private System.String billingZip1;
        public System.String BillingZip1
        {
            get { return billingZip1; }
            set { billingZip1 = value; }
        }

        private System.String billingZip2;
        public System.String BillingZip2
        {
            get { return billingZip2; }
            set { billingZip2 = value; }
        }

        private System.Decimal totalRecords;
        public System.Decimal TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String regContactName;
        public System.String RegContactName
        {
            get { return regContactName; }
            set { regContactName = value; }
        }


        private System.String regContactEmail;
        public System.String RegContactEmail
        {
            get { return regContactEmail; }
            set { regContactEmail = value; }
        }

        private System.String mailingAddress;
        public System.String MailingAddress
        {
            get { return mailingAddress; }
            set { mailingAddress = value; }
        }

        private System.String mailingAddressCont;
        public System.String MailingAddressCont
        {
            get { return mailingAddressCont; }
            set { mailingAddressCont = value; }
        }

        private System.String city;
        public System.String City
        {
            get { return city; }
            set { city = value; }
        }

        private System.String state;
        public System.String State
        {
            get { return state; }
            set { state = value; }
        }

        private System.String zipCode1;
        public System.String ZipCode1
        {
            get { return zipCode1; }
            set { zipCode1 = value; }
        }

        private System.String zipCode2;
        public System.String ZipCode2
        {
            get { return zipCode2; }
            set { zipCode2 = value; }
        }

        private System.String zipCode;
        public System.String ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        private System.String industryType;
        public System.String IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        private System.String industrySubTypeDesc;
        public System.String IndustrySubTypeDesc
        {
            get { return industrySubTypeDesc; }
            set { industrySubTypeDesc = value; }
        }
        private System.String companyOrgName;
        public System.String CompanyOrgName
        {
            get { return companyOrgName; }
            set { companyOrgName = value; }
        }

    }
}

//---------------------------------------------------------------------
// Author: Ajeet Kumar
// Version: 1.0.0
// Date: 10/22/2007
// Description: Utility Company Master Entity
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
    /// This entity class stores the information about Company.
    /// </summary>
    /// <author>Ajeet Kumar</author>
    /// <creationDate>2007-10-22</ceationDate>
    /// <modifications>
    /// <item>2007-01-28;Ajeet Kumar;Added new Properties</item>
    /// <item></item>
    /// </modifications>
    /// 
       
    public class CompanyEntity
    {
        private List<IDNameEntity> industryEntityList = new List<IDNameEntity>();
        public List<IDNameEntity> IndustryEntityList
        {
            get { return industryEntityList; }
            set { industryEntityList = value; }
        }

        private System.String city;
        public System.String City
        {
            get { return city; }
            set { city = value; }
        }

        private System.String companyKnownName;
        public System.String CompanyKnownName
        {
            get { return companyKnownName; }
            set { companyKnownName = value; }
        }

        private System.String companyNumber;
        public System.String CompanyNumber
        {
            get { return companyNumber; }
            set { companyNumber = value; }
        }

        private System.String companyOrgName;
        public System.String CompanyOrgName
        {
            get { return companyOrgName; }
            set { companyOrgName = value; }
        }

        private System.Decimal companySeq;
        public System.Decimal CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }

        private System.String companyShortName;
        public System.String CompanyShortName
        {
            get { return companyShortName; }
            set { companyShortName = value; }
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

        private System.String emailId;
        public System.String EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        private System.String extn;
        public System.String Extn
        {
            get { return extn; }
            set { extn = value; }
        }

        private System.String faxNo;
        public System.String FaxNo
        {
            get { return faxNo; }
            set { faxNo = value; }
        }


        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        private System.String phoneNo;
        public System.String PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private System.String state;
        public System.String State
        {
            get { return state; }
            set { state = value; }
        }

        private System.String streetAddress;
        public System.String StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        private System.String tollFreeNo;
        public System.String TollFreeNo
        {
            get { return tollFreeNo; }
            set { tollFreeNo = value; }
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

        private System.String webUrl;
        public System.String WebUrl
        {
            get { return webUrl; }
            set { webUrl = value; }
        }

        private System.String zipCode;
        public System.String ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        //Start Additional
        private System.String industrySeq;
        public System.String IndustrySeq
        {
            get { return industrySeq; }
            set { industrySeq = value; }
        }
        private System.String industryType;
        public System.String IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        //End Additional

        //Start AR integration
        private System.String stateDesc;
        public System.String StateDesc
        {
            get { return stateDesc; }
            set { stateDesc = value; }
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
        private System.String billingContactname;
        public System.String BillingContactname
        {
            get { return billingContactname; }
            set { billingContactname = value; }
        }

        private System.String billingAddress;
        public System.String BillingAddress
        {
            get { return billingAddress; }
            set { billingAddress = value; }
        }

        private System.String billingAddressCont;
        public System.String BillingAddressCont
        {
            get { return billingAddressCont; }
            set { billingAddressCont = value; }
        }

        private System.String billingEmailID;
        public System.String BillingEmailID
        {
            get { return billingEmailID; }
            set { billingEmailID = value; }
        }

        private System.String billingCity;
        public System.String BillingCity
        {
            get { return billingCity; }
            set { billingCity = value; }
        }

        private System.String billingState;
        public System.String BillingState
        {
            get { return billingState; }
            set { billingState = value; }
        }

        private System.String billingZip;
        public System.String BillingZip
        {
            get { return billingZip; }
            set { billingZip = value; }
        }


        private System.String regContactName;
        public System.String RegContactName
        {
            get { return regContactName; }
            set { regContactName = value; }
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
        //End AR integration

        private System.String industryTypeCode;
        public System.String IndustryTypeCode
        {
            get { return industryTypeCode; }
            set { industryTypeCode = value; }
        }
        private System.String industrySubTypeCode;
        public System.String IndustrySubTypeCode
        {
            get { return industrySubTypeCode; }
            set { industrySubTypeCode = value; }
        }
        private System.String industrySubType;
        public System.String IndustrySubType
        {
            get { return industrySubType; }
            set { industrySubType = value; }
        }
        private System.String companyOrgCode;
        public System.String CompanyOrgCode
        {
            get { return companyOrgCode; }
            set { companyOrgCode = value; }
        }

        private System.String isActive;
        public System.String IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        private System.Int32 pageSize;
        public System.Int32 PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
        private System.Int32 pageNumber;
        public System.Int32 PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }

        private System.Int32 totalCount;
        public System.Int32 TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }

        private System.String cADContactName;
        public System.String CADContactName
        {
            get { return cADContactName; }
            set { cADContactName = value; }
        }

        private System.String cADContactEmailID;
        public System.String CADContactEmailID
        {
            get { return cADContactEmailID; }
            set { cADContactEmailID = value; }
        }
    }

}
//---------------------------------------------------------------------
// Author: Yugal Kishore  
// Version: 1.0.0
// Date: 10/June/2011
// Description: Intake Form Entity
//
// History:
// Changed By          
// Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Intake Specialist Form.
    /// </summary>
    /// <author>Yugal Kishore</author>
    /// <creationDate>2011-10-June</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
   public class IntakeFormEntity
    {
        private System.Decimal caseSeq;
        public System.Decimal CaseSeq
        {
            get { return caseSeq; }
            set { caseSeq = value; }
        }
        private System.String trackingNumber;
        public System.String TrackingNumber
        {
            get { return trackingNumber; }
            set { trackingNumber = value; }
        }

        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.Int32 casetypeseq;
        public System.Int32 CaseTypeSeq
        {
            get { return casetypeseq; }
            set { casetypeseq = value; }
        }
        private System.String businessName;
        public System.String BusinessName
        {
            get { return businessName; }
            set { businessName = value; }
        }       
       
       private System.String dba;
       public System.String DBA
        {
            get { return dba; }
            set { dba = value; }
        }
        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }
       
        private System.String isServiceAddress;
        public System.String IsServiceAddress
        {
            get { return isServiceAddress; }
            set { isServiceAddress = value; }
        }

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
        private System.String industrySubtypeSeq;
        public System.String IndustrySubtypeSeq
        {
            get { return industrySubtypeSeq; }
            set { industrySubtypeSeq = value; }
        }
        private System.String industrySubtype;
        public System.String IndustrySubtype
        {
            get { return industrySubtype; }
            set { industrySubtype = value; }
        }
        private System.Int32 companySeq;
        public System.Int32 CompanySeq
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
       
        private System.String accountnumber;
        public System.String AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }
                 
        private System.String propertyextn1;
        public System.String PropertyExtn1
        {
            get { return propertyextn1; }
            set { propertyextn1 = value; }
        }
        private System.String propertyextn2;
        public System.String PropertyExtn2
        {
            get { return propertyextn2; }
            set { propertyextn2 = value; }
        }
        private System.String hasContactedUtility;
        public System.String HasContactedUtility
        {
            get { return hasContactedUtility; }
            set { hasContactedUtility = value; }
        }

        private System.String dateOfContact;
        public System.String DateOfContact
        {
            get { return dateOfContact; }
            set { dateOfContact = value; }
        }
        private System.String issueSeq;
        public System.String IssueSeq
        {
            get { return issueSeq; }
            set { issueSeq = value; }
        }

        private System.String isUtilitySubscriber;
        public System.String IsUtilitySubscriber
        {
            get { return isUtilitySubscriber; }
            set { isUtilitySubscriber = value; }
        }

        private System.String complaintDetail;
        public System.String ComplaintDetail
        {
            get { return complaintDetail; }
            set { complaintDetail = value; }
        }

        private System.String whatCusomerWant;
        public System.String WhatCusomerWant
        {
            get { return whatCusomerWant; }
            set { whatCusomerWant = value; }
        } 
 
        private System.Int32 isdeleted;
        public System.Int32 IsDeleted
        {
            get { return isdeleted; }
            set { isdeleted = value; }
        }

        private System.String createdby;
        public System.String CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private System.DateTime createddate;
        public System.DateTime CreatedDate
        {
            get { return createddate; }
            set { createddate = value; }
        }
        private System.String updatedby;
        public System.String UpdatedBy
        {
            get { return updatedby; }
            set { updatedby = value; }
        }

        private System.DateTime updateddate;
        public System.DateTime UpdateDate
        {
            get { return updateddate; }
            set { updateddate = value; }
        }

        private List<CadFilingDocEntity> docInfo = new List<CadFilingDocEntity>();
        public List<CadFilingDocEntity> DocInfo
        {
            get { return docInfo; }
            set { docInfo = value; }
        }
        private ContactDetailEntity contactInfo = new ContactDetailEntity();
        public ContactDetailEntity ContactInfo
        {
            get 
            { 
                return contactInfo; 
            }
            set 
            { 
                if (contactInfo == null) 
                    contactInfo = new ContactDetailEntity(); 
                else 
                    contactInfo = value; 
            }
        }

        private List<CrammingDetailEntity> crammingInfo = new List<CrammingDetailEntity>();
        public List<CrammingDetailEntity> CrammingInfo
        {
            get
            {
                return crammingInfo;
            }
            set
            {               
               crammingInfo = value;
            }
        }
        private System.String isBusiness;
        public System.String IsBusiness
        {
            get { return isBusiness; }
            set { isBusiness = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String caseType;
        public System.String CaseType
        {
            get { return caseType; }
            set { caseType = value; }
        }
        private System.Decimal trackingSeq;
        public System.Decimal TrackingSeq
        {
            get { return trackingSeq; }
            set { trackingSeq = value; }
        }
        private CrammingDetailEntity crammingDetail = new CrammingDetailEntity();
        public CrammingDetailEntity CrammingDetail
        {
            get
            {
                return crammingDetail;
            }
            set
            {
                crammingDetail = value;
            }
        }

        private System.Decimal userSeq;
        public System.Decimal UserSeq
        {
            get { return userSeq; }
            set { userSeq = value; }
        }

        private System.Decimal roleSeq;
        public System.Decimal RoleSeq
        {
            get { return roleSeq; }
            set { roleSeq = value; }
        }

        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }

        private System.String isAssigned;
        public System.String IsAssigned
        {
            get { return isAssigned; }
            set { isAssigned = value; }
        }

        private System.String caseTypeInitial;
        public System.String CaseTypeInitial
        {
            get { return caseTypeInitial; }
            set { caseTypeInitial = value; }
        }

        private System.String isviolation;
        public System.String IsViolation
        {
            get { return isviolation; }
            set { isviolation = value; }
        }

        private System.String violationComplete;
        public System.String ViolationComplete
        {
            get { return violationComplete; }
            set { violationComplete = value; }
        }
    }
}

//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/22/2007
// Description: Contact Entity
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

namespace CQM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This entity class stores the information about Contact Entity
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-11-22</ceationDate>
    /// <modifications>
    /// <item>2008-02-02;Ritika Fakay;Added comments</item>
    /// <item></item>
    /// </modifications>
    
    public class ContactMFEntity
    {
        private System.String company;
        public System.String Company
        {
            get { return company; }
            set { company = value; }
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

        private System.String fName;
        public System.String FName
        {
            get { return fName; }
            set { fName = value; }
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

        private System.String lName;
        public System.String LName
        {
            get { return lName; }
            set { lName = value; }
        }

        private System.DateTime lastLoginDate;
        public System.DateTime LastLoginDate
        {
            get { return lastLoginDate; }
            set { lastLoginDate = value; }
        }

        private System.String mName;
        public System.String MName
        {
            get { return mName; }
            set { mName = value; }
        }

        private System.Decimal memberSeq;
        public System.Decimal MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }

        private System.String contactCode;
        public System.String ContactCode
        {
            get { return contactCode; }
            set { contactCode = value; }
        }

        private System.String phoneNo;
        public System.String PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private System.String prefContactMethod;
        public System.String PrefContactMethod
        {
            get { return prefContactMethod; }
            set { prefContactMethod = value; }
        }

        private System.String prefix;
        public System.String Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        private System.String suffix;
        public System.String Suffix
        {
            get { return suffix; }
            set { suffix = value; }
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

        private System.Decimal addressSeq;
        public System.Decimal AddressSeq
        {
            get { return addressSeq; }
            set { addressSeq = value; }
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

        private System.String streetAddress;
        public System.String StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        private System.String zipCode;
        public System.String ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private System.String zipCodeContn;
        public System.String ZipCodeContn
        {
            get { return zipCodeContn; }
            set { zipCodeContn = value; }
        }

        private System.String title;
        public System.String Title
        {
            get { return title; }
            set { title = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String matterCaseNumber;
        public System.String MatterCaseNumber
        {
            get { return matterCaseNumber; }
            set { matterCaseNumber = value; }
        }

        private System.String mailingListName;
        public System.String MailingListName
        {
            get { return mailingListName; }
            set { mailingListName = value; }
        }

        private System.String country;
        public System.String Country
        {
            get { return country; }
            set { country = value; }
        }

        private System.String interagency;
        public System.String Interagency
        {
            get { return interagency; }
            set { interagency = value; }
        }

        //@@@@ start for Admin custom user 
        private System.String userID;
        public System.String UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private System.String userPassword;
        public System.String UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        private System.Boolean passwordFlag;
        public System.Boolean PasswordFlag
        {
            get { return passwordFlag; }
            set { passwordFlag = value; }
        }

        private System.String representingCompanies;
        public System.String RepresentingCompanies
        {
            get { return representingCompanies; }
            set { representingCompanies = value; }
        }

        private System.Boolean eFiler;
        public System.Boolean EFiler
        {
            get { return eFiler; }
            set { eFiler = value; }
        }

        //@@@@ end for Admin custom user 
        //^^^^Start: For ESCO
        private System.String addEditRateInformation;
        public System.String AddEditRateInformation
        {
            get { return addEditRateInformation; }
            set { addEditRateInformation = value; }
        }

        private System.Boolean saveContact;
        public System.Boolean SaveContact
        {
            get { return saveContact; }
            set { saveContact = value; }
        }

        private System.String escoRepresentingCompanies;
        public System.String ESCORepresentingCompanies
        {
            get { return escoRepresentingCompanies; }
            set { escoRepresentingCompanies = value; }
        }        
        //^^^^End: For ESCO

        //Start for CAD on 1st March 2011
        private System.String address;
        public System.String Address
        {
            get { return address; }
            set { address = value; }
        }

        private System.String addressCont;
        public System.String AddressCont
        {
            get { return addressCont; }
            set { addressCont = value; }
        }

        private System.String businessName;
        public System.String BusinessName
        {
            get { return businessName; }
            set { businessName = value; }
        }
        private System.String utilityType;
        public System.String UtilityType
        {
            get { return utilityType; }
            set { utilityType = value; }
        }
        private System.String utilitySubtype;
        public System.String UtilitySubtype
        {
            get { return utilitySubtype; }
            set { utilitySubtype = value; }
        }
        private System.String caseType;
        public System.String CaseType
        {
            get { return caseType; }
            set { caseType = value; }
        }
        private System.String caseSubtype;
        public System.String CaseSubtype
        {
            get { return caseSubtype; }
            set { caseSubtype = value; }
        }
        //End: For CAD 
    }
}

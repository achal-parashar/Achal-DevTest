//---------------------------------------------------------------------
// Author: Jatin Maradia
// Version: 1.0.0
// Date: 01/25/2008
// Description: Represents a Contact List Member object.
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

namespace CQM.Entities
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    /// <summary>
    /// Represents a ContactListEntity object.
    /// </summary>
    /// <author>Jatin Maradia</author>
    /// <creationDate>2008-01-25</ceationDate>
    /// <modifications>
    /// <item>Date ;By ;Description</item>
    /// <item>Date ;By ;Description</item>
    /// </modifications>
    public class ContactListEntity
    {
        private System.String firstName;
        public System.String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private System.String middleName;
        public System.String MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        private System.String lastName;
        public System.String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private System.String prefix;
        public System.String Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        private System.String sufix;
        public System.String Sufix
        {
            get { return sufix; }
            set { sufix = value; }
        }

        private System.String streetAddress;
        public System.String StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
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

        private System.String zipCode;
        public System.String ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private System.String phoneNo;
        public System.String PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private System.String extn;
        public System.String Extn
        {
            get { return extn; }
            set { extn = value; }
        }

        private System.String emailId;
        public System.String EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        private System.String faxNo;
        public System.String FaxNo
        {
            get { return faxNo; }
            set { faxNo = value; }
        }

        private System.String company;
        public System.String Company
        {
            get { return company; }
            set { company = value; }
        }

        private MatterContactRoleEntity role = new MatterContactRoleEntity();
        public MatterContactRoleEntity Role
        {
            get { return role; }
            set { role = value; }
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

        private System.Int32 matterSeq;
        public System.Int32 MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
        }

        private System.String prefContact;
        public System.String PrefContact
        {
            get { return prefContact; }
            set { prefContact = value; }
        }

        private System.Int32 isActivePartyMember;
        public System.Int32 IsActivePartyMember
        {
            get { return isActivePartyMember; }
            set { isActivePartyMember = value; }
        }

        private System.Int32 isServiceListMember;
        public System.Int32 IsServiceListMember
        {
            get { return isServiceListMember; }
            set { isServiceListMember = value; }
        }

        private List<IDNameEntity> representingCompany;
        public List<IDNameEntity> RepresentingCompany
        {
            get { return representingCompany; }
            set { representingCompany = value; }
        }

        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }     

        private System.Int32 mlistSeq;
        public System.Int32 MlistSeq
        {
            get { return mlistSeq; }
            set { mlistSeq = value; }
        }

        private System.Int32 importMlistSeq;
        public System.Int32 ImportMlistSeq
        {
            get { return importMlistSeq; }
            set { importMlistSeq = value; }
        }

        private System.String memberSeqList;
        public System.String MemberSeqList
        {
            get { return memberSeqList; }
            set { memberSeqList = value; }
        }

        private System.String memberStatusList;
        public System.String MemberStatusList
        {
            get { return memberStatusList; }
            set { memberStatusList = value; }
        }

        private System.String title;
        public System.String Title
        {
            get { return title; }
            set { title = value; }
        }
        private System.String created_by;
        public System.String Created_By
        {
            get { return created_by; }
            set { created_by = value; }
        }
        private System.DateTime created_date;
        public System.DateTime Created_Date
        {
            get { return created_date; }
            set { created_date = value; }
        }
        private System.String updated_by;
        public System.String Updated_By
        {
            get { return updated_by; }
            set { updated_by = value; }
        }
        private System.DateTime updated_date;
        public System.DateTime Updated_Date
        {
            get { return updated_date; }
            set { updated_date = value; }
        }
        //Added by Suruchi
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.String zipCodeContn;
        public System.String ZipCodeContn
        {
            get { return zipCodeContn; }
            set { zipCodeContn = value; }
        }
        private System.String mailAddressContn;
        public System.String MailAddressContn
        {
            get { return mailAddressContn; }
            set { mailAddressContn = value; }
        }
        private System.Int32 isSecuredServiceListMember;
        public System.Int32 IsSecuredServiceListMember
        {
            get { return isSecuredServiceListMember; }
            set { isSecuredServiceListMember = value; }
        }

        //added by Harita Munagala for Protective Order Access list
        private System.Int32 docSeq;
        public System.Int32 DocSeq
        {
            get { return docSeq; }
            set { docSeq = value; }
        }
    }
}

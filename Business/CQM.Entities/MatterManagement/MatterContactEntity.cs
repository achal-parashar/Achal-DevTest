//---------------------------------------------------------------------
// Author: Amitava Sinha
// Version: 1.0.0
// Date: 01/09/2008
// Description: This MatterContactEntity class stores the information about Matter Contact List.
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
namespace CQM.Entities
{
    /// <summary>
    /// This MatterContactEntity class stores the information about Matter Contact List.
    /// </summary>
    /// <author>Amitava Sinha</author>
    /// <creationDate>2008-09-01</ceationDate>
    /// <modifications>
    /// <item>2008-09-01;Amitava Sinha;Added new Functions</item>
    /// <item>Date;By;Description</item>
    /// </modifications>
    /// 
    public class MatterContactEntity
    {
        private System.String nameofPerson;
        public System.String NameofPerson
        {
            get { return nameofPerson; }
            set { nameofPerson = value; }
        }
        private System.String repCompany;
        public System.String RepCompany
        {
            get { return repCompany; }
            set { repCompany = value; }
        }
        private System.String mailingAddress;
        public System.String MailingAddress
        {
            get { return mailingAddress; }
            set { mailingAddress = value; }
        }
        private System.String emailID;
        public System.String EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }
        private System.String phone;
        public System.String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private System.String fax;
        public System.String Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        private System.String role;
        public System.String Role
        {
            get { return role; }
            set { role = value; }
        }
        private System.String emailIDPhone;
        public System.String EmailIDPhone
        {
            get { return emailIDPhone; }
            set { emailIDPhone = value; }
        }
        private System.Int32 recordSeq;
        public System.Int32 RecordSeq
        {
            get { return recordSeq; }
            set { recordSeq = value; }
        }
        private System.Int32 mListSeq;
        public System.Int32 MListSeq
        {
            get { return mListSeq; }
            set { mListSeq = value; }
        }
        private System.String mListName;
        public System.String MListName
        {
            get { return mListName; }
            set { mListName = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String edit;
        public System.String Edit
        {
            get { return edit; }
            set { edit = value; }
        }

        private System.String delete;
        public System.String Delete
        {
            get { return delete; }
            set { delete = value; }
        }
        private System.Int16 isActivePartyMember;
        public System.Int16 IsActivePartyMember
        {
            get { return isActivePartyMember; }
            set { isActivePartyMember = value; }
        }
        //Added By Sunayana DEFW264 26 august 2014

        private System.String companyOrgName;
        public System.String CompanyOrgname
        {
            get { return companyOrgName; }
            set { companyOrgName = value; }
        }

        private System.Int32 docSeq;
        public System.Int32 DocSeq
        {
            get { return docSeq; }
            set { docSeq = value; }
        }
        //End - Added By Sunayana DEFW264 26 august 2014

    }
}

//---------------------------------------------------------------------
// Date: 06/02/2009
// Author:Deepak Kumar Singh
// Version: 1.0.0
// Description:  This entity class stores the information about MemberEntity.

// History:
// Changed By                           Changed On   
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Member.
    /// </summary>
    /// <author>Deepak Kumar Singh</author>
    /// <creationDate>2009-06-02</ceationDate>
    /// <modifications>
    /// <item></item>
    /// </modifications>

    public class MemberEntity
    {
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

        private System.Int32 userSeq;
        public System.Int32 UserSeq
        {
            get { return userSeq; }
            set { userSeq = value; }
        }
       
        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }
        private System.String firstName;
        public System.String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private System.String midleName;
        public System.String MidleName
        {
            get { return midleName; }
            set { midleName = value; }
        }
        private System.String lastName;
        public System.String LastName
        {
            get { return lastName; }
            set { lastName = value; }
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

        private System.String emailId;
        public System.String EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        private System.String state;
        public System.String State
        {
            get { return state; }
            set { state = value; }
        }
        private System.Int32 stateSeq;
        public System.Int32 StateSeq
        {
            get { return stateSeq; }
            set { stateSeq = value; }
        }
        private System.String suffix;
        public System.String Suffix
        {
            get { return suffix; }
            set { suffix = value; }
        }
        private System.String prefix;
        public System.String Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }
        private System.String userId;
        public System.String UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private System.String company;
        public System.String Company
        {
            get { return company; }
            set { company = value; }
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
        private System.String title;
        public System.String Title
        {
            get { return title; }
            set { title = value; }
        }
        private System.String country;
        public System.String Country
        {
            get { return country; }
            set { country = value; }
        }
        private System.String memberName;
        public System.String MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }
        private System.String isConsent;
        public System.String IsConsent
        {
            get { return isConsent; }
            set { isConsent = value; }
        }

        private System.String representingCompanies;
        public System.String RepresentingCompanies
        {
            get { return representingCompanies; }
            set { representingCompanies = value; }
        }

        private System.String addressCont;
        public System.String AddressCont
        {
            get { return addressCont; }
            set { addressCont = value; }
        }

        private System.String userPassword;
        public System.String UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        private List<IDNameEntity> lstIDNameEntity;
        public List<IDNameEntity> LstIDNameEntity
        {
            get { if (lstIDNameEntity == null) lstIDNameEntity = new List<IDNameEntity>(); return lstIDNameEntity; }
            set { lstIDNameEntity = value; }
        }

        private System.String oldPassword;
        public System.String OldPassword
        {
            get { return oldPassword; }
            set { oldPassword = value; }
        }

        //added for AR
        private System.String zipCodeCont;
        /// <summary>
        /// Hold Zip Code extn
        /// </summary>
        /// <Item>Amarendra; 2012-01-17; Added</Item>
        public System.String ZipCodeCont
        {
            get { return zipCodeCont; }
            set { zipCodeCont = value; }
        }
        public void SetValues(System.Data.IDataReader dtReader)
        {
            string fieldName;
            try
            {
                if (dtReader != null)
                {
                    for (int index = 0; index <= dtReader.FieldCount - 1; index++)
                    {
                        if (!dtReader.IsDBNull(index))
                        {
                            fieldName = dtReader.GetName(index);
                            switch (fieldName)
                            {
                                case "CMPLNT_CNTCT_F_NME":
                                    FirstName = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_L_NME":
                                    LastName = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_M_NME":
                                    MidleName = Convert.ToString(dtReader[index]);
                                    break;
                                case"CMPLNT_CNTCT_SUFFIX":
                                    Suffix = Convert.ToString(dtReader[index]);
                                    break;
                                case "COMPANY":
                                    Company = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_ADDRESS":
                                    StreetAddress = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_ADDRESS_CONT":
                                    AddressCont = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_CITY":
                                    City = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_STATE":
                                    State = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_ZIP_CODE":
                                    ZipCode = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_PHONE_NO":
                                    PhoneNo = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_EXTN":
                                    Extn = Convert.ToString(dtReader[index]);
                                    break;
                                case "FAX_NO":
                                    FaxNo = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_EMAIL":
                                    EmailId = Convert.ToString(dtReader[index]);
                                    break;
                                case "CMPLNT_CNTCT_ZIP_CODE_CONT": //By Amarendra on 2012-01-17
                                    ZipCodeCont = Convert.ToString(dtReader[index]);
                                    break;
                            }
                        }
                    }
                }
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

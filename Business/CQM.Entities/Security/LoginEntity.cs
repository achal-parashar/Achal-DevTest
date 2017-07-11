using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    public class LoginEntity
    {
        private List<ProcessEntity> processEntityList = new List<ProcessEntity>();
        public List<ProcessEntity> ProcessEntityList
        {
            get { return processEntityList; }
            set { processEntityList = value; }
        }

        private List<ProcessActivityEntity> processActivityEntityList = new List<ProcessActivityEntity>();
        public List<ProcessActivityEntity> ProcessActivityEntityList
        {
            get { return processActivityEntityList; }
            set { processActivityEntityList = value; }
        }
        //Added And modified by mukesh k on 26 Dec 2007
        private List<ProcessEntity> processEntityList_Additional = new List<ProcessEntity>();
        public List<ProcessEntity> ProcessEntityList_Additional
        {
            get { return processEntityList_Additional; }
            set { processEntityList_Additional = value; }
        }
        //Added And modified by mukesh k on 26 Dec 2007
        private List<ProcessActivityEntity> processActivityEntityList_Additional = new List<ProcessActivityEntity>();
        public List<ProcessActivityEntity> ProcessActivityEntityList_Additional
        {
            get { return processActivityEntityList_Additional; }
            set { processActivityEntityList_Additional = value; }
        }

        private System.String userID;
        public System.String UserID
        {
            get { return userID; }
            set { userID = value; }
        }


        private System.String guid;
        public System.String Guid
        {
            get { return guid; }
            set { guid = value; }
        }


        private int roleId;
        public int RoleID
        {
            get { return roleId; }
            set { roleId = value; }
        }

        private System.String roleName;
        public System.String RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        private System.Decimal roleSeq;
        public System.Decimal RoleSeq
        {
            get { return roleSeq; }
            set { roleSeq = value; }
        }

        private System.String loginUserName;
        public System.String LoginUserName
        {
            get { return loginUserName; }
            set { loginUserName = value; }
        }

        private System.String emailID;
        public System.String EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }

        private System.String roleCode;
        public System.String RoleCode
        {
            get { return roleCode; }
            set { roleCode = value; }
        }

        private System.DateTime lastLoginDate;
        public System.DateTime LastLoginDate
        {
            get { return lastLoginDate; }
            set { lastLoginDate = value; }
        }

        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }

        //added for AR integration
        //Added by Amarendra
        private List<Int32> companyIdsList = new List<Int32>();
        public List<Int32> CompanyIdsList
        {
            get { return companyIdsList; }
            set { companyIdsList = value; }
        }
        private System.String userPassword;
        public System.String UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        private System.Int32 status;
        public System.Int32 Status
        {
            get { return status; }
            set { status = value; }
        }
        private System.String userType;
        public System.String UserType
        {
            get { return userType; }
            set { userType = value; }
        }
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

        private System.String suffix;
        public System.String Suffix
        {
            get { return suffix; }
            set { suffix = value; }
        }

        private System.String company;
        public System.String Company
        {
            get { return company; }
            set { company = value; }
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

        private System.String faxNo;
        public System.String FaxNo
        {
            get { return faxNo; }
            set { faxNo = value; }
        }

        private System.String representingCompanyValue;
        public System.String RepresentingCompanyValue
        {
            get { return representingCompanyValue; }
            set { representingCompanyValue = value; }
        }

        private System.String representingCompanyText;
        public System.String RepresentingCompanyText
        {
            get { return representingCompanyText; }
            set { representingCompanyText = value; }
        }
        private System.String uniqueID;
        public System.String UniqueID
        {
            get { return uniqueID; }
            set { uniqueID = value; }
        }

        private System.Int32 registrationSeq;
        public System.Int32 RegistrationSeq
        {
            get { return registrationSeq; }
            set { registrationSeq = value; }
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
                                case "LAST_LOGIN_DATE":
                                    LastLoginDate = Convert.ToDateTime(dtReader[index]);
                                    break;
                                case "MEMBER_SEQ":
                                    MemberSeq = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "ROLE_CODE":
                                    RoleCode = Convert.ToString(dtReader[index]);
                                    break;
                                case "USER_ID":
                                    UserID = Convert.ToString(dtReader[index]);
                                    break;
                                case "USER_PASSWORD":
                                    UserPassword = Convert.ToString(dtReader[index]);
                                    break;
                                case "USER_TYPE":
                                    UserType = Convert.ToString(dtReader[index]);
                                    break;
                                case "STATUS":
                                    Status = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "FIRST_NAME":
                                    FirstName = Convert.ToString(dtReader[index]);
                                    break;
                                case "MIDDLE_NAME":
                                    MiddleName = Convert.ToString(dtReader[index]);
                                    break;
                                case "LAST_NAME":
                                    LastName = Convert.ToString(dtReader[index]);
                                    break;
                                case "SUFFIX":
                                    Suffix = Convert.ToString(dtReader[index]);
                                    break;
                                case "COMPANY_ORG":
                                    Company = Convert.ToString(dtReader[index]);
                                    break;
                                case "MAILING_ADDRESS":
                                    MailingAddress = Convert.ToString(dtReader[index]);
                                    break;
                                case "MAILING_ADDRESS_CONTD":
                                    MailingAddressCont = Convert.ToString(dtReader[index]);
                                    break;
                                case "CITY":
                                    City = Convert.ToString(dtReader[index]);
                                    break;
                                case "STATE":
                                    State = Convert.ToString(dtReader[index]);
                                    break;
                                case "ZIP_CODE":
                                    ZipCode = Convert.ToString(dtReader[index]);
                                    break;
                                case "TELEPHONE_NO":
                                    PhoneNo = Convert.ToString(dtReader[index]);
                                    break;
                                case "EXTN":
                                    Extn = Convert.ToString(dtReader[index]);
                                    break;
                                case "FAX_NO":
                                    FaxNo = Convert.ToString(dtReader[index]);
                                    break;
                                case "REPRESENTING_CMP":
                                    RepresentingCompanyValue = Convert.ToString(dtReader[index]);
                                    break;
                                case "REGISTRATION_SEQ":
                                    RegistrationSeq = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "UNIQUE_ID":
                                    UniqueID = Convert.ToString(dtReader[index]);
                                    break;
                                case "EMAIL_ID":
                                    EmailID = Convert.ToString(dtReader[index]);
                                    break;
                            }
                        }
                    }
                }
                //if (dtReader != null)
                //    base.SetValues(dtReader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

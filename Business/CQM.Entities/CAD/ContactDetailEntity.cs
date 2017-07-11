//---------------------------------------------------------------------
// Author: JAY Prakash  
// Version: 1.0.0
// Date: 18/May/2011
// Description: Contact Detail Entity
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
    /// This entity class stores the information about Contact of Complanent.
    /// </summary>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-18-May</ceationDate>
    /// <modifications>
    /// <item>ModifiedBy:Yugal Description: Adding fields required for Intake Specialist Residential</item>
    /// <item></item>
    /// </modifications>
  public class ContactDetailEntity
    {
        private System.String suffix;
        public System.String Suffix
        {
            get { return suffix; }
            set { suffix = value; }
        }

        private System.String fname;
        public System.String FName
        {
            get { return fname; }
            set { fname = value; }
        }

        private System.String lname;
        public System.String LName
        {
            get { return lname; }
            set { lname = value; }
        }

        private System.String mname;
        public System.String MName
        {
            get { return mname; }
            set { mname = value; }
        }

        private System.String phoneno;
        public System.String PhoneNo
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        private System.String extn;
        public System.String Extn
        {
            get { return extn; }
            set { extn = value; }
        }

        private System.String secphonenum;
        public System.String SecPhoneNo
        {
            get { return secphonenum; }
            set { secphonenum = value; }
        }

        private System.String secextn;
        public System.String SecExtn
        {
            get { return secextn; }
            set { secextn = value; }
        }

        private System.String emailid;
        public System.String EmailId
        {
            get { return emailid; }
            set { emailid = value; }
        }

        private System.Decimal memberSeq;
        public System.Decimal MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }

        private System.String business_name;
        public System.String Business_Name
        {
            get { return business_name; }
            set { business_name = value; }
        }

        private System.String cmplnt_cntct_f_nme;
        public System.String Cmplnt_Cntct_F_Nme
        {
            get { return cmplnt_cntct_f_nme; }
            set { cmplnt_cntct_f_nme = value; }
        }

        private System.String cmplnt_cntct_l_nme;
        public System.String Cmplnt_Cntct_L_Nme
        {
            get { return cmplnt_cntct_l_nme; }
            set { cmplnt_cntct_l_nme = value; }
        }

        private System.String cmplnt_cntct_m_nme;
        public System.String Cmplnt_Cntct_M_Nme
        {
            get { return cmplnt_cntct_m_nme; }
            set { cmplnt_cntct_m_nme = value; }
        }

        private System.String cmplnt_cntct_phone_no;
        public System.String Cmplnt_Cntct_Phone_No
        {
            get { return cmplnt_cntct_phone_no; }
            set { cmplnt_cntct_phone_no = value; }
        }

        private System.String cmplnt_cntct_extn;
        public System.String Cmplnt_Cntct_Extn
        {
            get { return cmplnt_cntct_extn; }
            set { cmplnt_cntct_extn = value; }
        }

        private System.String cmplnt_cntct_phone2_no;
        public System.String Cmplnt_Cntct_Phone2_No
        {
            get { return cmplnt_cntct_phone2_no; }
            set { cmplnt_cntct_phone2_no = value; }
        }

        private System.String cmplnt_cntct_extn2;
        public System.String Cmplnt_Cntct_Extn2
        {
            get { return cmplnt_cntct_extn2; }
            set { cmplnt_cntct_extn2 = value; }
        }

        private System.String cmplnt_cntct_email;
        public System.String Cmplnt_Cntct_Email
        {
            get { return cmplnt_cntct_email; }
            set { cmplnt_cntct_email = value; }
        }

        private System.String cmplnt_cntct_address;
        public System.String Cmplnt_Cntct_Address
        {
            get { return cmplnt_cntct_address; }
            set { cmplnt_cntct_address = value; }
        }

        private System.String cmplnt_cntct_address_cont;
        public System.String Cmplnt_Cntct_Address_Cont
        {
            get { return cmplnt_cntct_address_cont; }
            set { cmplnt_cntct_address_cont = value; }
        }

        private System.String cmplnt_cntct_state;
        public System.String Cmplnt_Cntct_State
        {
            get { return cmplnt_cntct_state; }
            set { cmplnt_cntct_state = value; }
        }

        private System.String cmplnt_cntct_city;
        public System.String Cmplnt_Cntct_City
        {
            get { return cmplnt_cntct_city; }
            set { cmplnt_cntct_city = value; }
        }

        private System.String cmplnt_cntct_zip_code;
        public System.String Cmplnt_Cntct_Zip_Code
        {
            get { return cmplnt_cntct_zip_code; }
            set { cmplnt_cntct_zip_code = value; }
        }

        private System.String cmplnt_cntct_zip_code_cont;
        public System.String Cmplnt_Cntct_Zip_Code_Cont
        {
            get { return cmplnt_cntct_zip_code_cont; }
            set { cmplnt_cntct_zip_code_cont = value; }
        }

        private System.String cmplnt_cntct_pref_contact_method;
        public System.String Cmplnt_Cntct_Pref_Contact_Method
        {
            get { return cmplnt_cntct_pref_contact_method; }
            set { cmplnt_cntct_pref_contact_method = value; }
        }

        private System.String cmplnt_cntct_code;
        public System.String Cmplnt_Cntct_Code
        {
            get { return cmplnt_cntct_code; }
            set { cmplnt_cntct_code = value; }
        }

        private System.String sec_cntct_f_nme;
        public System.String Sec_Cntct_F_Nme
        {
            get { return sec_cntct_f_nme; }
            set { sec_cntct_f_nme = value; }
        }

        private System.String sec_cntct_m_nme;
        public System.String Sec_Cntct_M_Nme
        {
            get { return sec_cntct_m_nme; }
            set { sec_cntct_m_nme = value; }
        }

        private System.String sec_cntct_l_nme;
        public System.String Sec_Cntct_L_Nme
        {
            get { return sec_cntct_l_nme; }
            set { sec_cntct_l_nme = value; }
        }

        private System.String sec_cntct_suffix;
        public System.String Sec_Cntct_Suffix
        {
            get { return sec_cntct_suffix; }
            set { sec_cntct_suffix = value; }
        }

        private System.Int32 sec_cntct_phone_no;
        public System.Int32 Sec_Cntct_Phone_No
        {
            get { return sec_cntct_phone_no; }
            set { sec_cntct_phone_no = value; }
        }

        private System.Int32 sec_cntct_extn;
        public System.Int32 Sec_Cntct_Extn
        {
            get { return sec_cntct_extn; }
            set { sec_cntct_extn = value; }
        }

        private System.String sec_cntct_phone2_no;
        public System.String Sec_Cntct_Phone2_No
        {
            get { return sec_cntct_phone2_no; }
            set { sec_cntct_phone2_no = value; }
        }

        private System.String sec_cntct_extn2;
        public System.String Sec_Cntct_Extn2
        {
            get { return sec_cntct_extn2; }
            set { sec_cntct_extn2 = value; }
        }

        private System.String sec_cntct_email;
        public System.String Sec_Cntct_Email
        {
            get { return sec_cntct_email; }
            set { sec_cntct_email = value; }
        }

        private System.String sec_cntct_address;
        public System.String Sec_Cntct_Address
        {
            get { return sec_cntct_address; }
            set { sec_cntct_address = value; }
        }

        private System.String sec_cntct_address_cont;
        public System.String Sec_Cntct_Address_Cont
        {
            get { return sec_cntct_address_cont; }
            set { sec_cntct_address_cont = value; }
        }

        private System.String sec_cntct_city;
        public System.String Sec_Cntct_City
        {
            get { return sec_cntct_city; }
            set { sec_cntct_city = value; }
        }

        private System.String sec_cntct_state;
        public System.String Sec_Cntct_State
        {
            get { return sec_cntct_state; }
            set { sec_cntct_state = value; }
        }

        private System.String sec_cntct_zip_code;
        public System.String Sec_Cntct_Zip_Code
        {
            get { return sec_cntct_zip_code; }
            set { sec_cntct_zip_code = value; }
        }

        private System.String sec_cntct_zip_code_cont;
        public System.String Sec_Cntct_Zip_Code_Cont
        {
            get { return sec_cntct_zip_code_cont; }
            set { sec_cntct_zip_code_cont = value; }
        }

        private System.String cmplnt_cntct_suffix;
        public System.String Cmplnt_Cntct_Suffix
        {
            get { return cmplnt_cntct_suffix; }
            set { cmplnt_cntct_suffix = value; }
        }

        private System.String dba;
        public System.String Dba
        {
            get { return dba; }
            set { dba = value; }
        }

        //private System.String ;
        //        public System.String 
        //        {
        //            get { return ; }
        //            set {  = value; }
        //        }




        private System.String serviceaddress;
        public System.String ServiceAddress
        {
            get { return serviceaddress; }
            set { serviceaddress = value; }
        }
        private System.String serviceaddcont;
        public System.String ServiceAddressCont
        {
            get { return serviceaddcont; }
            set { serviceaddcont = value; }
        }
        private System.String servicecity;
        public System.String ServiceCity
        {
            get { return servicecity; }
            set { servicecity = value; }
        }
        //private System.String servicecity;
        //public System.String Service_CITY
        //{
        //    get { return servicecity; }
        //    set { servicecity = value; }
        //}
        private System.String servicestate;
        public System.String ServiceState
        {
            get { return servicestate; }
            set { servicestate = value; }
        }
        private System.String servicezipcode;
        public System.String ServiceZipCode
        {
            get { return servicezipcode; }
            set { servicezipcode = value; }
        }
        private System.String mailingadd;
        public System.String MailingAddress
        {
            get { return mailingadd; }
            set { mailingadd = value; }
        }
        private System.String mailingaddcont;
        public System.String MailingAddressCont
        {
            get { return mailingaddcont; }
            set { mailingaddcont = value; }
        }
        private System.String mailingcity;
        public System.String MailingCity
        {
            get { return mailingcity; }
            set { mailingcity = value; }
        }
        private System.String mailingstate;
        public System.String MailingState
        {
            get { return mailingstate; }
            set { mailingstate = value; }
        }
        private System.String mailingzipcode;
        public System.String MailingZipCode
        {
            get { return mailingzipcode; }
            set { mailingzipcode = value; }
        }
        private System.String createdby;
        public System.String CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private System.String updatedby;
        public System.String UpdatedBy
        {
            get { return updatedby; }
            set { updatedby = value; }
        }
        //Added by Yugal for Intake Specialist Residential Form
        private System.String resFirstName;
        public System.String ResFirstName
        {
            get { return resFirstName; }
            set { resFirstName = value; }
        }
        private System.String resLastName;
        public System.String ResLastName
        {
            get { return resLastName; }
            set { resLastName = value; }
        }
        private System.String resMiddleName;
        public System.String ResMiddleName
        {
            get { return resMiddleName; }
            set { resMiddleName = value; }
        }
        private System.String resSuffix;
        public System.String ResSuffix
        {
            get { return resSuffix; }
            set { resSuffix = value; }
        }
        private System.String resStreetAddress;
        public System.String ResStreetAddress
        {
            get { return resStreetAddress; }
            set { resStreetAddress = value; }
        }
        private System.String resStreetAddressCont;
        public System.String ResStreetAddressCont
        {
            get { return resStreetAddressCont; }
            set { resStreetAddressCont = value; }
        }
        private System.String resCity;
        public System.String ResCity
        {
            get { return resCity; }
            set { resCity = value; }
        }
        private System.String resState;
        public System.String ResState
        {
            get { return resState; }
            set { resState = value; }
        }
        private System.String resZipcode;
        public System.String ResZipcode
        {
            get { return resZipcode; }
            set { resZipcode = value; }
        }
        private System.String resPhone;
        public System.String ResPhone
        {
            get { return resPhone; }
            set { resPhone = value; }
        }
        private System.String resEmail;
        public System.String ResEmail
        {
            get { return resEmail; }
            set { resEmail = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
      //added for company
        private System.String company;
        public System.String Company
        {
            get { return company; }
            set { company = value; }
        }

        // Added By Jay on 1 Dec 2011
        private System.String memberTypeCode;
        public System.String MemberTypeCode
        {
            get { return memberTypeCode; }
            set { memberTypeCode = value; }
        }

    }
}

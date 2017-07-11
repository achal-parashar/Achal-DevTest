using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQM.Entities
{
   public class NotificationListEntity
    {
        private System.String mailingAddress;
        public System.String MailingAddress
        {
            get { return mailingAddress; }
            set { mailingAddress = value; }
        }
        private System.String fullName;
        public System.String FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        private System.String companyOrgName;
        public System.String CompanyOrgName
        {
            get { return companyOrgName; }
            set { companyOrgName = value; }
        }
        private System.String emailID;
        public System.String EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }
        private System.String faxNo;
        public System.String FaxNo
        {
            get { return faxNo; }
            set { faxNo = value; }
        }
        private System.Int32 totalCount;
        public System.Int32 TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        private System.Int32 count;
        public System.Int32 Count
        {
            get { return count; }
            set { count = value; }
        }
        private System.String phoneNo;
        public System.String PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
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
                                case "MAILING_ADDRESS":
                                    MailingAddress = Convert.ToString(dtReader[index]);
                                    break;
                                case "NAME":
                                    FullName = Convert.ToString(dtReader[index]);
                                    break;
                                case "COMPANY_ORG_NAME":
                                    CompanyOrgName = Convert.ToString(dtReader[index]);
                                    break;
                                case "TOTALCOUNT":
                                    TotalCount = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "COUNT":
                                    Count = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "EMAIL_ID":
                                    EmailID = Convert.ToString(dtReader[index]);
                                    break;
                                case "PHONE_NO":
                                    PhoneNo = Convert.ToString(dtReader[index]);
                                    break;
                                case "FAX_NO":
                                    FaxNo = Convert.ToString(dtReader[index]);
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

//---------------------------------------------------------------------
// Date: 11/21/2007
// Author:Mohit Vashishtha
// Version: 1.0.0
// Modified By: Krishan Kumar Aishpunani
// Modification Date:Monday, Dec 05,2007 
// Description:  This entity class stores the information about StaffEntity.

// History:
// Changed By  Mohit Vashishtha                         Changed On   10-Oct-2011
//---------------------------------------------------------------------
namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about StaffEntity.
    /// </summary>
    /// <author>Krishan kumar Aishpunani</author>
    /// <creationDate>2007-11-21</ceationDate>
    /// <modifications>
    /// <item>2007-11-21;Krishan kumar Aishpunani;Added Class level Comments</item>
    /// </modifications>

    public class StaffEntity
    {
        private System.Int32 activitySeq;
        public System.Int32 ActivitySeq
        {
            get { return activitySeq; }
            set { activitySeq = value; }
        }
        private System.String activityname;
        public System.String ActivityName
        {
            get { return activityname; }
            set { activityname = value; }
        }
        private System.String printerIP;
        public System.String PrinterIP
        {
            get { return printerIP; }
            set { printerIP = value; }
        }
        private System.Int32 printerSeq;
        public System.Int32 PrinterSeq
        {
            get { return printerSeq; }
            set { printerSeq = value; }
        }
        private System.String printerUrl;
        public System.String PrinterUrl
        {
            get { return printerUrl; }
            set { printerUrl = value; }
        }
        private System.String createdby;
        public System.String Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }

        /// <summary>
        /// Added by Mohit Property Role Code
        /// </summary>

        private System.String roleCode;
        public System.String RoleCode
        {
            get { return roleCode; }
            set { roleCode = value; }
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

        private System.Int32 userSeq;
        public System.Int32 UserSeq
        {
            get { return userSeq; }
            set { userSeq = value; }
        }
        private System.Int32 officeSeq;
        public System.Int32 OfficeSeq
        {
            get { return officeSeq; }
            set { officeSeq = value; }
        }
        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }
        private System.Int32 staffSeq;
        public System.Int32 StaffSeq
        {
            get { return staffSeq; }
            set { staffSeq = value; }
        }
        private System.String description;
        public System.String Description
        {
            get { return description; }
            set { description = value; }
        }
        private System.Int32 sectionSeq;
        public System.Int32 SectionSeq
        {
            get { return sectionSeq; }
            set { sectionSeq = value; }
        }
        private System.String sectionName;
        public System.String SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
        private System.String officeName;
        public System.String OfficeName
        {
            get { return officeName; }
            set { officeName = value; }
        }
        private System.String designation;
        public System.String Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        private System.String staffName;
        public System.String StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }
        private System.Int32 roleSeq;
        public System.Int32 RoleSeq
        {
            get { return roleSeq; }
            set { roleSeq = value; }
        }
        private System.String rollName;
        public System.String RoleName
        {
            get { return rollName; }
            set { rollName = value; }
        }
        private System.String firstName;
        public System.String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
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
        private System.String isStaff;
        public System.String IsStaff
        {
            get { return isStaff; }
            set { isStaff = value; }
        }
        private System.String userId;
        public System.String UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private System.Decimal acessListSeq;
        public System.Decimal AcessListSeq
        {
            get { return acessListSeq; }
            set { acessListSeq = value; }
        }
        
        private System.String name;
        public System.String Name
        {
            get { return name; }
            set { name = value; }
        }
        

        private System.String isLimitedDistributionMember;
        public System.String IsLimitedDistributionMember
        {
            get { return isLimitedDistributionMember; }
            set { isLimitedDistributionMember = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
    }


}

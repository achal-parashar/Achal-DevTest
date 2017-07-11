//---------------------------------------------------------------------
// Author: Deepak Kumar Singh
// Version: 1.0.0
// Date: 10/22/2007
// Description: Agenda Staff Entity
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
    /// This entity class stores the information about Agenda Staff.
    /// </summary>
    /// <author>Deepak Kumar Singh</author>
    /// <creationDate>2007-12-01</ceationDate>
    /// <modifications>
    /// <item>2007-12-01;Deepak Singh;Added new Functions</item>
    /// <item>2007-12-22;Deepak Singh;Modified according to new database structure.</item>
    /// </modifications>
    /// 
    public class AgendaStaffEntity
    {
        //Start DPS Agenda Staff Map
        private System.Decimal agendaSeq;
        public System.Decimal AgendaSeq
        {
            get { return agendaSeq; }
            set { agendaSeq = value; }
        }

        private System.Decimal mapSeq;
        public System.Decimal MapSeq
        {
            get { return mapSeq; }
            set { mapSeq = value; }
        }

        private System.Decimal staffSeq;
        public System.Decimal StaffSeq
        {
            get { return staffSeq; }
            set { staffSeq = value; }
        }

        private System.String staffType;
        public System.String StaffType
        {
            get { return staffType; }
            set { staffType = value; }
        }
        //End DPS Agenda Staff Map

        //Start DPS Office
        private System.String officeName;
        public System.String OfficeName
        {
            get { return officeName; }
            set { officeName = value; }
        }
        //End DPS Office

        //Start DPS Section 
        private System.String sectionName;
        public System.String SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
        //End DPS Section
        //Start Additional
        private System.String staffName;
        public System.String StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }

        private System.String email;
        public System.String Email
        {
            get { return email; }
            set { email = value; }
        }

        private System.String phoneNo;
        public System.String PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private System.String designation;
        public System.String Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        private System.String roleName;
        public System.String RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        private System.String matterNum;
        public System.String MatterNum
        {
            get { return matterNum; }
            set { matterNum = value; }
        }

        private System.Decimal matterSeq;
        public System.Decimal MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
        }

        private System.Decimal isStaffSelected;
        public System.Decimal IsStaffSelected
        {
            get { return isStaffSelected; }
            set { isStaffSelected = value; }
        }

        private System.Decimal isCheckBoxEnabled;
        public System.Decimal IsCheckBoxEnabled
        {
            get { return isCheckBoxEnabled; }
            set { isCheckBoxEnabled = value; }
        }

        private System.Decimal totalRecords;
        public System.Decimal TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String staffId;
        public System.String StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }

        private System.Decimal listDtlSeq;
        public System.Decimal ListDtlSeq
        {
            get { return listDtlSeq; }
            set { listDtlSeq = value; }
        }

        private System.Decimal isAdditionalStaff;
        public System.Decimal IsAdditionalStaff
        {
            get { return isAdditionalStaff; }
            set { isAdditionalStaff = value; }
        }

        private System.Decimal isYellowSheetMember;
        public System.Decimal IsYellowSheetMember
        {
            get { return isYellowSheetMember; }
            set { isYellowSheetMember = value; }
        }

        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }

        private System.String lockedBy;
        public System.String LockedBy
        {
            get { return lockedBy; }
            set { lockedBy = value; }
        }

        private System.Decimal isAssignedOnMatter;
        public System.Decimal IsAssignedOnMatter
        {
            get { return isAssignedOnMatter; }
            set { isAssignedOnMatter = value; }
        }
        //End Additional

    }

}

//---------------------------------------------------------------------
// Author: Mohit Vashishtha
// Version: 1.0.0
// Date: 01/29/2008
// Description: Represents a businees Logic for Matter Contact Role Master.
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
    /// Represents a MatterConactRoleEntity object.
    /// </summary>
    public class MatterContactRoleEntity
        {
        private System.String isDeleted;
        public System.String IsDeleted
            {
            get { return isDeleted; }
            set { isDeleted = value; }
            }
        private System.Decimal mcontactRoleSeq;
        public System.Decimal McontactRoleSeq
            {
            get { return mcontactRoleSeq; }
            set { mcontactRoleSeq = value; }
            }
        private System.String roleType;
        public System.String RoleType
            {
            get { return roleType; }
            set { roleType = value; }
            }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
            {
            get { return totalRecords; }
            set { totalRecords = value; }
            }
        private System.String mcontactRoleCode;
        public System.String McontactRoleCode
        {
            get { return mcontactRoleCode; }
            set { mcontactRoleCode = value; }
        }
        private System.String createdby;
        public System.String Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private System.String updatedby;
        public System.String Updatedby
        {
            get { return updatedby; }
            set { updatedby = value; }
        }
        }
    }
using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    public class ProcessEntity
    {

        private System.Decimal roleId;
        public System.Decimal RoleID
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

        private System.Decimal mainProcessId;
        public System.Decimal MainProcessId
        {
            get { return mainProcessId; }
            set { mainProcessId = value; }
        }

        private System.Decimal subProcessId;
        public System.Decimal SubProcessID
        {
            get { return subProcessId; }
            set { subProcessId = value; }
        }

        private System.String mainProcessName;
        public System.String MainProcessName
        {
            get { return mainProcessName; }
            set { mainProcessName = value; }
        }

        private System.String subProcessName;
        public System.String SubProcessName
        {
            get { return subProcessName; }
            set { subProcessName = value; }
        }

        private System.String roleCode;
        public System.String RoleCode
        {
            get { return roleCode; }
            set { roleCode = value; }
        }

        private System.String isVisible;
        public System.String IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    public class ProcessActivityEntity
    {

        private System.Decimal roleId;
        public System.Decimal RoleID
        {
            get { return roleId; }
            set { roleId = value; }
        }

        private System.String activityName;
        public System.String ActivityName
        {
            get { return activityName; }
            set { activityName = value; }
        }

        private System.String activityCode;
        public System.String ActivityCode
        {
            get { return activityCode; }
            set { activityCode = value; }
        }

        private System.String processName;
        public System.String ProcessName
        {
            get { return processName; }
            set { processName = value; }
        }

        private System.Decimal processCode;
        public System.Decimal ProcessCode
        {
            get { return processCode; }
            set { processCode = value; }
        }
        private System.Decimal processId;
        public System.Decimal ProcessID
        {
            get { return processId; }
            set { processId = value; }
        }

    }
}

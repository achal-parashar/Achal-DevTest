//---------------------------------------------------------------------
// Author: Partha Pramanick
// Version: 1.0.0
// Date: 11/22/2009
// Description: Status Entity
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
    public class StatusEntity
    {
        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }

        private System.String statusType;
        public System.String StatusType
        {
            get { return statusType; }
            set { statusType = value; }
        }
    }
}

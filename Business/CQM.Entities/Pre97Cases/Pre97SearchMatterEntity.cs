//---------------------------------------------------------------------
// Author: Deepshikha
// Version: 1.0.0
// Date: 12/21/2011
// Description: SearchPre97MatterEntity
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
    /// This entity class stores the information about SearchPre97MatterEntity required for searching pre97 matter
    /// </summary>
    /// <author>deepshikha</author>
    /// <creationDate>2011-12-21</creationDate>
    /// <modifications>
    /// <item></item>
    /// </modifications>

    public class Pre97SearchMatterEntity
    {
        private System.String matterNumber;
        public System.String MatterNumber
        {
            get { return matterNumber; }
            set { matterNumber = value; }
        }

        private System.String matterTitle;
        public System.String MatterTitle
        {
            get { return matterTitle; }
            set { matterTitle = value; }
        }

        private System.DateTime dateFiledFrom;
        public System.DateTime DateFiledFrom
        {
            get { return dateFiledFrom; }
            set { dateFiledFrom = value; }
        }

        private System.DateTime dateFiledTo;
        public System.DateTime DateFiledTo
        {
            get { return dateFiledTo; }
            set { dateFiledTo = value; }
        }

        private System.DateTime dateClosedFrom;
        public System.DateTime DateClosedFrom
        {
            get { return dateClosedFrom; }
            set { dateClosedFrom = value; }
        }
        private System.DateTime dateClosedTo;
        public System.DateTime DateClosedTo
        {
            get { return dateClosedTo; }
            set { dateClosedTo = value; }
        }
        
           
        private System.String utilityType;
        public System.String UtilityType
        {
            get { return utilityType; }
            set { utilityType = value; }
        }

        private System.String utilityName;
        public System.String UtilityName
        {
            get { return utilityName; }
            set { utilityName = value; }
        }

    }

}

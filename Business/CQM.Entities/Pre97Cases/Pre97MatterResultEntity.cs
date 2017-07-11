//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/22/2007
// Description: Pre 97 Matter Result Entity
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
    /// This entity class stores the information about Matter Search Result Entity
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-11-22</creationDate>
    /// <modifications>
    /// <item>2008-02-02;Ritika Fakay;Added comments</item>
    /// <item></item>
    /// </modifications>
    
    public class Pre97MatterResultEntity
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

        private System.DateTime dateFiled;
        public System.DateTime DateFiled
        {
            get { return dateFiled; }
            set { dateFiled = value; }
        }

        private System.DateTime dateClosed;
        public System.DateTime DateClosed
        {
            get { return dateClosed; }
            set { dateClosed = value; }
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

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
    }
}

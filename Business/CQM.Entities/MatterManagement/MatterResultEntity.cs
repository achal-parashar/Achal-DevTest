//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/22/2007
// Description: Matter Result Entity
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
    /// <creationDate>2007-11-22</ceationDate>
    /// <modifications>
    /// <item>2008-02-02;Ritika Fakay;Added comments</item>
    /// <item></item>
    /// </modifications>
    
    public class MatterResultEntity
    {
        private System.Int32 matterID;
        public System.Int32 MatterID
        {
            get { return matterID; }
            set { matterID = value; }
        }

        private System.String matterNumber;
        public System.String MatterNumber
        {
            get { return matterNumber; }
            set { matterNumber = value; }
        }

        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        private System.String matterType;
        public System.String MatterType
        {
            get { return matterType; }
            set { matterType = value; }
        }

        private System.String matterSubType;
        public System.String MatterSubType
        {
            get { return matterSubType; }
            set { matterSubType = value; }
        }

        //start
        //added by Harita Munagala on 16/03/2012 for add service list subscription
        private System.String utilitySubType;
        public System.String UtilitySubType
        {
            get { return utilitySubType; }
            set { utilitySubType = value; }
        }

        private System.String utilityType;
        public System.String UtilityType
        {
            get { return utilityType; }
            set { utilityType = value; }
        }
        //end

        private System.String matterTitle;
        public System.String MatterTitle
        {
            get { return matterTitle; }
            set { matterTitle = value; }
        }

        private System.String leadOfficeName;
        public System.String LeadOfficeName
        {
            get { return leadOfficeName; }
            set { leadOfficeName = value; }
        }

        private System.String leadOfficeShortName;
        public System.String LeadOfficeShortName
        {
            get { return leadOfficeShortName; }
            set { leadOfficeShortName = value; }
        }

        private System.String status;
        public System.String Status
        {
            get { return status; }
            set { status = value; }
        }

        private System.DateTime startDate;
        public System.DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
    }
}

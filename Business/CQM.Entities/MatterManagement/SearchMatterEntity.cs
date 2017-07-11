//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 26/12/2007
// Description: SearchMatterEntity
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
    /// This entity class stores the information about SearchMatterEntity required for search matter
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-12-26</ceationDate>
    /// <modifications>
    /// <item></item>
    /// </modifications>

    public class SearchMatterEntity
    {
        private System.String matterNumber;
        public System.String MatterNumber
        {
            get { return matterNumber; }
            set { matterNumber = value; }
        }

        private System.DateTime startDateFrom;
        public System.DateTime StartDateFrom
        {
            get { return startDateFrom; }
            set { startDateFrom = value; }
        }

        private System.DateTime startDateTo;
        public System.DateTime StartDateTo
        {
            get { return startDateTo; }
            set { startDateTo = value; }
        }

        private System.Int32 industryAffectedID;
        public System.Int32 IndustryAffectedID
        {
            get { return industryAffectedID; }
            set { industryAffectedID = value; }
        }

        private System.Int32 matterTypeID;
        public System.Int32 MatterTypeID
        {
            get { return matterTypeID; }
            set { matterTypeID = value; }
        }

        private System.Int32 matterSubTypeID;
        public System.Int32 MatterSubTypeID
        {
            get { return matterSubTypeID; }
            set { matterSubTypeID = value; }
        }

        //private System.String franchiseIDs;
        //public System.String FranchiseIDs
        //{
        //    get { return franchiseIDs; }
        //    set { franchiseIDs = value; }
        //}

        //private System.Int32 countySeq;
        //public System.Int32 CountySeq
        //{
        //    get { return countySeq; }
        //    set { countySeq = value; }
        //}

        //private System.Int32 municipalitySeq;
        //public System.Int32 MunicipalitySeq
        //{
        //    get { return municipalitySeq; }
        //    set { municipalitySeq = value; }
        //}

        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }

        private System.Int32 companyID;
        public System.Int32 CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        //private System.Int32 leadOfficeID;
        //public System.Int32 LeadOfficeID
        //{
        //    get { return leadOfficeID; }
        //    set { leadOfficeID = value; }
        //}

        private System.String staffID;
        public System.String StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        private System.String matterTitle;
        public System.String MatterTitle
        {
            get { return matterTitle; }
            set { matterTitle = value; }
        }

        //private System.String statusNotes;
        //public System.String StatusNotes
        //{
        //    get { return statusNotes; }
        //    set { statusNotes = value; }
        //}

        private System.String isExternal;
        public System.String IsExternal
        {
            get { return isExternal; }
            set { isExternal = value; }
        }

        /* added by jatin */
        //private System.Int32 otherOfficeID;
        //public System.Int32 OtherOfficeID
        //{
        //    get { return otherOfficeID; }
        //    set { otherOfficeID = value; }
        //}
        //private System.String notes;
        //public System.String Notes
        //{
        //    get { return notes; }
        //    set { notes = value; }
        //}

        private System.String staffName;
        public System.String StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }

        //added for the serach criteria report
        //private System.String franchiseNames;
        //public System.String FranchiseNames
        //{
        //    get { return franchiseNames; }
        //    set { franchiseNames = value; }
        //}

        private System.String matterTypeName;
        public System.String MatterTypeName
        {
            get { return matterTypeName; }
            set { matterTypeName = value; }
        }

        private System.String matterSubTypeName;
        public System.String MatterSubTypeName
        {
            get { return matterSubTypeName; }
            set { matterSubTypeName = value; }
        }

        //private System.String industryAffectedName;
        //public System.String IndustryAffectedName
        //{
        //    get { return industryAffectedName; }
        //    set { industryAffectedName = value; }
        //}

        private System.String companyName;
        public System.String CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        //private System.String leadOfficeName;
        //public System.String LeadOfficeName
        //{
        //    get { return leadOfficeName; }
        //    set { leadOfficeName = value; }
        //}

        //private System.String otherOfficeName;
        //public System.String OtherOfficeName
        //{
        //    get { return otherOfficeName; }
        //    set { otherOfficeName = value; }
        //}

        //private System.String municipalityName;
        //public System.String MunicipalityName
        //{
        //    get { return municipalityName; }
        //    set { municipalityName = value; }
        //}

        //private System.String countyName;
        //public System.String CountyName
        //{
        //    get { return countyName; }
        //    set { countyName = value; }
        //}
        //private System.Int32 sectionSeq;
        //public System.Int32 SectionSeq
        //{
        //    get { return sectionSeq; }
        //    set { sectionSeq = value; }
        //}
        //private System.String sectionName;
        //public System.String SectionName
        //{
        //    get { return sectionName; }
        //    set { sectionName = value; }
        //}
        //Added
        private System.String utilityTypeCode;
        public System.String UtilityTypeCode
        {
            get { return utilityTypeCode; }
            set { utilityTypeCode = value; }
        }
        private System.String utilitySubTypeCode;
        public System.String UtilitySubTypeCode
        {
            get { return utilitySubTypeCode; }
            set { utilitySubTypeCode = value; }
        }
        private System.String utilityTypeName;
        public System.String UtilityTypeName
        {
            get { return utilityTypeName; }
            set { utilityTypeName = value; }
        }
        private System.String utilitySubTypeName;
        public System.String UtilitySubTypeName
        {
            get { return utilitySubTypeName; }
            set { utilitySubTypeName = value; }
        }
        private System.Int32 perUtilityCompanyID;
        public System.Int32 PerUtilityCompanyID
        {
            get { return perUtilityCompanyID; }
            set { perUtilityCompanyID = value; }
        }
        private System.String perUtilityCompanyName;
        public System.String PerUtilityCompanyName
        {
            get { return perUtilityCompanyName; }
            set { perUtilityCompanyName = value; }
        }
        private System.String matterTypecode;
        public System.String MatterTypecode
        {
            get { return matterTypecode; }
            set { matterTypecode = value; }
        }
        private System.String matterSubTypecode;
        public System.String MatterSubTypecode
        {
            get { return matterSubTypecode; }
            set { matterSubTypecode = value; }
        }
        private System.String statusType;
        public System.String StatusType
        {
            get { return statusType; }
            set { statusType = value; }
        }

    }

}

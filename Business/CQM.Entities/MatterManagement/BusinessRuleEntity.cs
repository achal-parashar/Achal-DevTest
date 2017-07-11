//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/22/2007
// Description: Business Rule Entity
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
    /// This entity class stores the information about Matter Business Rules
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-11-22</ceationDate>
    /// <modifications>
    /// <item>2008-02-02;Ritika Fakay;Added comments</item>
    /// <item></item>
    /// </modifications>

    public class BusinessRuleEntity
    {
        private System.Int32 industryTypeID;
        public System.Int32 IndustryTypeID
        {
            get { return industryTypeID; }
            set { industryTypeID = value; }
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

        private System.String hearingReq;
        public System.String HearingReq
        {
            get { return hearingReq; }
            set { hearingReq = value; }
        }

        private System.String sAPAReq;
        public System.String SAPAReq
        {
            get { return sAPAReq; }
            set { sAPAReq = value; }
        }

        private System.String isCase;
        public System.String IsCase
        {
            get { return isCase; }
            set { isCase = value; }
        }

        private System.String matterTitle;
        public System.String MatterTitle
        {
            get { return matterTitle; }
            set { matterTitle = value; }
        }

        private System.Int32 daysToComplete;
        public System.Int32 DaysToComplete
        {
            get { return daysToComplete; }
            set { daysToComplete = value; }
        }

        private System.String autoClose;
        public System.String AutoClose
        {
            get { return autoClose; }
            set { autoClose = value; }
        }
        private System.String caseTypeCode;
        public System.String CaseTypeCode
        {
            get { return caseTypeCode; }
            set { caseTypeCode = value; }
        }

        private System.String industryTypeCode;
        public System.String IndustryTypeCode
        {
            get { return industryTypeCode; }
            set { industryTypeCode = value; }
        }
        private System.Int32 retentionPeriod;
        public System.Int32 RetentionPeriod
        {
            get { return retentionPeriod; }
            set { retentionPeriod = value; }
        }
        private System.String matterSubtypeCode;
        public System.String MatterSubtypeCode
        {
            get { return matterSubtypeCode; }
            set { matterSubtypeCode = value; }
        }
        private System.String matterTypecode;
        public System.String MatterTypecode
        {
            get { return matterTypecode; }
            set { matterTypecode = value; }
        }
        private System.Int32 isExternalFiling;
        public System.Int32 IsExternalFiling
        {
            get { return isExternalFiling; }
            set { isExternalFiling = value; }
        }

    }
}
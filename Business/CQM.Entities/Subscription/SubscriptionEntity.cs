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

    public class SubscriptionEntity
    {
        private System.Int32 matterSubSeq;
        public System.Int32 MatterSubSeq
        {
            get { return matterSubSeq; }
            set { matterSubSeq = value; }
        }

        private System.String userID;
        public System.String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private System.String industry;
        public System.String Industry
        {
            get { return industry; }
            set { industry = value; }
        }
        private System.Int32 industrySeq;
        public System.Int32 IndustrySeq
        {
            get { return industrySeq; }
            set { industrySeq = value; }
        }
        private System.String matterType;
        public System.String MatterType
        {
            get { return matterType; }
            set { matterType = value; }
        }
        private System.Int32 matterTypeSeq;
        public System.Int32 MatterTypeSeq
        {
            get { return matterTypeSeq; }
            set { matterTypeSeq = value; }
        }
        private System.String matterSubType;
        public System.String MatterSubType
        {
            get { return matterSubType; }
            set { matterSubType = value; }
        }
        private System.Int32 matterSubTypeSeq;
        public System.Int32 MatterSubTypeSeq
        {
            get { return matterSubTypeSeq; }
            set { matterSubTypeSeq = value; }
        }
        private System.String company;
        public System.String Company
        {
            get { return company; }
            set { company = value; }
        }
        private System.Int32 companySeq;
        public System.Int32 CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }

        //start
        //added on 19 mar 2012 by Harita Munagala for Add Matter Subscription
        private System.String companyCode;
        public System.String CompanyCode
        {
            get { return companyCode; }
            set { companyCode = value; }
        }
        //end

        private System.String matterSubUpdate;
        public System.String MatterSubUpdate
        {
            get { return matterSubUpdate; }
            set { matterSubUpdate = value; }
        }
        private System.String casetypeCode;
        public System.String CasetypeCode
        {
            get { return casetypeCode; }
            set { casetypeCode = value; }
        }
        private System.String caseSubTypeCode;
        public System.String CaseSubTypeCode
        {
            get { return caseSubTypeCode; }
            set { caseSubTypeCode = value; }
        }
        private System.String industryTypeCode;
        public System.String IndustryTypeCode
        {
            get { return industryTypeCode; }
            set { industryTypeCode = value; }
        }
        private System.String matterSubtypeCode;
        public System.String MatterSubtypeCode
        {
            get { return matterSubtypeCode; }
            set { matterSubtypeCode = value; }
        }
        private System.String industrySubTypeCode;
        public System.String IndustrySubTypeCode
        {
            get { return industrySubTypeCode; }
            set { industrySubTypeCode = value; }
        }
        private System.String industrySubType;
        public System.String IndustrySubType
        {
            get { return industrySubType; }
            set { industrySubType = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.String issuanceOnly;
        public System.String IssuanceOnly
        {
            get { return issuanceOnly; }
            set { issuanceOnly = value; }
        }
        private System.Int32 serviceListSeq;
        public System.Int32 ServiceListSeq
        {
            get { return serviceListSeq; }
            set { serviceListSeq = value; }
        }

        //added on 28 Mar 2012 by Harita Munagala for Notification List Subscription
        private System.String fillIssuanceOnly;
        public System.String FillIssuanceOnly
        {
            get { return fillIssuanceOnly; }
            set { fillIssuanceOnly = value; }
        }

        private System.String commIssuanceOnly;
        public System.String CommIssuanceOnly
        {
            get { return commIssuanceOnly; }
            set { commIssuanceOnly = value; }
        }

        private System.String drIssuanceOnly;
        public System.String DRIssuanceOnly
        {
            get { return drIssuanceOnly; }
            set { drIssuanceOnly = value; }
        }
        //end

        //Added By SUnayana Saxena DEFW264 26 august 2014
        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }
        //End - Added By SUnayana Saxena DEFW264 26 august 2014
    }
}
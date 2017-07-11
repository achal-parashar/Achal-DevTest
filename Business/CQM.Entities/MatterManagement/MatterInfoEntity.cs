//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/22/2007
// Description: Matter Info Entity
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
    /// This entity class stores the information about Matter Information Entity
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-11-22</ceationDate>
    /// <modifications>
    /// <item>2008-02-02;Ritika Fakay;Added comments</item>
    /// <item></item>
    /// </modifications>
    
    public class MatterInfoEntity
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

        private System.String industryAffected;
        public System.String IndustryAffected
        {
            get { return industryAffected; }
            set { industryAffected = value; }
        }

        private System.String county;
        public System.String County
        {
            get { return county; }
            set { county = value; }
        }

        private System.String municipality;
        public System.String Municipality
        {
            get { return municipality; }
            set { municipality = value; }
        }

        private System.DateTime exptCompDate;
        public System.DateTime ExptCompDate
        {
            get { return exptCompDate; }
            set { exptCompDate = value; }
        }

        private System.String sAPAReq;
        public System.String SAPAReq
        {
            get { return sAPAReq; }
            set { sAPAReq = value; }
        }

        private System.String statusNotes;
        public System.String StatusNotes
        {
            get { return statusNotes; }
            set { statusNotes = value; }
        }

        private List<System.String> franchiseeNames = new List<System.String>();
        public List<System.String> FranchiseeNames
        {
            get { return franchiseeNames; }
            set { franchiseeNames = value; }
        }

        private System.String title;
        public System.String Title
        {
            get { return title; }
            set { title = value; }
        }

        private CodeNameEntity status;
        public CodeNameEntity Status
        {
            get { return status; }
            set { status = value; }
        }


        private List<IDNameEntity> companyIDNames = new List<IDNameEntity>();
        public List<IDNameEntity> CompanyIDNames
        {
            get { return companyIDNames; }
            set { companyIDNames = value; }
        }

        private List<IDNameEntity> relatedMatterIDNos = new List<IDNameEntity>();
        public List<IDNameEntity> RelatedMatterIDNos
        {
            get { return relatedMatterIDNos; }
            set { relatedMatterIDNos = value; }
        }

        //add by jatin
        private System.Decimal countyID;
        public System.Decimal CountyID
        {
            get { return countyID; }
            set { countyID = value; }
        }

        private System.String matterSubTypeID;
        public System.String MatterSubTypeID
        {
            get { return matterSubTypeID; }
            set { matterSubTypeID = value; }
        }

        private System.Decimal municipalityID;
        public System.Decimal MunicipalityID
        {
            get { return municipalityID; }
            set { municipalityID = value; }
        }
        //Added By Ajeet
        private System.String hearingRequired;
        public System.String HearingRequired
        {
            get { return hearingRequired; }
            set { hearingRequired = value; }
        }
        private System.String elevateToCase;
        public System.String ElevateToCase
        {
            get { return elevateToCase; }
            set { elevateToCase = value; }
        }
        private System.Decimal industrySeq;
        public System.Decimal IndustrySeq
        {
            get { return industrySeq; }
            set { industrySeq = value; }

        }
        private System.String autoClose;
        public System.String AutoClose
        {
            get { return autoClose; }
            set { autoClose = value; }
        }
        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private System.DateTime updatedDate;
        public System.DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }
        private System.String comments;
        public System.String Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        private System.String isExternal;
        public System.String IsExternal
        {
            get { return isExternal; }
            set { isExternal = value; }
        }

        private System.DateTime filedDate;
        public System.DateTime FiledDate
        {
            get { return filedDate; }
            set { filedDate = value; }
        }

        private ReferenceEntity objReferenceEntity;
        public ReferenceEntity ObjReferenceEntity
        {
            get { if (objReferenceEntity == null) objReferenceEntity = new ReferenceEntity(); return objReferenceEntity; }
            set { objReferenceEntity = value; }
        }
        
        private List<ReferenceEntity> objReferenceEntityList;
        public List<ReferenceEntity> ObjReferenceEntityList
        {
            get { if (objReferenceEntityList == null)objReferenceEntityList = new List<ReferenceEntity>(); return objReferenceEntityList; }
            set { objReferenceEntityList = value; }
        }

        private System.String industrySubtype;
        public System.String IndustrySubtype
        {
            get { return industrySubtype; }
            set { industrySubtype = value; }
        }
        private System.String industryTypeCode;
        public System.String IndustryTypeCode
        {
            get { return industryTypeCode; }
            set { industryTypeCode = value; }
        }
        private System.DateTime startDate;
        public System.DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private System.DateTime minDateFiled;
        public System.DateTime MinDateFiled
        {
            get { return minDateFiled; }
            set { minDateFiled = value; }
        }

        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }
        private System.Decimal retentionPeriod;
        public System.Decimal RetentionPeriod
        {
            get { return retentionPeriod; }
            set { retentionPeriod = value; }
        }
        private System.DateTime expectedArchieveDate;
        public System.DateTime ExpectedArchieveDate
        {
            get { return expectedArchieveDate; }
            set { expectedArchieveDate = value; }
        }
        private System.DateTime actualArchieveDate;
        public System.DateTime ActualArchieveDate
        {
            get { return actualArchieveDate; }
            set { actualArchieveDate = value; }
        }
        private System.DateTime physicalArchieveDate;
        public System.DateTime PhysicalArchieveDate
        {
            get { return physicalArchieveDate; }
            set { physicalArchieveDate = value; }
        }
        private System.String isAdjudicatory;
        public System.String IsAdjudicatory
        {
            get { return isAdjudicatory; }
            set { isAdjudicatory = value; }
        }
        private System.String isSecured;
        public System.String IsSecured
        {
            get { return isSecured; }
            set { isSecured = value; }
        }
        private System.String cADCaseNumber;
        public System.String CADCaseNumber
        {
            get { return cADCaseNumber; }
            set { cADCaseNumber = value; }
        }
        private System.String cadCaseTypecode;
        public System.String CadCaseTypecode
        {
            get { return cadCaseTypecode; }
            set { cadCaseTypecode = value; }
        }
        private System.String industrySubtypeCode;
        public System.String IndustrySubtypeCode
        {
            get { return industrySubtypeCode; }
            set { industrySubtypeCode = value; }
        }
    }
}

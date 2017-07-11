//---------------------------------------------------------------------
// Author: Rajani Gandha Patra
// Version: 1.0.0
// Date: 09/08/2011
// Description:TariffSearchResultEntity Class
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about TariffSearchResultEntity  property of any Entity specified.
    /// </summary>
    /// <author>Rajani Patra</author>
    /// <creationDate>2011-08-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class TariffSearchResultEntity
    {        
        private System.String tariffBookID;
        public System.String TariffBookID
        {
            get { return tariffBookID; }
            set { tariffBookID = value; }
        }
        private System.String industryType;
        public System.String IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        private System.String industrySubType;
        public System.String IndustrySubType
        {
            get { return industrySubType; }
            set { industrySubType = value; }
        }
        private System.String companySeq;
        public System.String CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }
        private System.String filedById;
        public System.String FiledById
        {
            get { return filedById; }
            set { filedById = value; }
        }
        private System.String trfType;
        public System.String TrfType
        {
            get { return trfType; }
            set { trfType = value; }
        }
        private System.String rateSectionName;
        public System.String RateSectionName
        {
            get { return rateSectionName; }
            set { rateSectionName = value; }
        }
        private System.String caseSeq;
        public System.String CaseSeq
        {
            get { return caseSeq; }
            set { caseSeq = value; }
        }
        private System.String expTariffChange;
        public System.String ExpTariffChange
        {
            get { return expTariffChange; }
            set { expTariffChange = value; }
        }
        private System.String rateSecDesc;
        public System.String RateSecDesc
        {
            get { return rateSecDesc; }
            set { rateSecDesc = value; }
        }
        private System.String effDate;
        public System.String EffDate
        {
            get { return effDate; }
            set { effDate = value; }
        }
        private System.String trfSubDtlStatus;
        public System.String TrfSubDtlStatus
        {
            get { return trfSubDtlStatus; }
            set { trfSubDtlStatus = value; }
        }
        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        private System.DateTime createdDate;
        public System.DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        private System.DateTime updatedDate;
        public System.DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }

        //Vivek-Dec-12-2011: Data type changed from system.Datatime to system.Int32
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String property1;
        public System.String Property1
        {
            get { return property1; }
            set { property1 = value; }
        }

       private System.DateTime lastRevisedDate; 
        public System.DateTime LastRevisedDate 
        { 
            get { return lastRevisedDate; } 
            set { lastRevisedDate = value; } 
        } 
        private System.DateTime cancellationDate; 
        public System.DateTime CancellationDate 
        { 
            get { return cancellationDate; } 
            set { cancellationDate = value; } 
        } 

        
    }
}

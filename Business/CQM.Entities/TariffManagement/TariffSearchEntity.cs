//---------------------------------------------------------------------
// Author: Rajani Gandha Patra
// Version: 1.0.0
// Date: 09/08/2011
// Description:TariffSearchEntity Class
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
    /// This entity class stores the information about TariffSearchEntity  property of any Entity specified.
    /// </summary>
    /// <author>Rajani Patra</author>
    /// <creationDate>2011-08-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
   public class TariffSearchEntity
    {
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
        private System.String rateSecDesc;
        public System.String RateSecDesc
        {
            get { return rateSecDesc; }
            set { rateSecDesc = value; }
        }        
        private System.String trfSubDtlStatus;
        public System.String TrfSubDtlStatus
        {
            get { return trfSubDtlStatus; }
            set { trfSubDtlStatus = value; }
        }
        private System.Int32 pageSize;
        public System.Int32 PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
        private System.Int32 pageNumber;
        public System.Int32 PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }
        private System.String sortBy;
        public System.String SortBy
        {
            get { return sortBy; }
            set { sortBy = value; }
        }
    }
}

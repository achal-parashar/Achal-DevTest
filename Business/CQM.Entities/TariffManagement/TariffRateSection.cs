//---------------------------------------------------------------------
// Author: Rajani Gandha Patra
// Version: 1.0.0
// Date: 08/05/2011
// Description:TariffRateSection Class
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
    /// This entity class stores the information about TariffRateSection  property of any Entity specified.
    /// </summary>
    /// <author>Rajani Patra</author>
    /// <creationDate>2011-08-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class TariffRateSection
    {
        private System.Int32 trfBookID;
        public System.Int32 TrfBookID
        {
            get { return trfBookID; }
            set { trfBookID = value; }
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

        //Vivek-Dec-28-2012
        private System.String _tariffNumber;
        public System.String TariffNumber
        {
            get { return _tariffNumber; }
            set { _tariffNumber = value; }
        }

        private System.Int32 _tariffDtlNumber;
        public System.Int32 TariffDtlNumber
        {
            get { return _tariffDtlNumber; }
            set { _tariffDtlNumber = value; }
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
        //End
    }
}

//---------------------------------------------------------------------
// Author: Amarendra
// Version: 1.0.0
// Date: 11/01/2011
// Description:Implement Annual Report CEP Subutility Type Class Sales Properties
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Annual Report CEP Subutility Type Class Sales.
    /// </summary>
    /// <author>Amarendra</author>
    /// <creationDate>2011-11-01</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>

    public struct ClassSalesStruct
    {
        private decimal? classSalesI;
        public decimal? ClassSalesI
        {
            get { return Common.Utility.Common.Round(classSalesI); }
            set { classSalesI = value; }
        }
        private decimal? classSalesII;
        public decimal? ClassSalesII
        {
            get { return Common.Utility.Common.Round(classSalesII); }
            set { classSalesII = value; }
        }
        private string sectionType;
        public string SectionType
        {
            get { return sectionType; }
            set { sectionType = value; }
        }
        private string fieldName;
        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }
        private string fieldValue;
        public string FieldValue
        {
            get { return fieldValue; }
            set { fieldValue = value; }
        }
        private System.String sNo;
        public System.String SNo
        {
            get { return sNo; }
            set { sNo = value; }
        }

    }
}

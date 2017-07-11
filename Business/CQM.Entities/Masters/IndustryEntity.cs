//---------------------------------------------------------------------
// Author: Ajeet Kumar
// Version: 1.0.0
// Date: 10/22/2007
// Description: Industry Master Entity
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
    /// This entity class stores the information about Industry.
    /// </summary>
    /// <author>Ajeet Kumar</author>
    /// <creationDate>2007-10-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
	public class IndustryEntity
	{
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

        private System.String industryInitial;
        public System.String IndustryInitial
        {
            get { return industryInitial; }
            set { industryInitial = value; }
        }

        private System.Decimal industrySeq;
        public System.Decimal IndustrySeq
        {
            get { return industrySeq; }
            set { industrySeq = value; }
        }



        private System.String industrycode;
        public System.String Industry_Type_Code
        {
            get { return industrycode; }
            set { industrycode = value; }
        }

        private System.String industryType;
        public System.String IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }

        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
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
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

	}

}

       


//---------------------------------------------------------------------
// Author: Ajeet Kumar
// Version: 1.0.0
// Date: 10/22/2007
// Description: Franchise Master Entity
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
    /// This entity class stores the information about Franchise.
    /// </summary>
    /// <author>Ajeet Kumar</author>
    /// <creationDate>2007-10-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class FranchiseEntity
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

        private System.Decimal franchiseSeq;
        public System.Decimal FranchiseSeq
        {
            get { return franchiseSeq; }
            set { franchiseSeq = value; }
        }

        private System.String franchiseUnit;
        public System.String FranchiseUnit
        {
            get { return franchiseUnit; }
            set { franchiseUnit = value; }
        }

        private System.Decimal companySeq;
        public System.Decimal CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }
        private System.String companyOrgName;
        public System.String CompanyOrgName
        {
            get { return companyOrgName; }
            set { companyOrgName = value; }
        }

        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        private System.Decimal municipalitySeq;
        public System.Decimal MunicipalitySeq
        {
            get { return municipalitySeq; }
            set { municipalitySeq = value; }
        }
        private System.String municipalityArea;
        public System.String MunicipalityArea
        {
            get { return municipalityArea; }
            set { municipalityArea = value; }
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

        private System.Decimal cableSystemSeq;
        public System.Decimal CableSystemSeq
        {
            get { return cableSystemSeq; }
            set { cableSystemSeq = value; }
        }

        private System.String cableSystemName;
        public System.String CableSystemName
        {
            get { return cableSystemName; }
            set { cableSystemName = value; }
        }
        private System.DateTime certExpDate;
        public System.DateTime CertExpDate
        {
            get { return certExpDate; }
            set { certExpDate = value; }
        }

        private System.DateTime demiseDate;
        public System.DateTime DemiseDate
        {
            get { return demiseDate; }
            set { demiseDate = value; }
        }

        private System.String fccNo;
        public System.String FccNo
        {
            get { return fccNo; }
            set { fccNo = value; }
        }

        private System.DateTime franchiseExpDate;
        public System.DateTime FranchiseExpDate
        {
            get { return franchiseExpDate; }
            set { franchiseExpDate = value; }
        }

        private System.String isExempted;
        public System.String IsExempted
        {
            get { return isExempted; }
            set { isExempted = value; }
        }

        private System.String notes;
        public System.String Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        private System.DateTime toaExpDate;
        public System.DateTime ToaExpDate
        {
            get { return toaExpDate; }
            set { toaExpDate = value; }
        }

        private System.DateTime toaGrantDate;
        public System.DateTime ToaGrantDate
        {
            get { return toaGrantDate; }
            set { toaGrantDate = value; }
        }

        private System.String toaUserId;
        public System.String ToaUserId
        {
            get { return toaUserId; }
            set { toaUserId = value; }
        }

        private System.String toaUserName;
        public System.String ToaUserName
        {
            get { return toaUserName; }
            set { toaUserName = value; }
        }

        private System.String franchiseNotes;
        public System.String FranchiseNotes
        {
            get { return franchiseNotes; }
            set { franchiseNotes = value; }
        }

        private System.String franchiseDeleteNotes;
        public System.String FranchiseDeleteNotes
        {
            get { return franchiseDeleteNotes; }
            set { franchiseDeleteNotes = value; }
        }

        private System.Decimal countySeq;
        public System.Decimal CountySeq
        {
            get { return countySeq; }
            set { countySeq = value; }
        }
        private System.String countyName;
        public System.String CountyName
        {
            get { return countyName; }
            set { countyName = value; }
        }
    }

}

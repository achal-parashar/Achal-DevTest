//---------------------------------------------------------------------
// Author: Mohit Vashishtha
// Version: 1.0.0
// Date: 12/02/2011
// Description: Reference Master Entity
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    public class ReferenceEntity
    {
        /// <summary>
        /// This entity class stores the information about Industry Subtype.
        /// </summary>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>06/22/2011</ceationDate>
        /// <modifications>
        /// <item></item>
        /// <item></item>
        /// </modifications>
        /// 
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

        private System.Decimal referenceSeq;
        public System.Decimal ReferenceSeq
        {
            get { return referenceSeq; }
            set { referenceSeq = value; }
        }

        private System.Decimal matterSeq;
        public System.Decimal MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
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

        private System.String isMPUC;
        public System.String IsMPUC
        {
            get { return isMPUC; }
            set { isMPUC = value; }
        }
        private System.String isStatutory;
        public System.String IsStatutory
        {
            get { return isStatutory; }
            set { isStatutory = value; }
        }

        private System.String referenceTitle;
        public System.String ReferenceTitle
        {
            get { return referenceTitle; }
            set { referenceTitle = value; }
        }

        private System.String referenceSection;
        public System.String ReferenceSection
        {
            get { return referenceSection; }
            set { referenceSection = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

    }
}

//---------------------------------------------------------------------
// Author: Ashish Mamodia
// Version: 1.0.0
// Date: 06/03/2011
// Description: Tickler Entity
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
    /// This entity class stores the information about tickler.
    /// </summary>
    /// <author>Ashish Mamodia</author>
    /// <creationDate>2011-06-03</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    
    public class TicklerEntity
    {               
        private System.Decimal ticklerSeq;
        public System.Decimal TicklerSeq
        {
            get { return ticklerSeq; }
            set { ticklerSeq = value; }
        }
        private System.String ticklerDesc;
        public System.String TicklerDesc
        {
            get { return ticklerDesc; }
            set { ticklerDesc = value; }
        }
        private System.String ticklerSentTo;
        public System.String TicklerSentTo
        {
            get { return ticklerSentTo; }
            set { ticklerSentTo = value; }
        }
        private System.String ticklerSentBy;
        public System.String TicklerSentBy
        {
            get { return ticklerSentBy; }
            set { ticklerSentBy = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.String ticklerNotes;
        public System.String TicklerNotes
        {
            get { return ticklerNotes; }
            set { ticklerNotes = value; }
        }
        private System.DateTime followupDate;
        public System.DateTime FollowupDate
        {
            get { return followupDate; }
            set { followupDate = value; }
        }
        private System.String releaseInd;
        public System.String ReleaseInd
        {
            get { return releaseInd; }
            set { releaseInd = value; }
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
        private System.Decimal ticklerSentBySeq;
        public System.Decimal TicklerSentBySeq
        {
            get { return ticklerSentBySeq; }
            set { ticklerSentBySeq = value; }
        }
    }
}

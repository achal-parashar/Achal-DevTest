//---------------------------------------------------------------------
// Version: 1.0.0
// Date: 04/03/2008
// Author: Krishan Kumar Aishpunani
// Description: The MatterDetailEntity class stores the information about Matter Details.

// History:
// Changed By                       Changed On   
//---------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;

namespace CQM.Entities
{
    /// <summary>
    /// The MatterDetailEntity class stores the information about Matter Details.
    /// </summary>
    /// <author> Krishan Kumar Aishpunani</author>
    /// <creationDate>2008-03-04</ceationDate>
    /// <modifications>
    /// <item></item>
    /// </modifications>

    public class MatterDetailEntity
    {
        private System.String matterNumber;
        public System.String MatterNumber
        {
            get { return matterNumber; }
            set { matterNumber = value; }
        }
        private System.String matterTitle;
        public System.String MatterTitle
        {
            get { return matterTitle; }
            set { matterTitle = value; }
        }
        private System.Decimal matterID;
        public System.Decimal MatterID
        {
            get { return matterID; }
            set { matterID = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.String caseMatterNumber;
        public System.String CaseMatterNumber
        {
            get { return caseMatterNumber; }
            set { caseMatterNumber = value; }
        }
        private decimal matterContactListSeq;
        public System.Decimal MatterContactListSeq
        {
            get { return matterContactListSeq; }
            set { matterContactListSeq = value; }
        }
        private decimal serviceListSeq;
        public System.Decimal ServiceListSeq
        {
            get { return serviceListSeq; }
            set { serviceListSeq = value; }
        }
        private System.String serviceListSubUpdate;
        public System.String ServiceListSubUpdate
        {
            get { return serviceListSubUpdate; }
            set { serviceListSubUpdate = value; }
        }
        private System.String issuanceOnly;
        public System.String IssuanceOnly
        {
            get { return issuanceOnly; }
            set { issuanceOnly = value; }
        }
        private System.String postComment;
        public System.String PostComment
        {
            get { return postComment; }
            set { postComment = value; }
        }
        private System.Int32 totalRecord;
        public System.Int32 TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        }
        private System.String onlyFiling;
        public System.String OnlyFiling
        {
            get { return onlyFiling; }
            set { onlyFiling = value; }
        }
        private System.String subscribeDr;
        public System.String SubscribeDr
        {
            get { return subscribeDr; }
            set { subscribeDr = value; }
        }
    }
}

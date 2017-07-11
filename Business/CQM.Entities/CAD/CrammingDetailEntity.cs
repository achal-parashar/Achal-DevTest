//---------------------------------------------------------------------
// Author: Yugal Kishore  
// Version: 1.0.0
// Date: 31/May/2011
// Description: Cramming Detail Entity
//
// History:
// Changed By          
// Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Cramming details.
    /// </summary>
    /// <author>Yugal Kishore</author>
    /// <creationDate>2011-31-May</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
  public class CrammingDetailEntity
    {
        private System.Decimal crammingDetailSeq;
        public System.Decimal CrammingDetailSeq
        {
            get { return crammingDetailSeq; }
            set { crammingDetailSeq = value; }
        }
        private System.String issueTypeSeq;
        public System.String IssueTypeSeq
        {
            get { return issueTypeSeq; }
            set { issueTypeSeq = value; }
        }
        private System.String issueQuestionSeq;
        public System.String IssueQuestionSeq
        {
            get { return issueQuestionSeq; }
            set { issueQuestionSeq = value; }
        }
        private System.String yesNo;
        public System.String YesNo
        {
            get { return yesNo; }
            set { yesNo = value; }
        }
        private System.String comment;
        public System.String Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        private System.Int32 isdeleted;
        public System.Int32 IsDeleted
        {
            get { return isdeleted; }
            set { isdeleted = value; }
        }
        private System.String createdby;
        public System.String CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private System.DateTime createddate;
        public System.DateTime CreatedDate
        {
            get { return createddate; }
            set { createddate = value; }
        }
        private System.String updatedby;
        public System.String UpdatedBy
        {
            get { return updatedby; }
            set { updatedby = value; }
        }
        private System.DateTime updateddate;
        public System.DateTime UpdateDate
        {
            get { return updateddate; }
            set { updateddate = value; }
        }
        private System.String issueTypeDesc;
        public System.String IssueTypeDesc
        {
            get { return issueTypeDesc; }
            set { issueTypeDesc = value; }
        }
        private System.String issueQuestionDesc;
        public System.String IssueQuestionDesc
        {
            get { return issueQuestionDesc; }
            set { issueQuestionDesc = value; }
        }
    }
}

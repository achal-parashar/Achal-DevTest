using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQM.Entities
{
    public class IssueQuestionEntity
    {
        private System.Decimal issueQuestionSeq;
        public System.Decimal IssueQuestionSeq
        {
            get { return issueQuestionSeq; }
            set { issueQuestionSeq = value; }
        }

        private System.String issueQuestion;
        public System.String IssueQuestion
        {
            get { return issueQuestion; }
            set { issueQuestion = value; }
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
        private System.Int32 issueSeq;
        public System.Int32 IssueSeq
        {
            get { return issueSeq; }
            set { issueSeq = value; }
        }
        private string issue;
        public string Issue
        {
            get { return issue; }
            set { issue = value; }
        }
    }
}

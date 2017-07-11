using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    public class NoticeTypeEntity
    {
        /// <summary>
        /// This entity class stores the information about Notice Type.
        /// </summary>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-05-24</ceationDate>
        /// <modifications>
        /// <item></item>
        /// <item></item>
        /// </modifications>
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

        private System.String noticeTypeDesc;
        public System.String NoticeTypeDesc
        {
            get { return noticeTypeDesc; }
            set { noticeTypeDesc = value; }
        }

        private System.String noticeTypeCode;
        public System.String NoticeTypeCode
        {
            get { return noticeTypeCode; }
            set { noticeTypeCode = value; }
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
        private System.Decimal noticeSeq;
        public System.Decimal NoticeSeq
        {
            get { return noticeSeq; }
            set { noticeSeq = value; }
        }
    }
}

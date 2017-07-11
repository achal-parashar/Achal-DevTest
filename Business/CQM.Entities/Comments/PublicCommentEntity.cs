//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 07/05/2009
// Description:  Public Comments Entity.
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
    /// This entity class count the records for Public Comments page.
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>07/05/2009</creationDate>
    /// <modifications>
    /// </modifications>
    /// 
    public class PublicCommentEntity
    {
        private System.Int32 commentSeq;
        public System.Int32 CommentSeq
        {
            get { return commentSeq; }
            set { commentSeq = value; }
        }

        private System.Int32 matterSeq;
        public System.Int32 MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
        }

        private System.String matterCaseNumber;
        public System.String MatterCaseNumber
        {
            get { return matterCaseNumber; }
            set { matterCaseNumber = value; }
        }
        private System.String attachmentString;
        public System.String AttachmentString
        {
            get { return attachmentString; }
            set { attachmentString = value; }
        }
        private System.String commentText;
        public System.String CommentText
        {
            get { return commentText; }
            set { commentText = value; }
        }
        private System.String commentStatus;
        public System.String CommentStatus
        {
            get { return commentStatus; }
            set { commentStatus = value; }
        }
        private System.String postedBy;
        public System.String PostedBy
        {
            get { return postedBy; }
            set { postedBy = value; }
        }
        private List<CommentAttachmentEntity> attachments;
        public List<CommentAttachmentEntity> Attachments
        {
            get { return attachments; }
            set { attachments = value; }
        }

        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private System.DateTime submittedDate;
        public System.DateTime SubmittedDate
        {
            get { return submittedDate; }
            set { submittedDate = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String isPublicComment;
        public System.String IsPublicComment
        {
            get { return isPublicComment; }
            set { isPublicComment = value; }
        }

        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }

        private System.String name;
        public System.String Name
        {
            get { return name; }
            set { name = value; }
        }

        private System.String address;
        public System.String Address
        {
            get { return address; }
            set { address = value; }
        }

        private System.String phone;
        public System.String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private System.String emailID;
        public System.String EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }

        private System.String company;
        public System.String Company
        {
            get { return company; }
            set { company = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        private string associatedMatter;
        public string AssociatedMatters
        {
            get { return associatedMatter; }
            set { associatedMatter = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.String workStatus;
        public System.String WorkStatus
        {
            get { return workStatus; }
            set { workStatus = value; }
        }
        private System.Int32 totalCount;
        public System.Int32 TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        private System.Int32 count;
        public System.Int32 Count
        {
            get { return count; }
            set { count = value; }
        }

        public void SetValues(System.Data.IDataReader dtReader)
        {
            string fieldName;
            try
            {
                if (dtReader != null)
                {
                    for (int index = 0; index <= dtReader.FieldCount - 1; index++)
                    {
                        if (!dtReader.IsDBNull(index))
                        {
                            fieldName = dtReader.GetName(index);
                            switch (fieldName)
                            {
                                case "POSTED_BY":
                                    PostedBy = Convert.ToString(dtReader[index]);
                                    break;
                                case "ATTACHMENTS":
                                    AttachmentString = Convert.ToString(dtReader[index]);

                                    List<CommentAttachmentEntity> ObjAttachments = new List<CommentAttachmentEntity>();
                                    string strAttachments = AttachmentString;
                                    if (strAttachments.IndexOf(';') > 0)
                                    {
                                        string[] strArrAttachments = strAttachments.Split(';');
                                        for (int i = 0; i < strArrAttachments.Length; i++)
                                        {
                                            string[] strAttachment = strArrAttachments[i].Split('^');
                                            CommentAttachmentEntity ObjAttachment = new CommentAttachmentEntity();
                                            ObjAttachment.AttachmentExtension = strAttachment[2];
                                            ObjAttachment.AttachmentName = strAttachment[0];
                                            ObjAttachment.AttachmentRefNo = strAttachment[1];
                                            ObjAttachments.Add(ObjAttachment);
                                        }
                                    }
                                    else if (strAttachments.IndexOf('^') > 0)
                                    {
                                        string[] strAttachment = strAttachments.Split('^');
                                        CommentAttachmentEntity ObjAttachment = new CommentAttachmentEntity();
                                        ObjAttachment.AttachmentExtension = strAttachment[2];
                                        ObjAttachment.AttachmentName = strAttachment[0];
                                        ObjAttachment.AttachmentRefNo = strAttachment[1];
                                        ObjAttachments.Add(ObjAttachment);
                                    }
                                    Attachments = ObjAttachments;
                                    
                                    break;
                                case "IS_PUBLIC":
                                    IsPublicComment = Convert.ToString(dtReader[index]);
                                    break;
                                case "COMMENT_SEQ":
                                    CommentSeq = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "CASE_NUMBER":
                                    CaseNumber = Convert.ToString(dtReader[index]);
                                    break;
                                case "SUBMITTED_DATE":
                                    SubmittedDate = Convert.ToDateTime(dtReader[index]);
                                    break;
                                case "COMMENT_TEXT":
                                    CommentText = Convert.ToString(dtReader[index]);
                                    break;
                                case "TOTALCOUNT":
                                    TotalCount = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "COUNT":
                                    Count = Convert.ToInt32(dtReader[index]);
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

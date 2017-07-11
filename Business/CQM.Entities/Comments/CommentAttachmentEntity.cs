//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 07/05/2009
// Description:  Public Comments attachment Entity.
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
    public class CommentAttachmentEntity
    {
        private System.Int32 attachmentSeq;
        public System.Int32 AttachmentSeq
        {
            get { return attachmentSeq; }
            set { attachmentSeq = value; }
        }
        private System.String attachmentName;
        public System.String AttachmentName
        {
            get { return attachmentName; }
            set { attachmentName = value; }
        }
        private System.String attachmentRefNo;
        public System.String AttachmentRefNo
        {
            get { return attachmentRefNo; }
            set { attachmentRefNo = value; }
        }
        private System.String attachmentExtension;
        public System.String AttachmentExtension
        {
            get { return attachmentExtension; }
            set { attachmentExtension = value; }
        }
        private string guidName;        
        public string GuidName
        {
            get { return guidName; }
            set { guidName = value; }
        } 
        private decimal size;
        public decimal Size
        {
            get { return size; }
            set { size = value; }
        }
        private string displaySize;
        public string DisplaySize
        {
            get { return displaySize; }
            set { displaySize = value; }
        }

        private string createdBy;
        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private System.String attachmentFileName;
        public System.String AttachmentFileName
        {
            get { return attachmentFileName; }
            set { attachmentFileName = value; }
        }
        private System.String extension;
        public System.String Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        
    }
}

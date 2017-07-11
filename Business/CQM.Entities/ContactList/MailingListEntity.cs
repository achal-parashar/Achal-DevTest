//---------------------------------------------------------------------
// Author: Suruchi Saxena
// Version: 1.0.0
// Date: 11/01/2011
// Description: Represents a Mailing List Entity.
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

namespace CQM.Entities
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a MailingListEntity object.
    /// </summary>
    /// <author>Suruchi Saxena</author>
    /// <creationDate>11/01/2011</ceationDate>
    /// <modifications>
    /// <item>Date ;By ;Description</item>
    /// <item>Date ;By ;Description</item>
    /// </modifications>
    public class MailingListEntity
    {
        private System.String mlistDesc;
        public System.String MlistDesc
        {
            get { return mlistDesc; }
            set { mlistDesc = value; }
        }

        private System.String mlistName;
        public System.String MlistName
        {
            get { return mlistName; }
            set { mlistName = value; }
        }

        private System.Int32 mlistNum;
        public System.Int32 MlistNum
        {
            get { return mlistNum; }
            set { mlistNum = value; }
        }

        private System.Int32 mlistSeq;
        public System.Int32 MlistSeq
        {
            get { return mlistSeq; }
            set { mlistSeq = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        //Not required- To be removed
        private System.Int32 matterSeq;
        public System.Int32 MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
        }
        //End- Not Required
        private System.String editImage;
        public System.String EditImage
        {
            get { return editImage; }
            set { editImage = value; }
        }

        private System.String deleteImage;
        public System.String DeleteImage
        {
            get { return deleteImage; }
            set { deleteImage = value; }
        }

        private System.String addMemberImage;
        public System.String AddMemberImage
        {
            get { return addMemberImage; }
            set { addMemberImage = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private System.String createdDate;
        public System.String CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private System.String updatedDate;
        public System.String UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }

        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }
        //Added by Suruchi
        private System.String casenumber;
        public System.String CaseNumber
        {
            get { return casenumber; }
            set { casenumber = value; }
        }
    }
}

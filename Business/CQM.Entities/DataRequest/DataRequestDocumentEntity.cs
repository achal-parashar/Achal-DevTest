//---------------------------------------------------------------------
// Author: Hans Yadav
// Version: 1.0.0
// Date: 15/09/2010
// Description: This Entity is  used for storing the documents values used in Data Request.
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------


namespace CQM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ServiceModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a DataRequestDocumentEntity object.
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    public class DataRequestDocumentEntity
    {
        private System.String createdBy;
        [DataMember]
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private System.DateTime createdDate;
        [DataMember]
        public System.DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private System.String documentExtn;
        [DataMember]
        public System.String DocumentExtn
        {
            get { return documentExtn; }
            set { documentExtn = value; }
        }

        private System.String documentName;
        [DataMember]
        public System.String DocumentName
        {
            get { return documentName; }
            set { documentName = value; }
        }

        private System.String documentRefNo;
        [DataMember]
        public System.String DocumentRefNo
        {
            get { return documentRefNo; }
            set { documentRefNo = value; }
        }

        private System.Int32 documentSeq;
        [DataMember]
        public System.Int32 DocumentSeq
        {
            get { return documentSeq; }
            set { documentSeq = value; }
        }

        private System.Int32 documentSize;
        [DataMember]
        public System.Int32 DocumentSize
        {
            get { return documentSize; }
            set { documentSize = value; }
        }

        private System.Int32 documentTypeSeq;
        [DataMember]
        public System.Int32 DocumentTypeSeq
        {
            get { return documentTypeSeq; }
            set { documentTypeSeq = value; }
        }

        private System.Int32 drQuesSeq;
        [DataMember]
        public System.Int32 DRQuesSeq
        {
            get { return drQuesSeq; }
            set { drQuesSeq = value; }
        }

        private System.Int32 drRespSeq;
        [DataMember]
        public System.Int32 DRRespSeq
        {
            get { return drRespSeq; }
            set { drRespSeq = value; }
        }

        private System.Decimal drSetSeq;
        [DataMember]
        public System.Decimal DRSetSeq
        {
            get { return drSetSeq; }
            set { drSetSeq = value; }
        }

        private System.String drType;
        [DataMember]
        public System.String DRType
        {
            get { return drType; }
            set { drType = value; }
        }

        private System.String isConfidential;
        [DataMember]
        public System.String IsConfidential
        {
            get { return isConfidential; }
            set { isConfidential = value; }
        }

        private System.Decimal mimeTypeSeq;
        [DataMember]
        public System.Decimal MimeTypeSeq
        {
            get { return mimeTypeSeq; }
            set { mimeTypeSeq = value; }
        }

        [DataMember]
        public System.String MimeTypeImagePath { get; set; }

         [DataMember]
        public System.String DocTitle { get; set; }

        
         [DataMember]
         public System.String SecurityImageDisplay { get; set; }

        [DataMember]
         public System.String JustificationDocSecurity { get; set; }

        [DataMember]
        public System.String GUIDFileName { get; set; }

       
        [DataMember]
        public System.Int32 DocId{ get; set; }

        [DataMember]
        public System.String POrders { get; set; }

        [DataMember]
        public System.String FILENET_REF_NO { get; set; }
       
    }
}

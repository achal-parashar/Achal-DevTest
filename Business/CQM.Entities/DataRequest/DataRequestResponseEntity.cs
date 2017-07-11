//---------------------------------------------------------------------
// Author: Hans Yadav
// Version: 1.0.0
// Date: 15/09/2010
// Description: This Entity is used for storing the DR Responses to the questions
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
    /// Represents a DataRequestResponseEntity object.
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    public class DataRequestResponseEntity
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

        private System.String isAttachment;
        [DataMember]
        public System.String IsAttachment
        {
            get { return isAttachment; }
            set { isAttachment = value; }
        }

        private System.String isDeleted;
        [DataMember]
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        private System.String respText;
        [DataMember]
        public System.String RespText
        {
            get { return respText; }
            set { respText = value; }
        }

        private System.String reviewedBy;
        [DataMember]
        public System.String ReviewedBy
        {
            get { return reviewedBy; }
            set { reviewedBy = value; }
        }

        private System.String status;
        [DataMember]
        public System.String Status
        {
            get { return status; }
            set { status = value; }
        }

        private System.String submittedBy;
        [DataMember]
        public System.String SubmittedBy
        {
            get { return submittedBy; }
            set { submittedBy = value; }
        }

        private System.String updatedBy;
        [DataMember]
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private System.DateTime updatedDate;
        [DataMember]
        public System.DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }

        private List<DataRequestDocumentEntity> drDocumentEntityList = new List<DataRequestDocumentEntity>();
        [DataMember]
        public List<DataRequestDocumentEntity> DRDocumentEntityList
        {
            get { return drDocumentEntityList; }
            set { drDocumentEntityList = value; }
        }

        private System.Int32 drSupplQuesSeq;
        [DataMember]
        public System.Int32 DRSupplQuesSeq
        {
            get { return drSupplQuesSeq; }
            set { drSupplQuesSeq = value; }
        }

        private System.String procType;
        [DataMember]
        public System.String ProcType
        {
            get { return procType; }
            set { procType = value; }
        }
    }

}
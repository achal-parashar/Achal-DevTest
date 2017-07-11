//---------------------------------------------------------------------
// Author: Hans Yadav
// Version: 1.0.0
// Date: 15/09/2010
// Description: This Entity is used for storing the DR Supplimental Questions information.
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
    /// Represents a DataRequestSupplQuestionEntity object.
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    public class DataRequestSupplQuestionEntity
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

        private System.Int32 drSupplQuesSeq;
        [DataMember]
        public System.Int32 DRSupplQuesSeq
        {
            get { return drSupplQuesSeq; }
            set { drSupplQuesSeq = value; }
        }

        private System.String isDeleted;
        [DataMember]
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        private System.String supplQuesText;
        [DataMember]
        public System.String SupplQuesText
        {
            get { return supplQuesText; }
            set { supplQuesText = value; }
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
        //Added By Anuj For CQM120----Start
        public List<DataRequestDocumentEntity> drDocumentEntityList = new List<DataRequestDocumentEntity>();
        [DataMember]
        public List<DataRequestDocumentEntity> DRDocumentEntityList
        {
            get { return drDocumentEntityList; }
            set { drDocumentEntityList = value; }
        }
        private System.String isAttachment;
        [DataMember]
        public System.String IsAttachment
        {
            get { return isAttachment; }
            set { isAttachment = value; }
        }

        public DataRequestDocumentEntity drDataRequestDocumentEntity;
        [DataMember]
        public DataRequestDocumentEntity DRDataRequestDocumentEntity
        {
            get { if (drDataRequestDocumentEntity == null)drDataRequestDocumentEntity = new DataRequestDocumentEntity(); return drDataRequestDocumentEntity; }
            set { drDataRequestDocumentEntity = value; }
        }
        private List<DataRequestSupplQuestionEntity> drDataRequestSupplQuestionList = new List<DataRequestSupplQuestionEntity>();
        [DataMember]
        public List<DataRequestSupplQuestionEntity> DrDataRequestSupplQuestionList
        {
            get { return drDataRequestSupplQuestionList; }
            set { drDataRequestSupplQuestionList = value; }
        }

        //Added By Anuj For CQM120----End
    }

}

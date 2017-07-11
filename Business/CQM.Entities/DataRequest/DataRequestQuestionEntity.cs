//---------------------------------------------------------------------
// Author: Hans Yadav
// Version: 1.0.0
// Date: 15/09/2010
// Description: This Entity is used for storing the DR Questions information.
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
    /// Represents a DataRequestQuestionEntity object.
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    public class DataRequestQuestionEntity
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

        private System.String drQuesId;
        [DataMember]
        public System.String DRQuesId
        {
            get { return drQuesId; }
            set { drQuesId = value; }
        }

        private System.Int32 drQuesNum;
        [DataMember]
        public System.Int32 DRQuesNum
        {
            get { return drQuesNum; }
            set { drQuesNum = value; }
        }

        private System.Int32 drQuesSeq;
        [DataMember]
        public System.Int32 DRQuesSeq
        {
            get { return drQuesSeq; }
            set { drQuesSeq = value; }
        }

        private System.Int32 drSetSeq;
        [DataMember]
        public System.Int32 DRSetSeq
        {
            get { return drSetSeq; }
            set { drSetSeq = value; }
        }

        private System.String filedExternally;
        [DataMember]
        public System.String FiledExternally
        {
            get { return filedExternally; }
            set { filedExternally = value; }
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

        private System.String quesDesc;
        [DataMember]
        public System.String QuesDesc
        {
            get { return quesDesc; }
            set { quesDesc = value; }
        }

        private System.DateTime quesDueDate;
        [DataMember]
        public System.DateTime QuesDueDate
        {
            get { return quesDueDate; }
            set { quesDueDate = value; }
        }

        private System.String quesStatus;
        [DataMember]
        public System.String QuesStatus
        {
            get { return quesStatus; }
            set { quesStatus = value; }
        }

        private System.String quesText;
        [DataMember]
        public System.String QuesText
        {
            get { return quesText; }
            set { quesText = value; }
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

        private System.String reqIndicator;
        [DataMember]
        public System.String ReqIndicator
        {
            get { return reqIndicator; }
            set { reqIndicator = value; }
        }

        private DataRequestSupplQuestionEntity drDataRequestSupplQuestionEntity;
        [DataMember]
        public DataRequestSupplQuestionEntity DRDataRequestSupplQuestionEntity
        {
            get { if (drDataRequestSupplQuestionEntity == null)drDataRequestSupplQuestionEntity = new DataRequestSupplQuestionEntity(); return drDataRequestSupplQuestionEntity; }
            set { drDataRequestSupplQuestionEntity = value; }
        }

        

        private System.String propoundedUpon;
        [DataMember]
        public System.String PropoundedUpon
        {
            get { return propoundedUpon; }
            set { propoundedUpon = value; }
        }

        private System.Int32 propoundedUponIndividual;
        [DataMember]
        public System.Int32 PropoundedUponIndividual
        {
            get { return propoundedUponIndividual; }
            set { propoundedUponIndividual = value; }
        }

        // Added by Manoj : 13 June 2013 : To add case number on DR set Listing Screen"
        private System.String caseNumber;
        [DataMember]
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.Int32 drRespSeq;
        [DataMember]
        public System.Int32 DrRespSeq
        {
            get { return drRespSeq; }
            set { drRespSeq = value; }
        }
        private System.Int32 isQuesAttachExists;
        [DataMember]
        public System.Int32 IsQuesAttachExists
        {
            get { return isQuesAttachExists; }
            set { isQuesAttachExists = value; }
        }

        private System.Int32 isResponseAttachExists;
        [DataMember]
        public System.Int32 IsResponseAttachExists
        {
            get { return isResponseAttachExists; }
            set { isResponseAttachExists = value; }
        }

        // Added by Manoj : 13 June 2013 : To add case number on DR set Listing Screen"


        //Added  BY Ashish Mamodia for Paging on 11 July 2013
        private System.Int32 totalRecords;
        [DataMember]
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        //End By Ashish Mamodia for Paging on 11 July 2013

        //Added By Anuj Singh 10-Dec-2013 DEFW 309

        private System.String responsetext;
        [DataMember]
        public System.String ResponseText
        {
            get { return responsetext; }
            set { responsetext = value; }
        }

        //Added By Anuj Singh 10-Dec-2013  DEFW 309S
        //START CODE ADDED BY ACHAL FOR CQM141 ON 3/02/2016
        private System.String supplReqIndicator;
        [DataMember]
        public System.String SupplReqIndicator
        {
            get { return supplReqIndicator; }
            set { supplReqIndicator = value; }
        }

        private System.Int32 drSupplQuesSeq;
        [DataMember]
        public System.Int32 DRSupplQuesSeq
        {
            get { return drSupplQuesSeq; }
            set { drSupplQuesSeq = value; }
        }
        private System.String drAppendedHiddenFieldSeq;
        [DataMember]
        public System.String DRAppendedHiddenFieldSeq
        {
            get { return drAppendedHiddenFieldSeq; }
            set { drAppendedHiddenFieldSeq = value; }
        }
        //START CODE ADDED BY ACHAL FOR CQM141 ON 3/02/2016
    }

}

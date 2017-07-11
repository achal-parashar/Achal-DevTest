//---------------------------------------------------------------------
// Author: Hans Yadav
// Version: 1.0.0
// Date: 15/09/2010
// Description: This Entity is used to represent the DR Sets values.
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
    /// Represents a DataRequestSetEntity object.
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    public class DataRequestSetEntity:BaseEntity
    {
        private System.String caseNumber;
        [DataMember]
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        private System.String caseTitle;
        [DataMember]
        public System.String CaseTitle
        {
            get { return caseTitle; }
            set { caseTitle = value; }
        }

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

        private System.String drSetDesc;
        [DataMember]
        public System.String DRSetDesc
        {
            get { return drSetDesc; }
            set { drSetDesc = value; }
        }

        private System.DateTime drSetDueDate;
        [DataMember]
        public System.DateTime DRSetDueDate
        {
            get { return drSetDueDate; }
            set { drSetDueDate = value; }
        }

        private System.String drSetId;
        [DataMember]
        public System.String DRSetId
        {
            get { return drSetId; }
            set { drSetId = value; }
        }

        private System.Int32 drSetNum;
        [DataMember]
        public System.Int32 DRSetNum
        {
            get { return drSetNum; }
            set { drSetNum = value; }
        }

        private System.Int32 drSetSeq;
        [DataMember]
        public System.Int32 DRSetSeq
        {
            get { return drSetSeq; }
            set { drSetSeq = value; }
        }

        private System.String drSetStatus;
        [DataMember]
        public System.String DRSetStatus
        {
            get { return drSetStatus; }
            set { drSetStatus = value; }
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

        private System.Int32 propoundedUponCompany;
        [DataMember]
        public System.Int32 PropoundedUponCompany
        {
            get { return propoundedUponCompany; }
            set { propoundedUponCompany = value; }
        }

        private System.String propoundedUponEmailId;
        [DataMember]
        public System.String PropoundedUponEmailId
        {
            get { return propoundedUponEmailId; }
            set { propoundedUponEmailId = value; }
        }

        private System.Int32 propoundedUponIndividual;
        [DataMember]
        public System.Int32 PropoundedUponIndividual
        {
            get { return propoundedUponIndividual; }
            set { propoundedUponIndividual = value; }
        }

        private System.String propoundedUponName;
        [DataMember]
        public System.String PropoundedUponName
        {
            get { return propoundedUponName; }
            set { propoundedUponName = value; }
        }

        private System.String propoundedUponStaff;
        [DataMember]
        public System.String PropoundedUponStaff
        {
            get { return propoundedUponStaff; }
            set { propoundedUponStaff = value; }
        }

        private System.Int32 propoundedUponType;
        [DataMember]
        public System.Int32 PropoundedUponType
        {
            get { return propoundedUponType; }
            set { propoundedUponType = value; }
        }

        private System.Int32 requestedByCompany;
        [DataMember]
        public System.Int32 RequestedByCompany
        {
            get { return requestedByCompany; }
            set { requestedByCompany = value; }
        }

       

        private System.Int32 requestedByIndividual;
        [DataMember]
        public System.Int32 RequestedByIndividual
        {
            get { return requestedByIndividual; }
            set { requestedByIndividual = value; }
        }

        [DataMember]
        public System.String RequestedByName { get; set; }

        private System.String requestedByStaff;
        [DataMember]
        public System.String RequestedByStaff
        {
            get { return requestedByStaff; }
            set { requestedByStaff = value; }
        }

        

        private System.Int32 requestedByType;
        [DataMember]
        public System.Int32 RequestedByType
        {
            get { return requestedByType; }
            set { requestedByType = value; }
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

        private List<DataRequestQuestionEntity> drQuestionEntityList = new List<DataRequestQuestionEntity>();
        [DataMember]
        public List<DataRequestQuestionEntity> DRQuestionEntityList
        {
            get { return drQuestionEntityList; }
            set { drQuestionEntityList = value; }
        }

        private List<DataRequestDocumentEntity> drDocumentEntityList = new List<DataRequestDocumentEntity>();
        [DataMember]
        public List<DataRequestDocumentEntity> DRDocumentEntityList
        {
            get { return drDocumentEntityList; }
            set { drDocumentEntityList = value; }
        }

        private List<ItemEntity> drItemEntityList;
        [DataMember]
        public List<ItemEntity> DRItemEntityList
        {
            get { if (drItemEntityList == null)drItemEntityList = new List<ItemEntity>(); return drItemEntityList; }
            set { drItemEntityList = value; }
        }

        private System.Int32 totalRecords;
        [DataMember]
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        [DataMember]
        public bool IsSuccessfull { get; set; }

        [DataMember]
        public System.String MatterTitle { get; set; }

        [DataMember]
        public System.Int32 notificationStatus { get; set; }
        
    }
}

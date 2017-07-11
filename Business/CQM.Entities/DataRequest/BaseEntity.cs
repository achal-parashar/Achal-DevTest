

namespace CQM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ServiceModel;
    using System.Runtime.Serialization;

    [DataContract]
    [Serializable]
    public class BaseEntity
    {
        [DataMember]
        public System.Int32 PageSize { get; set; }
       
        [DataMember]
        public System.Int32 PageNumber { get; set; }
       
        [DataMember]
        public System.String OrderBy { get; set; }

        [DataMember]
        public System.String UserID { get; set; }

       
    }

    [DataContract]
    [Serializable]
    public class QuestionAttachmentEntity
    {
        private System.String questID;
        [DataMember]
        public System.String QuestID
        {
            get { return questID; }
            set { questID = value; }
        }


        private List<CQM.Entities.DataRequestDocumentEntity> drDocumentEntityList = new List<CQM.Entities.DataRequestDocumentEntity>();
        [DataMember]
        public List<CQM.Entities.DataRequestDocumentEntity> DRDocumentEntityList
        {
            get { return drDocumentEntityList; }
            set { drDocumentEntityList = value; }
        }

    }
}



//---------------------------------------------------------------------
// Author: Hans Yadav
// Version: 1.0.0
// Date: 15/09/2010
// Description: This Entity is used for storing the master values for the Data request module.
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

    [DataContract]
    [Serializable]
    public class DataRequestMasterEntity
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

        private System.String drCode;
        [DataMember]
        public System.String DRCode
        {
            get { return drCode; }
            set { drCode = value; }
        }

        private System.String drDesc;
        [DataMember]
        public System.String DRDesc
        {
            get { return drDesc; }
            set { drDesc = value; }
        }

        private System.Decimal drMstrSeq;
        [DataMember]
        public System.Decimal DRMstrSeq
        {
            get { return drMstrSeq; }
            set { drMstrSeq = value; }
        }

        private System.String drType;
        [DataMember]
        public System.String DRType
        {
            get { return drType; }
            set { drType = value; }
        }

        private System.String isDeleted;
        [DataMember]
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
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

    }
}

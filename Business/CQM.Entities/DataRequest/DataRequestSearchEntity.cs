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
    /// Represents a DataRequestSearch object.
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    public class DataRequestSearchEntity : BaseEntity
    {
        private System.String caseNumber;
        [DataMember]
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        private System.String drQuesId;
        [DataMember]
        public System.String DRQuesId
        {
            get { return drQuesId; }
            set { drQuesId = value; }
        }

        private System.String requestorCode;
        [DataMember]
        public System.String RequestorCode
        {
            get { return requestorCode; }
            set { requestorCode = value; }
        }

        private System.String propoundedUpon;
        [DataMember]
        public System.String PropoundedUpon
        {
            get { return propoundedUpon; }
            set { propoundedUpon = value; }
        }

        private System.String responseSubmittedBy;
        [DataMember]
        public System.String ResponseSubmittedBy
        {
            get { return responseSubmittedBy; }
            set { responseSubmittedBy = value; }
        }

        private System.String responseReviewedBy;
        [DataMember]
        public System.String ResponseReviewedBy
        {
            get { return responseReviewedBy; }
            set { responseReviewedBy = value; }
        }

        private System.DateTime responseFrom;
        [DataMember]
        public System.DateTime ResponseFrom
        {
            get { return responseFrom; }
            set { responseFrom = value; }
        }

        private System.DateTime responseTo;
        [DataMember]
        public System.DateTime ResponseTo
        {
            get { return responseTo; }
            set { responseTo = value; }
        }


        private System.String respondStatus;
        [DataMember]
        public System.String RespondStatus
        {
            get { return respondStatus; }
            set { respondStatus = value; }
        }



       

        private System.String isFullTextSearch;
        [DataMember]
        public System.String IsFullTextSearch
        {
            get { return isFullTextSearch; }
            set { isFullTextSearch = value; }
        }

       

        private System.String text;
        [DataMember]
        public System.String Text
        {
            get { return text; }
            set { text = value; }
        }

        private System.String fullTextSearchoption;
        [DataMember]
        public System.String FullTextSearchoption
        {
            get { return fullTextSearchoption; }
            set { fullTextSearchoption = value; }
        }

        private System.String isAttachment;
        [DataMember]
        public System.String IsAttachment
        {
            get { return isAttachment; }
            set { isAttachment = value; }
        }

        private System.String drSetId;
        [DataMember]
        public System.String DRSetId
        {
            get { return drSetId; }
            set { drSetId = value; }
        }

        private System.DateTime drSetFrom;
        [DataMember]
        public System.DateTime DRSetFrom
        {
            get { return drSetFrom; }
            set { drSetFrom = value; }
        }

        private System.DateTime drSetTo;
        [DataMember]
        public System.DateTime DRSetTo
        {
            get { return drSetTo; }
            set { drSetTo = value; }
        }

        private System.String description;
        [DataMember]
        public System.String Description
        {
            get { return description; }
            set { description = value; }
        }
     
    }
}

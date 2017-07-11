//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 02/12/2008
// Description: Content Entity
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about the content of the document being 
    /// checked in/checked out or being viewed from FileNet
    /// mapping entity with ContentEntity of FileNet
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2008-02-12</creationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    [DataContract]
    [Serializable]
    public class ContentEntity
    {
        private System.String documentId;
        [DataMember]
        public System.String DocumentId
        {
            get { return documentId; }
            set { this.documentId = value; }
        }

        private System.String documentName;
        [DataMember]
        public System.String DocumentName
        {
            get { return documentName; }
            set { this.documentName = value; }
        }

        private System.String contentElement;
        [DataMember]
        public System.String ContentElement
        {
            get { return contentElement; }
            set { this.contentElement = value; }
        }   

        private System.Int32 totalNoofChunks;
        [DataMember]
        public System.Int32 TotalNoofChunks
        {
            get { return totalNoofChunks; }
            set { this.totalNoofChunks = value; }
        }

        private System.Int32 currentChunkNo;
        [DataMember]
        public System.Int32 CurrentChunkNo
        {
            get { return currentChunkNo; }
            set { this.currentChunkNo = value; }
        }

        private System.Int32 versionNumber;
        [DataMember]
        public System.Int32 VersionNumber
        {
            get { return versionNumber; }
            set { this.versionNumber = value; }
        }

        private System.String documentMimeType;
        [DataMember]
        public System.String DocumentMimeType
        {
            get { return documentMimeType; }
            set { this.documentMimeType = value; }
        }

        private System.String userID;
        [DataMember]
        public System.String UserID
        {
            get { return userID; }
            set { this.userID = value; }
        }

        private System.String documentSecurity;
        [DataMember]
        public System.String DocumentSecurity
        {
            get{ return documentSecurity; }
            set { this.documentSecurity = value; }
        }
    }
}

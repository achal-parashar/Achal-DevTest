//---------------------------------------------------------------------
// Author: Amitava Sinha
// Version: 1.0.0
// Date: 01/09/2008
// Description: This RecordCountsEntity class stores the record count for each tab.
//
// History:
// Changed By                       Changed On
//---------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
namespace CQM.Entities
{
    /// <summary>
    /// This RecordCountsEntity class stores the record count for each tab.
    /// </summary>
    /// <author>Amitava Sinha</author>
    /// <creationDate>2008-09-01</ceationDate>
    /// <modifications>
    /// <item>2008-09-01;Amitava Sinha;Added new Functions</item>
    /// <item>Date;By;Description</item>
    /// </modifications>
    /// 
    public class RecordCountsEntity
    {
        private System.Int32 publicDocs;
        public System.Int32 PublicDocs
        {
            get { return publicDocs; }
            set { publicDocs = value; }
        }
        private System.Int32 contacts;
        public System.Int32 Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }
        private System.Int32 sessionAgenda;
        public System.Int32 SessionAgenda
        {
            get { return sessionAgenda; }
            set { sessionAgenda = value; }
        }
        private System.Int32 calendar;
        public System.Int32 Calendar
        {
            get { return calendar; }
            set { calendar = value; }
        }
        private System.Int32 sapa;
        public System.Int32 Sapa
        {
            get { return sapa; }
            set { sapa = value; }
        }
        private System.Int32 notes;
        public System.Int32 Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        private System.Int32 history;
        public System.Int32 History
        {
            get { return history; }
            set { history = value; }
        }
        private System.Int32 assignedStaff;
        public System.Int32 AssignedStaff
        {
            get { return assignedStaff; }
            set { assignedStaff = value; }
        }
        private System.Int32 internaldocument;
        public System.Int32 Internaldocument
        {
            get { return internaldocument; }
            set { internaldocument = value; }
        }
        private System.Int32 internalRequest;
        public System.Int32 InternalRequest
        {
            get { return internalRequest; }
            set { internalRequest = value; }
        }
        private System.Int32 confidentialDocCount;
        public System.Int32 ConfidentialDocCount
        {
            get { return confidentialDocCount; }
            set { confidentialDocCount = value; }
        }
        private List<MatterDocumentEntity> matterPublicDoc = new List<MatterDocumentEntity>();
        public List<MatterDocumentEntity> MatterPublicDoc
        {
            get { return matterPublicDoc; }
            set { matterPublicDoc = value; }
        }
    }
}

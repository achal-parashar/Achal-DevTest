//---------------------------------------------------------------------
// Author: Amitava Sinha
// Version: 1.0.0
// Date: 01/09/2008
// Description: This MatterEventEntity class stores the information about Matter Events.
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This MatterEventEntity class stores the information about Matter Events.
    /// </summary>
    /// <author>Amitava Sinha</author>
    /// <creationDate>2008-09-01</ceationDate>
    /// <modifications>
    /// <item>2008-09-01;Amitava Sinha;Added new Functions</item>
    /// <item>Date;By;Description</item>
    /// </modifications>
    /// 
    public class EventEntity
    {
        private System.String isPublic;
        public System.String IsPublic
        {
            get { return isPublic; }
            set { isPublic = value; }
        }
        private System.Int32 eventSeq;
        public System.Int32 EventSeq
        {
            get { return eventSeq; }
            set { eventSeq = value; }
        }
        private System.String eventTitle;
        public System.String EventTitle
        {
            get { return eventTitle; }
            set { eventTitle = value; }
        }
        private System.DateTime startDate;
        public System.DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private System.DateTime endDate;
        public System.DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        private System.String location;
        public System.String Location
        {
            get { return location; }
            set { location = value; }
        }
        private System.String publicEventImage;
        public System.String PublicEventImage
        {
            get { return publicEventImage; }
            set { publicEventImage = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.Decimal matterSeq;
        public System.Decimal MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
        }
        private System.String deleteEventImage;
        public System.String DeleteEventImage
        {
            get { return deleteEventImage; }
            set { deleteEventImage = value; }
        }
        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        private System.DateTime createdDate;
        public System.DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        private System.String eventDescription;
        public System.String EventDescription
        {
            get { return eventDescription; }
            set { eventDescription = value; }
        }
        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }
        private System.String delete;
        public System.String Delete
        {
            get { return delete; }
            set { delete = value; }
        }
        private System.String edit;
        public System.String Edit
        {
            get { return edit; }
            set { edit = value; }
        }
        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }
        private System.DateTime updatedDate;
        public System.DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }
        private System.String matterNumber;
        public System.String MatterNumber
        {
            get { return matterNumber; }
            set { matterNumber = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
    }

}




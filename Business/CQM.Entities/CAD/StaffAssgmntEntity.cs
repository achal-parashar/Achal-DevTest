using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQM.Entities
{
    public class StaffAssgmntEntity
    {

        private System.String staffId;
        public System.String StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }



        private System.String specialistID;
        public System.String SpecialistID
        {
            get { return specialistID; }
            set { specialistID = value; }
        }

        private Nullable<System.DateTime> dateAssigned;
        public Nullable<System.DateTime> DateAssigned
        {
            get { return dateAssigned; }
            set { dateAssigned = value; }
        }

        private System.String trackNumber;
        public System.String TrackNumber
        {
            get { return trackNumber; }
            set { trackNumber = value; }
        }
        private Nullable<System.DateTime> dateUnAssigned;
        public Nullable<System.DateTime> DateUnAssigned
        {
            get { return dateUnAssigned; }
            set { dateUnAssigned = value; }
        }

        private System.String assgndViolation;
        public System.String AssgndViolation
        {
            get { return assgndViolation; }
            set { assgndViolation = value; }
        }

        private System.String createdby;
        public System.String CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private System.String updatedby;
        public System.String UpdatedBy
        {
            get { return updatedby; }
            set { updatedby = value; }
        }

        private Nullable<System.DateTime> createddate;
        public Nullable<System.DateTime> CreatedDate
        {
            get { return createddate; }
            set { createddate = value; }
        }

        private Nullable<System.DateTime> updateddate;
        public Nullable<System.DateTime> UpdateDate
        {
            get { return updateddate; }
            set { updateddate = value; }
        }

        private System.String isdeleted;
        public System.String IsDeleted
        {
            get { return isdeleted; }
            set { isdeleted = value; }
        }
        private System.String staffName;
        public System.String StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String isAssignable;
        public System.String IsAssignable
        {
            get { return isAssignable; }
            set { isAssignable = value; }
        }
        private System.String isUnAssigned;
        public System.String IsUnAssigned
        {
            get { return isUnAssigned; }
            set { isUnAssigned = value; }
        }
        private System.String mobileImage;
        public System.String MobileImage
        {
            get { return mobileImage; }
            set { mobileImage = value; }
        }
        private System.Int32 outStatus;
        public System.Int32 OutStatus
        {
            get { return outStatus; }
            set { outStatus = value; }
        }

    }



}

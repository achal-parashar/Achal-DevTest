//---------------------------------------------------------------------
// Author: Amarendra
// Version: 1.0.0
// Date: 11/01/2011
// Description: Annual Report Search Entity
//
// History: 
// Changed By:                        Changed On: 
//
//---------------------------------------------------------------------


using System;
using System.Collections.Generic;


namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Annual Report Search-Result.
    /// </summary>
    /// <author>Amarendra</author>
    /// <creationDate>2011-11-01</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    ///


    public class ReportEntity
    {
        private string companySeq;
        public string CompanySeq
        {
        get { return companySeq; }
        set { companySeq = value; }
        }

        //private string companySeqList;
        //public int CompanySeqList
        //    {
        //    get { return companySeqList; }
        //    set { companySeqList = value; }
        //    }

        private string reportYear;
        public string ReportYear
        {
            get { return reportYear; }
            set { reportYear = value; }
        }

        private string reportYearFrom;
        public string ReportYearFrom
        {
            get { return reportYearFrom; }
            set { reportYearFrom = value; }
        }

        private string reportYearTo;
        public string ReportYearTo
        {
            get { return reportYearTo; }
            set { reportYearTo = value; }
        }

        private string reportTypeCode;
        public string ReportTypeCode
        {
            get { return reportTypeCode; }
            set { reportTypeCode = value; }
        }

        private string reportTypeDesc;
        public string ReportTypeDesc
        {
            get { return reportTypeDesc; }
            set { reportTypeDesc = value; }
        }

        private string industrySubTypeCode;
        public string IndustrySubTypeCode
        {
            get { return industrySubTypeCode; }
            set { industrySubTypeCode = value; }
        }

        private string industryTypeCode;
        public string IndustryTypeCode
        {
            get { return industryTypeCode; }
            set { industryTypeCode = value; }
        }
        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        private string trackingNumber;
        public string TrackingNumber
        {
            get { return trackingNumber; }
            set { trackingNumber = value; }
        }
        private int personCompletingARSeq;
        public int PersonCompletingARSeq
        {
            get { return personCompletingARSeq; }
            set { personCompletingARSeq = value; }
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

        private System.String industryType;
        public System.String IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        private System.String industrySubTypeDesc;
        public System.String IndustrySubTypeDesc
        {
            get { return industrySubTypeDesc; }
            set { industrySubTypeDesc = value; }
        }
        private System.String companyOrgName;
        public System.String CompanyOrgName
        {
            get { return companyOrgName; }
            set { companyOrgName = value; }
        }

        private int totalRecords;
        public int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private int pageSize;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
        private int pageNumber;
        public int PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }

        private System.String sortBy;
        public System.String SortBy
        {
            get { return sortBy; }
            set { sortBy = value; }
        }

        private System.String sNo;
        public System.String SNo
        {
            get { return sNo; }
            set { sNo = value; }
        }

    }
}

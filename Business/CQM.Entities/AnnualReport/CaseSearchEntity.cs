//---------------------------------------------------------------------
// Author: Amarendra
// Version: 1.0.0
// Date: 11/01/2011
// Description:Implement Annual Report Confidential Document Case Search Properties
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Annual Report Confidential Document Case Search.
    /// </summary>
    /// <author>Amarendra</author>
    /// <creationDate>2011-11-01</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class CaseSearchEntity
        {
        private int companySeq;
        public int CompanySeq
            {
            get { return companySeq; }
            set { companySeq = value; }
            }

        private string caseNumber;
        public string CaseNumber
            {
            get { return caseNumber; }
            set { caseNumber = value; }
            }

        private string caseTitle;
        public string CaseTitle
            {
            get { return caseTitle; }
            set { caseTitle = value; }
            }

        private string caseTypeCode;
        public string CaseTypeCode
            {
            get { return caseTypeCode; }
            set { caseTypeCode = value; }
            }

        private string caseTypeDesc;
        public string CaseTypeeDesc
            {
            get { return caseTypeDesc; }
            set { caseTypeDesc = value; }
            }

        private string caseSubTypeCode;
        public string CaseSubTypeCode
            {
            get { return caseSubTypeCode; }
            set { caseSubTypeCode = value; }
            }

        private string caseSubTypeDesc;
        public string CaseSubTypeeDesc
            {
            get { return caseSubTypeDesc; }
            set { caseSubTypeDesc = value; }
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

        private System.DateTime startDate;
        public System.DateTime StartDate
            {
            get { return startDate; }
            set { startDate = value; }
            }

        private System.DateTime? startDateFrom;
        public System.DateTime? StartDateFrom
            {
            get { return startDateFrom; }
            set { startDateFrom = value; }
            }

        private System.DateTime? startDateTo;
        public System.DateTime? StartDateTo
            {
            get { return startDateTo; }
            set { startDateTo = value; }
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

        private System.String documentName;
        public System.String DocumentName
            {
            get { return documentName; }
            set { documentName = value; }
            }

        private System.String documentTitle;
        public System.String DocumentTitle
            {
            get { return documentTitle; }
            set { documentTitle = value; }
            }

        private System.String documentExtn;
        public System.String DocumentExtn
            {
            get { return documentExtn; }
            set { documentExtn = value; }
            }

        private System.Decimal documentSize;
        public System.Decimal DocumentSize
            {
            get { return documentSize; }
            set { documentSize = value; }
            }

        private System.String sizetoDisplay;
        public System.String SizetoDisplay
            {
            get { return sizetoDisplay; }
            set { sizetoDisplay = value; }
            }

        private int documentSeq;
        public int DocumentSeq
            {
            get { return documentSeq; }
            set { documentSeq = value; }
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

        private DateTime createdDate;
        public DateTime CreatedDate
            {
            get { return createdDate; }
            set { createdDate = value; }
            }
        private string isConfidential;
        public string IsConfidential
            {
            get { return isConfidential; }
            set { isConfidential = value; }
            }
        private System.String documentRefNo;
        public System.String DocumentRefNo
            {
            get { return documentRefNo; }
            set { documentRefNo = value; }
            }
        }
}

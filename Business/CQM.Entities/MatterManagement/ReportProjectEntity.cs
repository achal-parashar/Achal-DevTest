using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQM.Entities
{
   public class ReportProjectEntity
    {
        private System.String reportTypeCode;
        public System.String ReportTypeCode
        {
            get { return reportTypeCode; }
            set { reportTypeCode = value; }
        }
        private System.String reportTypeDesc;
        public System.String ReportTypeDesc
        {
            get { return reportTypeDesc; }
            set { reportTypeDesc = value; }
        }
        private System.String documentname;
        public System.String DocumentName
        {
            get { return documentname; }
            set { documentname = value; }
        }
        //--------------Industry Type start--------------
        private System.String industrycode;
        public System.String Industry_Type_Code
        {
            get { return industrycode; }
            set { industrycode = value; }
        }
        private System.String industryType;
        public System.String IndustryType
        {
            get { return industryType; }
            set { industryType = value; }
        }
        //--------------Industry Type End--------------  

        //--------------Industry SubType start--------------
        private System.String industrySubTypecode;
        public System.String IndustrySubTypeCode
        {
            get { return industrySubTypecode; }
            set { industrySubTypecode = value; }
        }
        private System.String industrySubType;
        public System.String IndustrySubType
        {
            get { return industrySubType; }
            set { industrySubType = value; }
        }
        //--------------Industry SubType End-------------- 

        //--------------Company  start--------------
        private System.Decimal companySeq;
        public System.Decimal CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }
        private System.Decimal reportsubmissionseq;
        public System.Decimal ReportSubmissionSeq
        {
            get { return reportsubmissionseq; }
            set { reportsubmissionseq = value; }
        }
        private System.String companyCode;
        public System.String CompanyCode
        {
            get { return companyCode; }
            set { companyCode = value; }
        }
        private System.String companyOrgName;
        public System.String CompanyOrgName
        {
            get { return companyOrgName; }
            set { companyOrgName = value; }
        }
        //--------------Company End-------------- 
        //------------Report/Project Year Start---------------
        private System.String rptprjYear;
        public System.String ReportProjectYear
        {
            get { return rptprjYear; }
            set { rptprjYear = value; }
        }
        //------------Report/Project Year End---------------
        private System.String comments;
        public System.String Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        private System.String titlefiling;
        public System.String TitleOfFiling
        {
            get { return titlefiling; }
            set { titlefiling = value; }
        }
        private System.String isSubmitbyStaff;
        public System.String IsSubmitBYStaff
        {
            get { return isSubmitbyStaff; }
            set { isSubmitbyStaff = value; }
        }
        private System.String parentcompanyname;
        public System.String ParentCompanyName
        {
            get { return parentcompanyname; }
            set { parentcompanyname = value; }
        }
        private System.String submissionDate;
        public System.String SubmissionDate
        {
            get { return submissionDate; }
            set { submissionDate = value; }
        }

        private System.String submissionDateFrom;
        public System.String SubmissionDateFrom
        {
            get { return submissionDateFrom; }
            set { submissionDateFrom = value; }
        }

        private List<MatterFilingDocEntity> docInfo;
        public List<MatterFilingDocEntity> DocInfo
        {
            get { return docInfo; }
            set { docInfo = value; }
        }

        private List<CodeNameEntity> userInfo = new List<CodeNameEntity>();
        public List<CodeNameEntity> UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }

        private System.String submissionDateTo;
        public System.String SubmissionDateTo
        {
            get { return submissionDateTo; }
            set { submissionDateTo = value; }
        }
        private System.String dbaName;
        public System.String DbaName
        {
            get { return dbaName; }
            set { dbaName = value; }
        }
        private System.String fedidnumber;
        public System.String FedIDNumber
        {
            get { return fedidnumber; }
            set { fedidnumber = value; }
        }
        private System.String nenaid;
        public System.String NenaID
        {
            get { return nenaid; }
            set { nenaid = value; }
        }
        private System.String troublenumber;
        public System.String TroubleNumber
        {
            get { return troublenumber; }
            set { troublenumber = value; }
        }
        private System.String dbProvider;
        public System.String DBProvider
        {
            get { return dbProvider; }
            set { dbProvider = value; }
        }

        private System.String trackingnumber;
        public System.String TrackingNumber
        {
            get { return trackingnumber; }
            set { trackingnumber = value; }
        }
        private System.String userId;
        public System.String UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private System.String userIdToAdd;
        public System.String UserIdToAdd
        {
            get { return userIdToAdd; }
            set { userIdToAdd = value; }
        }

        private System.String userIdToRem;
        public System.String UserIdToRem
        {
            get { return userIdToRem; }
            set { userIdToRem = value; }
        }

        private System.String users;
        public System.String Users
        {
            get { return users; }
            set { users = value; }
        }


        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }


        private System.String submittedby;
        public System.String SubmittedBy
        {
            get { return submittedby; }
            set { submittedby = value; }
        }

        private System.String isConfidential;
        public System.String IsConfidential
        {
            get { return isConfidential; }
            set { isConfidential = value; }
        }

        private System.String isConfidentialConv;
        public System.String IsConfidentialConv
        {
            get { return isConfidentialConv; }
            set { isConfidentialConv = value; }
        }
        private System.String isDeleted;
        public System.String IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String edit;
        public System.String Edit
        {
            get { return edit; }
            set { edit = value; }
        }

        private System.String delete;
        public System.String Delete
        {
            get { return delete; }
            set { delete = value; }
        }

        private System.String updatedby;
        public System.String Updatedby
        {
            get { return updatedby; }
            set { updatedby = value; }
        }

        private System.String documentExtn;
        public System.String DocumentExtn
        {
            get { return documentExtn; }
            set { documentExtn = value; }
        }
        private System.String docRefNo;
        public System.String DocRefNo
        {
            get { return docRefNo; }
            set { docRefNo = value; }
        }
    }
}

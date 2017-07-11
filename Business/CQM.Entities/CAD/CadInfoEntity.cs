//---------------------------------------------------------------------
// Author: Jay Prakash
// Version: 1.0.0
// Date: 05/25/2011
// Description: CAD Info Entity
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
    /// This entity class stores the information about CAD Information Entity
    /// </summary>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-05-25</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class CadInfoEntity
    {

        private System.Int32 cadID;
        public System.Int32 CadID
        {
            get { return cadID; }
            set { cadID = value; }
        }

        private System.String accountno;
        public System.String AccountNo
        {
            get { return accountno; }
            set { accountno = value; }
        }

        private System.String businessName;
        public System.String BusinessName
        {
            get { return businessName; }
            set { businessName = value; }
        }
        private System.String dbaName;
        public System.String DbaName
        {
            get { return dbaName; }
            set { dbaName = value; }
        }
        private System.String cadNumber;
        public System.String CadNumber
        {
            get { return cadNumber; }
            set { cadNumber = value; }
        }

        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        private System.String cadType;
        public System.String CadType
        {
            get { return cadType; }
            set { cadType = value; }
        }

        private System.String cadSubType;
        public System.String CadSubType
        {
            get { return cadSubType; }
            set { cadSubType = value; }
        }

        private System.String industrytype;
        public System.String IndustryType
        {
            get { return industrytype; }
            set { industrytype = value; }
        }

        private System.String industrysubtype;
        public System.String IndustrySubType
        {
            get { return industrysubtype; }
            set { industrysubtype = value; }
        }

        private System.String statusNotes;
        public System.String StatusNotes
        {
            get { return statusNotes; }
            set { statusNotes = value; }
        }

        private System.String title;
        public System.String Title
        {
            get { return title; }
            set { title = value; }
        }

        private CodeNameEntity status;
        public CodeNameEntity Status
        {
            get { return status; }
            set { status = value; }
        }

        private List<IDNameEntity> companyIDNames = new List<IDNameEntity>();
        public List<IDNameEntity> CompanyIDNames
        {
            get { return companyIDNames; }
            set { companyIDNames = value; }
        }

        private List<IDNameEntity> relatedcadIDNos = new List<IDNameEntity>();
        public List<IDNameEntity> RelatedCadIDNos
        {
            get { return relatedcadIDNos; }
            set { relatedcadIDNos = value; }
        }


        private System.String cadSubTypeID;
        public System.String CadSubTypeID
        {
            get { return cadSubTypeID; }
            set { cadSubTypeID = value; }
        }

        private System.Decimal industrySeq;
        public System.Decimal IndustrySeq
        {
            get { return industrySeq; }
            set { industrySeq = value; }

        }

        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private Nullable<System.DateTime> updatedDate;
        public Nullable<System.DateTime> UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }
        private System.String comments;
        public System.String Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        private Nullable<System.DateTime> filedDate;
        public Nullable<System.DateTime> FiledDate
        {
            get { return filedDate; }
            set { filedDate = value; }
        }

        private System.DateTime startDate;
        public System.DateTime StartDate
        {
            set { startDate = value; }
            get { return startDate; }
        }


        private System.Boolean iscadSelected;
        public System.Boolean IsCadSelected
        {
            get { return iscadSelected; }
            set { iscadSelected = value; }
        }
        private System.String cadCases;
        public System.String CadCases
        {
            get { return cadCases; }
            set { cadCases = value; }
        }
        private System.String cadCloseDate;
        public System.String CadCloseDate
        {
            get { return cadCloseDate; }
            set { cadCloseDate = value; }
        }
        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }
        //@@@@ End: For DOC RETENTION
        

        private System.String precadCaseNum;
        public System.String PreCadCaseNum
        {
            get { return precadCaseNum; }
            set { precadCaseNum = value; }
        }
        private System.String fname;
        public System.String F_Name
        {
            get { return fname; }
            set { fname = value; }
        }

        private System.String lname;
        public System.String L_Name
        {
            get { return lname; }
            set { lname = value; }
        }
        private System.String mname;
        public System.String M_Name
        {
            get { return mname; }
            set { mname = value; }
        }
        private System.String dispositiontype;
        public System.String Dispositin_Type
        {
            get { return dispositiontype; }
            set { dispositiontype = value; }
        }
        private System.DateTime dispositiondate;
        public System.DateTime Dispositin_Date
        {
            get { return dispositiondate; }
            set { dispositiondate = value; }
        }
        private System.Int32 abatementamt;
        public System.Int32 Abatement_Amount
        {
            get { return abatementamt; }
            set { abatementamt = value; }
        }
        private System.String violation;
        public System.String Violation
        {
            get { return violation; }
            set { violation = value; }
        }
        private System.String assignedstass;
        public System.String Assigned_Staff
        {
            get { return assignedstass; }
            set { assignedstass = value; }
        }
        private System.String companyname;
        public System.String Company_Name
        {
            get { return companyname; }
            set { companyname = value; }
        }

        private ContactDetailEntity contactDetailEntity;
        public ContactDetailEntity ContactDetailEntity
        {
            get
            {
                if (contactDetailEntity == null)
                { contactDetailEntity = new ContactDetailEntity(); }
                return contactDetailEntity;
            }
            set { contactDetailEntity = value; }
        }

        private System.String IsAppealed;
        public System.String Is_Appealed
        {
            get { return IsAppealed; }
            set { IsAppealed = value; }
        }

        private System.String Notes_Added;
        public System.String CadNotes
        {
            get { return Notes_Added; }
            set { Notes_Added = value; }
        }

        private System.Decimal Notes_Seq;
        public System.Decimal CadNotesSeq
        {
            get { return Notes_Seq; }
            set { Notes_Seq = value; }
        }

        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private Nullable<System.DateTime> createdDate;
        public Nullable<System.DateTime> CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private List<CadFilingDocEntity> docInfo = new List<CadFilingDocEntity>();
        public List<CadFilingDocEntity> DocInfo
        {
            get { return docInfo; }
            set { docInfo = value; }
        }

        private CadFilingDocEntity documentInfo = new CadFilingDocEntity();
        public CadFilingDocEntity DocumentsInfo
        {
            get { return documentInfo; }
            set { documentInfo = value; }
        }

        private System.Int32 outStatus;
        public System.Int32 OutStatus
        {
            get { return outStatus; }
            set { outStatus = value; }
        }
       

        private System.Int32 totalIncomeSeq;
        public System.Int32 TotalIncomeSeq
        {
            get { return totalIncomeSeq; }
            set { totalIncomeSeq = value; }
        }

        private System.Decimal totalAssistanceAmount;
        public System.Decimal TotalAsstAmount
        {
            get { return totalAssistanceAmount; }
            set { totalAssistanceAmount = value; }
        }

        private System.Decimal totalIncomeAmount;
        public System.Decimal TotalIncAmount
        {
            get { return totalIncomeAmount; }
            set { totalIncomeAmount = value; }
        }

        private System.Decimal totalExpenseAmount;
        public System.Decimal TotalExpAmount
        {
            get { return totalExpenseAmount; }
            set { totalExpenseAmount = value; }
        }

        private System.Decimal totalDispAmount;
        public System.Decimal TotalDispAmount
        {
            get { return totalDispAmount; }
            set { totalDispAmount = value; }
        }
        private System.String greetingCode;
        public System.String GreetingCode
        {
            get { return greetingCode; }
            set { greetingCode = value; }
        }
        private System.String county;
        public System.String County
        {
            get { return county; }
            set { county = value; }
        }
        private System.String affidavitEventNote;
        public System.String AffidavitEventNote
        {
            get { return affidavitEventNote; }
            set { affidavitEventNote = value; }
        }
        private System.String industrycode;
        public System.String IndustryTypeCode
        {
            get { return industrycode; }
            set { industrycode = value; }
        }
        private System.String industrysubtypecode;
        public System.String IndustrySubtypeCode
        {
            get { return industrysubtypecode; }
            set { industrysubtypecode = value; }
        }
        private System.String caseTypecode;
        public System.String CaseTypecode
        {
            get { return caseTypecode; }
            set { caseTypecode = value; }
        }
        private System.String caseType;
        public System.String CaseType
        {
            get { return caseType; }
            set { caseType = value; }
        }
        private System.String complainantName;
        public System.String ComplainantName
        {
            get { return complainantName; }
            set { complainantName = value; }
        }
        private System.DateTime appealedDate;
        public System.DateTime AppealedDate
        {
            get { return appealedDate; }
            set { appealedDate = value; }
        }
        private System.String caseSubTypeCode;
        public System.String CaseSubTypeCode
        {
            get { return caseSubTypeCode; }
            set { caseSubTypeCode = value; }
        }
        private System.String caseSubType;
        public System.String CaseSubType
        {
            get { return caseSubType; }
            set { caseSubType = value; }
        }
        private System.String dispositin_TypeCode;
        public System.String Dispositin_TypeCode
        {
            get { return dispositin_TypeCode; }
            set { dispositin_TypeCode = value; }
        }
        private System.String name_BusinessName_DBA;
        public System.String Name_BusinessName_DBA
        {
            get { return name_BusinessName_DBA; }
            set { name_BusinessName_DBA = value; }
        }
        private System.String fullAddress;
        public System.String FullAddress
        {
            get { return fullAddress; }
            set { fullAddress = value; }
        }
        private System.String issueType;
        public System.String IssueType
        {
            get { return issueType; }
            set { issueType = value; }
        }
        private Nullable<System.Decimal> companySeq;
        public Nullable<System.Decimal> CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }

        }

        private System.String isBusiness;
        public System.String IsBusiness
        {
            get { return isBusiness; }
            set { isBusiness = value; }
        }

        private System.String suffix;
        public System.String Suffix
        {
            get { return suffix; }
            set { suffix = value; }
        }

        private System.String emailID;
        public System.String EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }

        private System.String docketID;
        public System.String DocketID
        {
            get { return docketID; }
            set { docketID = value; }
        }
        /****************
         Entities For CAD Case File
         Added By Ashish Mamodia
         *****************/
        private Nullable<System.Int32> notesCount;
        public Nullable<System.Int32> NotesCount
        {
            get { return notesCount; }
            set { notesCount = value; }
        }
        private Nullable<System.Int32> historyCount;
        public Nullable<System.Int32> HistoryCount
        {
            get { return historyCount; }
            set { historyCount = value; }
        }
        private Nullable<System.Int32> assignedstaffCount;
        public Nullable<System.Int32> AssignedstaffCount
        {
            get { return assignedstaffCount; }
            set { assignedstaffCount = value; }
        }
        private Nullable<System.Int32> incomeCount;
        public Nullable<System.Int32> IncomeCount
        {
            get { return incomeCount; }
            set { incomeCount = value; }
        }
        private System.String[] userListCAD;
        public System.String[] UserListCAD
        {
            get { return userListCAD; }
            set { userListCAD = value; }
        }
        private Nullable<System.Int32> totalLetterCount;
        public Nullable<System.Int32> TotalLetterCount
        {
            get { return totalLetterCount; }
            set { totalLetterCount = value; }
        }
        private Nullable<System.Int32> finalLetterCount;
        public Nullable<System.Int32> FinalLetterCount
        {
            get { return finalLetterCount; }
            set { finalLetterCount = value; }
        }
        private System.String edit;
        public System.String Edit
        {
            get { return edit; }
            set { edit = value; }
        }

        //added on 22/2/2012 for utlity_contact_name
        private System.String utilityContactName;
        public System.String UtilityContactName
        {
            get { return utilityContactName; }
            set { utilityContactName = value; }
        }

        //added on 22/2/2012 for fullserviceaddress
        private System.String fullServiceAddress;
        public System.String FullServiceAddress
        {
            get { return fullServiceAddress; }
            set { fullServiceAddress = value; }
        }

        //added on 22/2/2012 for cad_contact_name
        private System.String cadContactName;
        public System.String CadContactName
        {
            get { return cadContactName; }
            set { cadContactName = value; }
        }
        //added on 22/2/2012 for cad_contact_name
        private System.String cadContactEmail;
        public System.String CadContactEmail
        {
            get { return cadContactEmail; }
            set { cadContactEmail = value; }
        }

        //added on 23/2/2012
        private DateTime current_date;
        public DateTime Current_date
        {
            get { return current_date; }
            set { current_date = value; }
        }
    }
}

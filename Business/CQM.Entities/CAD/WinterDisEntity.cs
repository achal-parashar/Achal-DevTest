//---------------------------------------------------------------------
// Author: JAY Prakash  
// Version: 1.0.0
// Date: 18/May/2011
// Description: Winter Disconnect Entity
//
// History:
// Changed By          
// Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Winter Disconnect.
    /// </summary>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-18-May</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
   public class WinterDisEntity
    {
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        
        //Start Added by jay on 25 Nov 2011
        private System.String userID;
        public System.String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        
        private System.String industrysubtype;
        public System.String IndustrySubtype
        {
            get { return industrysubtype; }
            set { industrysubtype = value; }
        }
       
        private System.String casesubtype;
        public System.String CaseSubtype
        {
            get { return casesubtype; }
            set { casesubtype = value; }
        }
        private System.Int32 companyseq;
        public System.Int32 CompanySeq
        {
            get { return companyseq; }
            set { companyseq = value; }
        }
        private System.String companyname;
        public System.String CompanyName
        {
            get { return companyname; }
            set { companyname = value; }
        }
        private System.String utilitycontactname;
        public System.String UtilityContactName
        {
            get { return utilitycontactname; }
            set { utilitycontactname = value; }
        }
        private System.String accountnumber;
        public System.String AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }
        private System.Decimal memberseq;
        public System.Decimal MemberSeq
        {
            get { return memberseq; }
            set { memberseq = value; }
        }
        private System.String propertyextn1;
        public System.String PropertyExtn1
        {
            get { return propertyextn1; }
            set { propertyextn1 = value; }
        }
        private System.String propertyextn2;
        public System.String PropertyExtn2
        {
            get { return propertyextn2; }
            set { propertyextn2 = value; }
        }
        private System.String premisvisitreq;
        public System.String PremisViditReq
        {
            get { return premisvisitreq; }
            set { premisvisitreq = value; }
        }
        
        private System.Decimal totalamountdue;
        public System.Decimal TotalAmountDue
        {
            get { return totalamountdue; }
            set { totalamountdue = value; }
        }
        private System.DateTime lastbillingdate;
        public System.DateTime LastBillingDate
        {
            get { return lastbillingdate; }
            set { lastbillingdate = value; }
        }
        private System.Decimal lastbillingamount;
        public System.Decimal LastBillingAmount
        {
            get { return lastbillingamount; }
            set { lastbillingamount = value; }
        }
        private System.String noticetype;
        public System.String NoticeType
        {
            get { return noticetype; }
            set { noticetype = value; }
        }
        private System.DateTime noticedate;
        public System.DateTime NoticeDate
        {
            get { return noticedate; }
            set { noticedate = value; }
        }
        private System.Decimal noticeamount;
        public System.Decimal NoticeAmount
        {
            get { return noticeamount; }
            set { noticeamount = value; }
        }
        private System.Decimal lastpaymentamount;
        public System.Decimal LastPaymentAmount
        {
            get { return lastpaymentamount; }
            set { lastpaymentamount = value; }
        }
        private System.DateTime lastpaymentdate;
        public System.DateTime LastPaymentDate
        {
            get { return lastpaymentdate; }
            set { lastpaymentdate = value; }
        }

        private System.Decimal arrangementamount;
        public System.Decimal ArrangementAmount
        {
            get { return arrangementamount; }
            set { arrangementamount = value; }
        }
        private System.Decimal arrangementcatchup;
        public System.Decimal ArrangementCatchup
        {
            get { return arrangementcatchup; }
            set { arrangementcatchup = value; }
        }
        private System.DateTime premisevisitdate;
        public System.DateTime PremiseVisitDate
        {
            get { return premisevisitdate; }
            set { premisevisitdate = value; }
        }
        private System.DateTime date5daywarningletter;
        public System.DateTime Date5daywarningletter
        {
            get { return date5daywarningletter; }
            set { date5daywarningletter = value; }
        }
        private System.String notes;
        public System.String Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        private System.Int32 filedby;
        public System.Int32 Filedby
        {
            get { return filedby; }
            set { filedby = value; }
        }
       
        private System.Decimal dispositiontypeseq;
        public System.Decimal DispositionTypeSeq
        {
            get { return dispositiontypeseq; }
            set { dispositiontypeseq = value; }
        }
        private System.Decimal abatementamount;
        public System.Decimal AbatementAmount
        {
            get { return abatementamount; }
            set { abatementamount = value; }
        }
        private System.Boolean isviolation;
        public System.Boolean IsViolation
        {
            get { return isviolation; }
            set { isviolation = value; }
        }
        private System.Boolean imptdecision;
        public System.Boolean Imp_Decision
        {
            get { return imptdecision; }
            set { imptdecision = value; }
        }
        private System.String violationcomment;
        public System.String Violatio_Comment
        {
            get { return violationcomment; }
            set { violationcomment = value; }
        }
        private System.String violationfollowup;
        public System.String ViolationFollowUp
        {
            get { return violationfollowup; }
            set { violationfollowup = value; }
        }
        private System.Int32 numberofviolation;
        public System.Int32 NumberOfViolation
        {
            get { return numberofviolation; }
            set { numberofviolation = value; }
        }
        private System.String statustype;
        public System.String StatusType
        {
            get { return statustype; }
            set { statustype = value; }
        }

        private System.Decimal caseid;
        public System.Decimal CaseId
        {
            get { return caseid; }
            set { caseid = value; }
        }
        
        private System.Decimal dispositionseq;
        public System.Decimal DispositionSeq
        {
            get { return dispositionseq; }
            set { dispositionseq = value; }
        }
        private System.String dispositioncomments;
        public System.String DispositionComments
        {
            get { return dispositioncomments; }
            set { dispositioncomments = value; }
        }
        private System.Boolean demotecomplainttoinfocontact;
        public System.Boolean DemoteCompalintToInfContact
        {
            get { return demotecomplainttoinfocontact; }
            set { demotecomplainttoinfocontact = value; }
        }
        private System.Int32 isdeleted;
        public System.Int32 IsDeleted
        {
            get { return isdeleted; }
            set { isdeleted = value; }
        }
        private System.String createdby;
        public System.String CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private System.DateTime createddate;
        public System.DateTime CreatedDate
        {
            get { return createddate; }
            set { createddate = value; }
        }
        private System.String updatedby;
        public System.String UpdatedBy
        {
            get { return updatedby; }
            set { updatedby = value; }
        }

        private System.DateTime updateddate;
        public System.DateTime UpdateDate
        {
            get { return updateddate; }
            set { updateddate = value; }
        }

        private List<CadFilingDocEntity> docInfo = new List<CadFilingDocEntity>();
        public List<CadFilingDocEntity> DocInfo
        {
            get { return docInfo; }
            set { docInfo = value; }
        }
        private ContactDetailEntity contactInfo = new ContactDetailEntity();
        public ContactDetailEntity ContactInfo
        {
            get { return contactInfo; }
            set { if (contactInfo == null) contactInfo = new ContactDetailEntity(); else contactInfo = value; }
        }
        
        private System.String customerName;
        public System.String CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        public string IndustrySubtypeCode { get; set; }

        public string CaseTypeCode { get; set; }

        public string Arrangement_Type_Code { get; set; }

        public string IndustryTypeCode { get; set; }

        public string CaseSubTypeCode { get; set; }
        //private MatterEntity matterEntity;
        //public MatterEntity MatterEntity
        //{
        //    get { return matterEntity; }
        //    set { if (matterEntity == null)matterEntity = new MatterEntity(); else matterEntity = value; }
        //}
        //Added By : Ashish Mamodia
        //For Inbox Queue
        //private System.Decimal caseSeq;
        //public System.Decimal CaseSeq
        //{
        //    get { return caseSeq; }
        //    set { caseSeq = value; }
        //}
        // commented by jay on 1 dec 2011
        //private System.String filedby;
        //public System.String Filedby
        //{
        //    get { return filedby; }
        //    set { filedby = value; }
        //}
        //private System.Int32 casetypeseq;
        //public System.Int32 CaseTypeSeq
        //{
        //    get { return casetypeseq; }
        //    set { casetypeseq = value; }
        //}
        //private System.Int32 casesubtypeseq;
        //public System.Int32 CaseSubtypeSeq
        //{
        //    get { return casesubtypeseq; }
        //    set { casesubtypeseq = value; }
        //}
        //private System.Decimal chapter;
        //public System.Decimal ChapterSeq
        //{
        //    get { return chapter; }
        //    set { chapter = value; }
        //}
        //private System.Decimal section;
        //public System.Decimal SectionSeq
        //{
        //    get { return section; }
        //    set { section = value; }
        //}
        //private System.Decimal subsection;
        //public System.Decimal SubSectionSeq
        //{
        //    get { return subsection; }
        //    set { subsection = value; }
        //}
        //private System.Decimal arrangementseq;
        //public System.Decimal ArrangementSeq
        //{
        //    get { return arrangementseq; }
        //    set { arrangementseq = value; }
        //}//private System.Decimal addressseq;
        //public System.Decimal ADDRESS_SEQ
        //{
        //    get { return addressseq; }
        //    set { addressseq = value; }
        //}
        //private System.String roleseq;
        //public System.String RoleSeq
        //{
        //    get { return roleseq; }
        //    set { roleseq = value; }
        //}
        //End Added by jay on 25 Nov 2011
        //private System.Int32 industrysubtypeseq;
        //public System.Int32 IndustrySubtypeSeq
        //{
        //    get { return industrysubtypeseq; }
        //    set { industrysubtypeseq = value; }
        //}
        //private System.Int32 industryseq;
        //public System.Int32 IndustrySeq
        //{
        //    get { return industryseq; }
        //    set { industryseq = value; }
        //}
        //private System.Int32 userseq;
        //public System.Int32 UserSeq
        //{
        //    get { return userseq; }
        //    set { userseq = value; }
        //}
        //private System.Int32 roleseq;
        //public System.Int32 RoleSeq
        //{
        //    get { return roleseq; }
        //    set { roleseq = value; }
        //}

        //private System.String userseq;
        //public System.String UserSeq
        //{
        //    get { return userseq; }
        //    set { userseq = value; }
        //}


        //Start Added By Ashish Mamodia on 24 June 2013 for CAD round robin CR
        private StaffAssgmntEntity staffassgmnt = new StaffAssgmntEntity();
        public StaffAssgmntEntity Staffassgmnt
        {
            get
            {
                return staffassgmnt;
            }
            set
            {
                if (staffassgmnt == null)
                    staffassgmnt = new StaffAssgmntEntity();
                else
                    staffassgmnt = value;
            }
        }

        private System.String isAssignedthroughRR;
        public System.String IsAssignedthroughRR
        {
            get { return isAssignedthroughRR; }
            set { isAssignedthroughRR = value; }
        }
        //End Added By Ashish Mamodia on 24 June 2013 for CAD round robin CR
    }
}

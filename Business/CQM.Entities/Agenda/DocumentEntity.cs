//---------------------------------------------------------------------
// Author: Deepak Kumar Singh
// Version: 1.0.0
// Date: 10/22/2007
// Description: Document Entity
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
    /// This entity class stores the information about session items.
    /// </summary>
    /// <author>Deepak Kumar Singh</author>
    /// <creationDate>2007-12-01</ceationDate>
    /// <modifications>
    /// <item>2007-12-01;Deepak Singh;Added new Functions</item>
    /// <item>2007-12-22;Deepak Singh;Modified according to new database structure.</item>
    /// </modifications>
    /// 
    public class DocumentEntity
    {
        private List<AgendaStaffEntity> staffEntityList = new List<AgendaStaffEntity>();
        public List<AgendaStaffEntity> StaffEntityList
        {
            get { return staffEntityList; }
            set { staffEntityList = value; }
        }

        //DPS Session Items
        private System.Decimal agendaSeq;
        public System.Decimal AgendaSeq
        {
            get { return agendaSeq; }
            set { agendaSeq = value; }
        }

        private System.Decimal workproductSeq;
        public System.Decimal WorkproductSeq
        {
            get { return workproductSeq; }
            set { workproductSeq = value; }
        }

        private System.Decimal docSeq;
        public System.Decimal DocSeq
        {
            get { return docSeq; }
            set { docSeq = value; }
        }

        private System.String isDistributed;
        public System.String IsDistributed
        {
            get { return isDistributed; }
            set { isDistributed = value; }
        }

        private System.String isLate;
        public System.String IsLate
        {
            get { return isLate; }
            set { isLate = value; }
        }

        private System.String isLimitedDist;
        public System.String IsLimitedDist
        {
            get { return isLimitedDist; }
            set { isLimitedDist = value; }
        }

        private System.Decimal sessionItemSeq;
        public System.Decimal SessionItemSeq
        {
            get { return sessionItemSeq; }
            set { sessionItemSeq = value; }
        }
        //End DPS Session Items

        //Start DPS Work Product
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

        private System.String updatedName;
        public System.String UpdatedName
        {
            get { return updatedName; }
            set { updatedName = value; }
        }

        private System.String workproductRefNo;
        public System.String WorkproductRefNo
        {
            get { return workproductRefNo; }
            set { workproductRefNo = value; }
        }

        private System.String workproductExt;
        public System.String WorkproductExt
        {
            get { return workproductExt; }
            set { workproductExt = value; }
        }

        private System.String workproductTitle;
        public System.String WorkproductTitle
        {
            get { return workproductTitle; }
            set { workproductTitle = value; }
        }
        //End DPS Work Product

        //Start DPS Document Type
        private System.String documentType;
        public System.String DocumentType
        {
            get { return documentType; }
            set { documentType = value; }
        }

        private System.Decimal documentTypeSeq;
        public System.Decimal DocumentTypeSeq
        {
            get { return documentTypeSeq; }
            set { documentTypeSeq = value; }
        }

        private System.String isCheckOut;
        public System.String IsCheckOut
        {
            get { return isCheckOut; }
            set { isCheckOut = value; }
        }

        private System.String checkOutBy;
        public System.String CheckOutBy
        {
            get { return checkOutBy; }
            set { checkOutBy = value; }
        }

        private System.String checkOutMessage;
        public System.String CheckOutMessage
        {
            get { return checkOutMessage; }
            set { checkOutMessage = value; }
        }
        //New Entity End

        //Start Additional 

        private System.String docSecurity;
        public System.String DocSecurity
        {
            get { return docSecurity; }
            set { docSecurity = value; }
        }

        private System.String checkOutImage;
        public System.String CheckOutImage
        {
            get { return checkOutImage; }
            set { checkOutImage = value; }
        }

        private System.String lateSessionItemImage;
        public System.String LateSessionItemImage
        {
            get { return lateSessionItemImage; }
            set { lateSessionItemImage = value; }
        }

        private System.Decimal isDocSelected;
        public System.Decimal IsDocSelected
        {
            get { return isDocSelected; }
            set { isDocSelected = value; }
        }

        private System.Decimal version;
        public System.Decimal Version
        {
            get { return version; }
            set { version = value; }
        }

        private System.Decimal matterSeq;
        public System.Decimal MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
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

        private System.String matterCaseNumber;
        public System.String MatterCaseNumber
        {
            get { return matterCaseNumber; }
            set { matterCaseNumber = value; }
        }

        private System.String createdName;
        public System.String CreatedName
        {
            get { return createdName; }
            set { createdName = value; }
        }

        private System.String delete;
        public System.String Delete
        {
            get { return "Delete"; }
            set { delete = value; }
        }

        private System.Decimal totalRecords;
        public System.Decimal TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private System.String imagePath;
        public System.String ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        //For Distribution Sesssion Items

        private System.Boolean isLimitedDistBool;
        public System.Boolean IsLimitedDistBool
        {
            get { return isLimitedDistBool; }
            set { isLimitedDistBool = value; }
        }

        private System.String statusType;
        public System.String StatusType
        {
            get { return statusType; }
            set { statusType = value; }
        }

        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }

        private System.Boolean isDocSelectedForDist;
        public System.Boolean IsDocSelectedForDist
        {
            get { return isDocSelectedForDist; }
            set { isDocSelectedForDist = value; }
        }

        private System.Decimal listDtlSeq;
        public System.Decimal ListDtlSeq
        {
            get { return listDtlSeq; }
            set { listDtlSeq = value; }
        }

        private System.String isMoreSessionItem;
        public System.String IsMoreSessionItem
        {
            get { return isMoreSessionItem; }
            set { isMoreSessionItem = value; }
        }

        private System.String authorName;
        public System.String AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }

        private System.String lateSessionItemType;
        public System.String LateSessionItemType
        {
            get { return lateSessionItemType; }
            set { lateSessionItemType = value; }
        }

        private System.String lateMemorandomExt;
        public System.String LateMemorandomExt
        {
            get { return lateMemorandomExt; }
            set { lateMemorandomExt = value; }
        }

        private System.String lateMemorandomDocGUID;
        public System.String LateMemorandomDocGUID
        {
            get { return lateMemorandomDocGUID; }
            set { lateMemorandomDocGUID = value; }
        }

        private System.String fromPage;
        public System.String FromPage
        {
            get { return fromPage; }
            set { fromPage = value; }
        }

        private System.String sequence;
        public System.String Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        private System.String sessionItemTitle;
        public System.String SessionItemTitle
        {
            get { return sessionItemTitle; }
            set { sessionItemTitle = value; }
        }

        private System.String sessionItemDescription;
        public System.String SessionItemDescription
        {
            get { return sessionItemDescription; }
            set { sessionItemDescription = value; }
        }

        private System.String confidential;
        public System.String Confidential
        {
            get { return confidential; }
            set { confidential = value; }
        }

        private System.String confidentialImage;
        public System.String ConfidentialImage
        {
            get { return confidentialImage; }
            set { confidentialImage = value; }
        }

        private System.String manage;
        public System.String Manage
        {
            get { return manage; }
            set { manage = value; }
        }

        private System.String agendaStatus;
        public System.String AgendaStatus
        {
            get { return agendaStatus; }
            set { agendaStatus = value; }
        }
        //End Additional
        private System.Decimal printerSeq;
        public System.Decimal PrinterSeq
        {
            get { return printerSeq; }
            set { printerSeq = value; }
        }
        //@@@@ Start: Post Session Issue Doc
        private System.Decimal issuanceSeq;
        public System.Decimal IssuanceSeq
        {
            get { return issuanceSeq; }
            set { issuanceSeq = value; }
        }

        private System.Decimal issuanceDocSeq;
        public System.Decimal IssuanceDocSeq
        {
            get { return issuanceDocSeq; }
            set { issuanceDocSeq = value; }
        }

        private System.String docExt;
        public System.String DocExt
        {
            get { return docExt; }
            set { docExt = value; }
        }

        private System.String docName;
        public System.String DocName
        {
            get { return docName; }
            set { docName = value; }
        }

        private System.String docRefNo;
        public System.String DocRefNo
        {
            get { return docRefNo; }
            set { docRefNo = value; }
        }

        private System.String docTitle;
        public System.String DocTitle
        {
            get { return docTitle; }
            set { docTitle = value; }
        }

        private System.String isSigned;
        public System.String IsSigned
        {
            get { return isSigned; }
            set { isSigned = value; }
        }

        private System.String signedBy;
        public System.String SignedBy
        {
            get { return signedBy; }
            set { signedBy = value; }
        }

        private System.String signedDate;
        public System.String SignedDate
        {
            get { return signedDate; }
            set { signedDate = value; }
        }

        private System.String signedByDate;
        public System.String SignedByDate
        {
            get { return signedByDate; }
            set { signedByDate = value; }
        }
        //@@@@ End: Post Session Issue Doc

        private System.String limitedDistributionSessionItemImage;
        public System.String LimitedDistributionSessionItemImage
        {
            get { return limitedDistributionSessionItemImage; }
            set { limitedDistributionSessionItemImage = value; }
        }

        private System.String isSessionItemDistributeAllYellowSheetMem;
        public System.String IsSessionItemDistributeAllYellowSheetMem
        {
            get { return isSessionItemDistributeAllYellowSheetMem; }
            set { isSessionItemDistributeAllYellowSheetMem = value; }
        }
        //@@@@ Start: Post Session Issue Doc New
       
        private System.String docTitleURL;
        public System.String DocTitleURL
        {
            get { return docTitleURL; }
            set { docTitleURL = value; }
        }

        private System.String signPassword;
        public System.String SignPassword
        {
            get { return signPassword; }
            set { signPassword = value; }
        }
        //@@@@ End: Post Session Issue Doc New

        private System.String itemNumber;
        public System.String ItemNumber
        {
            get { return itemNumber; }
            set { itemNumber = value; }
        }
    }

}

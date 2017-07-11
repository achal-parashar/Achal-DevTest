//---------------------------------------------------------------------
// Author: Amitava Sinha
// Version: 1.0.0
// Date: 01/09/2008
// Description: This MatterMasterEntity class stores the Matter Metadata information.
//
// History:
// Changed By                       Changed On
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace CQM.Entities
{
    /// <summary>
    /// This MatterMasterEntity class stores the Matter Metadata information.
    /// </summary>
    /// <author>Amitava Sinha</author>
    /// <creationDate>2008-09-01</ceationDate>
    /// <modifications>
    /// <item>2008-09-01;Amitava Sinha;Added new Functions</item>
    /// <item>Date;By;Description</item>
    /// </modifications>
    /// 
    public class MatterMasterEntity
    {

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
        private System.Int32 filingNumber;
        public System.Int32 FilingNumber
        {
            get { return filingNumber; }
            set { filingNumber = value; }
        }
        private System.Int32 filingSeq;
        public System.Int32 FilingSeq
        {
            get { return filingSeq; }
            set { filingSeq = value; }
        }
        private System.String industryAffected;
        public System.String IndustryAffected
        {
            get { return industryAffected; }
            set { industryAffected = value; }
        }
        private System.String status;
        public System.String Status
        {
            get { return status; }
            set { status = value; }
        }
        private System.String matterType;
        public System.String MatterType
        {
            get { return matterType; }
            set { matterType = value; }
        }
        private System.String matterSubType;
        public System.String MatterSubType
        {
            get { return matterSubType; }
            set { matterSubType = value; }
        }
        private System.DateTime exptCompletionDate;
        public System.DateTime ExptCompletionDate
        {
            get { return exptCompletionDate; }
            set { exptCompletionDate = value; }
        }
        private System.String sapaNoticeRequired;
        public System.String SapaNoticeRequired
        {
            get { return sapaNoticeRequired; }
            set { sapaNoticeRequired = value; }
        }
        private System.String primaryCompany;
        public System.String PrimaryCompany
        {
            get { return primaryCompany; }
            set { primaryCompany = value; }
        }
        private System.String statusNotes;
        public System.String StatusNotes
        {
            get { return statusNotes; }
            set { statusNotes = value; }
        }
        private System.String relatedMatterNum;
        public System.String RelatedMatterNum
        {
            get { return relatedMatterNum; }
            set { relatedMatterNum = value; }
        }
        private System.String matterTitle;
        public System.String MatterTitle
        {
            get { return matterTitle; }
            set { matterTitle = value; }
        }
        private System.String leadOffice;
        public System.String LeadOffice
        {
            get { return leadOffice; }
            set { leadOffice = value; }
        }
        private System.String autoClose;
        public System.String AutoClose
        {
            get { return autoClose; }
            set { autoClose = value; }
        }
        private System.Decimal matterSeq;
        public System.Decimal MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
        }
        private System.String matterCaseNumber;
        public System.String MatterCaseNumber
        {
            get { return matterCaseNumber; }
            set { matterCaseNumber = value; }
        }
        private System.DateTime dateFiled;
        public System.DateTime DateFiled
        {
            get { return dateFiled; }
            set { dateFiled = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String otherOffice;
        public System.String OtherOffice
        {
            get { return otherOffice; }
            set { otherOffice = value; }
        }

        private System.String hearingRequired;
        public System.String HearingRequired
        {
            get { return hearingRequired; }
            set { hearingRequired = value; }
        }
        private List<PublicCommentEntity> publicCommentEntityList;
        public List<PublicCommentEntity> PublicCommentEntityList
        {
            get { if (publicCommentEntityList == null)publicCommentEntityList = new List<PublicCommentEntity>(); return publicCommentEntityList; }
            set { publicCommentEntityList = value; }
        }
        private List<FilingInfoEntity> filingInfoEntityList;
        public List<FilingInfoEntity> FilingInfoEntityList
        {
            get { if (filingInfoEntityList == null)filingInfoEntityList = new List<FilingInfoEntity>(); return filingInfoEntityList; }
            set { filingInfoEntityList = value; }
        }
        private List<ActivePartyListEntity> activePartyListEntityList;
        public List<ActivePartyListEntity> ActivePartyListEntityList
        {
            get { if (activePartyListEntityList == null)activePartyListEntityList = new List<ActivePartyListEntity>(); return activePartyListEntityList; }
            set { activePartyListEntityList = value; }
        }
        private List<NotificationListEntity> notificationListEntityEntity;
        public List<NotificationListEntity> NotificationListEntityEntity
        {
            get { if (notificationListEntityEntity == null)notificationListEntityEntity = new List<NotificationListEntity>(); return notificationListEntityEntity; }
            set { notificationListEntityEntity = value; }
        }
        private List<StaffAssignmentEntity> staffAssignmentEntityList;
        public List<StaffAssignmentEntity> StaffAssignmentEntityList
        {
            get { if (staffAssignmentEntityList == null)staffAssignmentEntityList = new List<StaffAssignmentEntity>(); return staffAssignmentEntityList; }
            set { staffAssignmentEntityList = value; }
        }
        private System.Int32 pageSize;
        public System.Int32 PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
        private System.Int32 pageNumber;
        public System.Int32 PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }
        private System.String orderBy;
        public System.String OrderBy
        {
            get { return orderBy; }
            set { orderBy = value; }
        }
        private System.String industrySubtypeDesc;
        public System.String IndustrySubtypeDesc
        {
            get { return industrySubtypeDesc; }
            set { industrySubtypeDesc = value; }
        }
        private System.String isAdjudicatory;
        public System.String IsAdjudicatory
        {
            get { return isAdjudicatory; }
            set { isAdjudicatory = value; }
        }
        private System.String isSecured;
        public System.String IsSecured
        {
            get { return isSecured; }
            set { isSecured = value; }
        }
        private System.String company;
        public System.String Company
        {
            get { return company; }
            set { company = value; }
        }
        private System.DateTime startDate;
        public System.DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private System.String initiatingFiler;
        public System.String InitiatingFiler
        {
            get { return initiatingFiler; }
            set { initiatingFiler = value; }
        }
        private System.String assignedStaff;
        public System.String AssignedStaff
        {
            get { return assignedStaff; }
            set { assignedStaff = value; }
        }

        public void SetValues(System.Data.IDataReader dtReader)
        {
            string fieldName;
            try
            {
                if (dtReader != null)
                {
                    for (int index = 0; index <= dtReader.FieldCount - 1; index++)
                    {
                        if (!dtReader.IsDBNull(index))
                        {
                            fieldName = dtReader.GetName(index);
                            switch (fieldName)
                            {
                                case "CASE_NUMBER":
                                    CaseNumber = Convert.ToString(dtReader[index]);
                                    break;
                                case "INDUSTRY_AFFECTED":
                                    IndustryAffected = Convert.ToString(dtReader[index]);
                                    break;
                                case "INDUSTRY_SUBTYPE_DESC":
                                    IndustrySubtypeDesc = Convert.ToString(dtReader[index]);
                                    break;
                                case "MATTER_TYPE":
                                    MatterType = Convert.ToString(dtReader[index]);
                                    break;
                                case "IS_ADJUDICATORY":
                                    IsAdjudicatory = Convert.ToString(dtReader[index]);
                                    break;
                                case "IS_SECURED":
                                    IsSecured = Convert.ToString(dtReader[index]);
                                    break;
                                case "MATTER_SUBTYPE":
                                    MatterSubType = Convert.ToString(dtReader[index]);
                                    break;
                                case "COMPANY":
                                    Company = Convert.ToString(dtReader[index]);
                                    break;
                                case "MATTER_TITLE":
                                    MatterTitle = Convert.ToString(dtReader[index]);
                                    break;
                                case "STATUS":
                                    Status = Convert.ToString(dtReader[index]);
                                    break;
                                case "START_DATE":
                                    StartDate = Convert.ToDateTime(dtReader[index]);
                                    break;
                                case "INITIATINGFILER":
                                    InitiatingFiler = Convert.ToString(dtReader[index]);
                                    break;
                                case "ASSIGNED_STAFF":
                                    AssignedStaff = Convert.ToString(dtReader[index]);
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

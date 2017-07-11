/////////////////////////////////////////////////////////////////////
// Copyright HCL Technologies Limited
//
// Version: 1.0.0
// Date: 2008-10-10
// Author: Abhishek Methi
// Description: Entity used for Confidential Document Request Page, Confidential Document Response Page,
//              and Assignment tab of My Inbox Page                
//
/////////////////////////////////////////////////////////////////////

namespace CQM.Entities
    {
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// This entity class stores the information about Confidentail Document &Inbox of Assignment tab.
    /// </summary>
    /// <author>Abhishek Methi</author>
    /// <creationDate>2008-10-10</ceationDate>
    /// <modifications>
    /// </modifications>
    /// 
    public class ConfDocumentEntity
        {
        private System.Decimal confidentialdocreqSeq;
        public System.Decimal ConfidentialdocreqSeq
            {
            get
                {
                return confidentialdocreqSeq;
                }
            set
                {
                confidentialdocreqSeq = value;
                }
            }

        private System.Decimal documentSeq;
        public System.Decimal DocumentSeq
            {
            get
                {
                return documentSeq;
                }
            set
                {
                documentSeq = value;
                }
            }

        private System.Decimal filingSeq;
        public System.Decimal FilingSeq
            {
            get
                {
                return filingSeq;
                }
            set
                {
                filingSeq = value;
                }
            }

        private System.DateTime requestDate;
        public System.DateTime RequestDate
            {
            get
                {
                return requestDate;
                }
            set
                {
                requestDate = value;
                }
            }

            private System.String requestDateString;
            public System.String RequestDateString
            {
                get
                {
                    return requestDateString;
                }
                set
                {
                    requestDateString = value;
                }
            }

        private System.String requestText;
        public System.String RequestText
            {
            get
                {
                return requestText;
                }
            set
                {
                requestText = value;
                }
            }

        private System.String statusCode;
        public System.String StatusCode
            {
            get
                {
                return statusCode;
                }
            set
                {
                statusCode = value;
                }
            }
        private System.String notificationUserId;
        public System.String NotificationUserId
            {
            get
                {
                return notificationUserId;
                }
            set
                {
                notificationUserId = value;
                }
            }

        private System.String subjectText;
        public System.String SubjectText
            {
            get
                {
                return subjectText;
                }
            set
                {
                subjectText = value;
                }
            }

        private System.Decimal userSeq;
        public System.Decimal UserSeq
            {
            get
                {
                return userSeq;
                }
            set
                {
                userSeq = value;
                }
            }
        private System.String userId;
        public System.String UserId
            {
            get
                {
                return userId;
                }
            set
                {
                userId = value;
                }
            }
        private System.String userFullName;
        public System.String UserFullName
            {
            get
                {
                return userFullName;
                }
            set
                {
                userFullName = value;
                }
            }
        private System.Decimal confidentialdocresSeq;
        public System.Decimal ConfidentialdocresSeq
            {
            get
                {
                return confidentialdocresSeq;
                }
            set
                {
                confidentialdocresSeq = value;
                }
            }

        private System.DateTime responseDate;
        public System.DateTime ResponseDate
            {
            get
                {
                return responseDate;
                }
            set
                {
                responseDate = value;
                }
            }

        private System.String responseText;
        public System.String ResponseText
            {
            get
                {
                return responseText;
                }
            set
                {
                responseText = value;
                }
            }
        private System.Decimal confidentialdocaccessSeq;
        public System.Decimal ConfidentialdocaccessSeq
            {
            get
                {
                return confidentialdocaccessSeq;
                }
            set
                {
                confidentialdocaccessSeq = value;
                }
            }

        private System.String roleName;
        public System.String RoleName
            {
            get
                {
                return roleName;
                }
            set
                {
                roleName = value;
                }
            }

        private System.String officeName;
        public System.String OfficeName
            {
            get
                {
                return officeName;
                }
            set
                {
                officeName = value;
                }
            }

        private System.String sectionName;
        public System.String SectionName
            {
            get
                {
                return sectionName;
                }
            set
                {
                sectionName = value;
                }
            }

        private System.String uRLCheck;
        public System.String URLCheck
            {
            get
                {
                return uRLCheck;
                }
            set
                {
                uRLCheck = value;
                }
            }

        private System.String requestBy;
        public System.String RequestBy
            {
            get
                {
                return requestBy;
                }
            set
                {
                requestBy = value;
                }
            }
        private System.String priority;
        public System.String Priority
            {
            get
                {
                return priority;
                }
            set
                {
                priority = value;
                }
            }
        private System.String matterNumber;
        public System.String MatterNumber
            {
            get
                {
                return matterNumber;
                }
            set
                {
                matterNumber = value;
                }
            }
        private System.String matterCaseNumber;
        public System.String MatterCaseNumber
            {
            get
                {
                return matterCaseNumber;
                }
            set
                {
                matterCaseNumber = value;
                }
            }
        private System.String caseNumber;
        public System.String CaseNumber
            {
            get
                {
                return caseNumber;
                }
            set
                {
                caseNumber = value;
                }
            }
        private System.Decimal intReqSeq;
        public System.Decimal IntReqSeq
            {
            get
                {
                return intReqSeq;
                }
            set
                {
                intReqSeq = value;
                }
            }
        private System.Decimal matterSeq;
        public System.Decimal MatterSeq
            {
            get
                {
                return matterSeq;
                }
            set
                {
                matterSeq = value;
                }
            }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
            {
            get
                {
                return totalRecords;
                }
            set
                {
                totalRecords = value;
                }
            }

        private System.DateTime dueDate;
        public System.DateTime DueDate
            {
            get
                {
                return dueDate;
                }
            set
                {
                dueDate = value;
                }
            }
            private System.String dueDateString;
            public System.String DueDateString
            {
                get
                {
                    return dueDateString;
                }
                set
                {
                    dueDateString = value;
                }
            }
        private System.String securityFlag;
        public System.String SecurityFlag
            {
            get
                {
                return securityFlag;
                }
            set
                {
                securityFlag = value;
                }
            }

        private System.DateTime filedDate;
        public System.DateTime FiledDate
            {
            get
                {
                return filedDate;
                }
            set
                {
                filedDate = value;
                }
            }
        private System.String filingCompany;
        public System.String FilingCompany
            {
            get
                {
                return filingCompany;
                }
            set
                {
                filingCompany = value;
                }
            }
        private System.Int32 docSeq;
        public System.Int32 DocSeq
            {
            get
                {
                return docSeq;
                }
            set
                {
                docSeq = value;
                }
            }
        private System.String mimeType;
        public System.String MimeType
            {
            get
                {
                return mimeType;
                }
            set
                {
                mimeType = value;
                }
            }

        private System.String docSize;
        public System.String DocSize
            {
            get
                {
                return docSize;
                }
            set
                {
                docSize = value;
                }
            }
        private System.String docTitle;
        public System.String DocTitle
            {
            get
                {
                return docTitle;
                }
            set
                {
                docTitle = value;
                }
            }
        private System.String docStatus;
        public System.String DocStatus
            {
            get
                {
                return docStatus;
                }
            set
                {
                docStatus = value;
                }
            }

        private System.Int32 itemNo;
        public System.Int32 ItemNo
            {
            get
                {
                return itemNo;
                }
            set
                {
                itemNo = value;
                }
            }
        private System.String docRefNo;
        public System.String DocRefNo
            {
            get
                {
                return docRefNo;
                }
            set
                {
                docRefNo = value;
                }
            }
        private System.String docExt;
        public System.String DocExt
            {
            get
                {
                return docExt;
                }
            set
                {
                docExt = value;
                }
            }
        private System.String doctype;
        public System.String Doctype
            {
            get
                {
                return doctype;
                }
            set
                {
                doctype = value;
                }
            }
        private System.String justificationDocExt;
        public System.String JustificationDocExt
        {
            get { return justificationDocExt; }
            set { justificationDocExt = value; }
        }
        private System.String justificationDocRefNo;
        public System.String JustificationDocRefNo
        {
            get { return justificationDocRefNo; }
            set { justificationDocRefNo = value; }
        }
        private System.String justificationImagePath;
        public System.String JustificationImagePath
        {
            get { return justificationImagePath; }
            set { justificationImagePath = value; }
        }
        private System.String justificationsecurityFlag;
        public System.String JustificationSecurityFlag
        {
            get { return justificationsecurityFlag; }
            set { justificationsecurityFlag = value; }
        }
        private System.Decimal isStaffSelected;
        public System.Decimal IsStaffSelected
        {
            get {return isStaffSelected;}
            set {isStaffSelected = value;}
        }

        private System.String statusType;
        public System.String StatusType
        {
            get { return statusType; }
            set { statusType = value; }
        }
        }

    }

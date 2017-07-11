//---------------------------------------------------------------------
// Author: Jatin Maradia
// Version: 1.0.0
// Date: 01/25/2008
// Description: Represents a List Member object.
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

namespace CQM.Entities
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    /// <summary>
    /// Represents a ListMemberEntity object.
    /// </summary>
    /// <author>Jatin Maradia</author>
    /// <creationDate>2008-01-25</ceationDate>
    /// <modifications>
    /// <item>Date ;By ;Description</item>
    /// <item>Date ;By ;Description</item>
    /// </modifications>
    public class ListMemberEntity
    {
        private System.Int32 memberSeq;
        public System.Int32 MemberSeq
        {
            get { return memberSeq; }
            set { memberSeq = value; }
        }

        private System.Int32 matterSeq;
        public System.Int32 MatterSeq
        {
            get { return matterSeq; }
            set { matterSeq = value; }
        }

        private System.Int32 servicelistSeq;
        public System.Int32 ServiceListSeq
        {
            get { return servicelistSeq; }
            set { servicelistSeq = value; }
        }

        private System.Int32 secureservicelistSeq;
        public System.Int32 SecureServiceListSeq
        {
            get { return secureservicelistSeq; }
            set { secureservicelistSeq = value; }
        }

        private System.Int32 activepartylistSeq;
        public System.Int32 ActivePartyListSeq
        {
            get { return activepartylistSeq; }
            set { activepartylistSeq = value; }
        }

        private System.Int32 mattercontactlistSeq;
        public System.Int32 MatterContactListSeq
        {
            get { return mattercontactlistSeq; }
            set { mattercontactlistSeq = value; }
        }

        private System.Int32 mailinglistSeq;
        public System.Int32 MailingListSeq
        {
            get { return mailinglistSeq; }
            set { mailinglistSeq = value; }
        }

        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        private System.String title;
        public System.String Title
        {
            get { return title; }
            set { title = value; }
        }

        private System.Int32 listNumber;
        public System.Int32 ListNumber
        {
            get { return listNumber; }
            set { listNumber = value; }
        }

        private System.String listName;
        public System.String ListName
        {
            get { return listName; }
            set { listName = value; }
        }

        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        
        //Added
        private System.String newMatterListsSeq;
        public System.String NewMatterListsSeq
        {
            get { return newMatterListsSeq; }
            set { newMatterListsSeq = value; }
        }
        private System.String commaSepMailingListsSeq;
        public System.String CommaSepMailingListsSeq
        {
            get { return commaSepMailingListsSeq; }
            set { commaSepMailingListsSeq = value; }
        }
        private System.String commaSepMatterContactListsSeq;
        public System.String CommaSepMatterContactListsSeq
        {
            get { return commaSepMatterContactListsSeq; }
            set { commaSepMatterContactListsSeq = value; }
        }
        private System.String commaSepActivePartyListsSeq;
        public System.String CommaSepActivePartyListsSeq
        {
            get { return commaSepActivePartyListsSeq; }
            set { commaSepActivePartyListsSeq = value; }
        }
        private System.String commaSepServiceListsSeq;
        public System.String CommaSepServiceListsSeq
        {
            get { return commaSepServiceListsSeq; }
            set { commaSepServiceListsSeq = value; }
        }
        private System.String commaSepSecureServiceListsSeq;
        public System.String CommaSepSecureServiceListsSeq
        {
            get { return commaSepSecureServiceListsSeq; }
            set { commaSepSecureServiceListsSeq = value; }
        }
        private System.String updatedBy;
        public System.String UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        //added by Harita Munagala for protective order access list
        private System.Int32 docSeq;
        public System.Int32 DocSeq
        {
            get { return docSeq; }
            set { docSeq = value; }
        }
    }
}

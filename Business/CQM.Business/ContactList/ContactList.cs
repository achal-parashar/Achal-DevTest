//---------------------------------------------------------------------
// Author: Jatin Maradia
// Version: 1.0.0
// Date: 01/25/2008
// Description: Represents a Business object of Service List.
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;

using CQM.Entities;
using CQM.Resource;
using CQM.Common.ExecutionResults;

namespace CQM.Business
{
    /// <summary>
    /// Represents a Business object ContactList.
    /// </summary>
    /// <author>Jatin Maradia</author>
    /// <creationDate>2008-01-25</ceationDate>
    /// <modifications>
    /// <item>Date ;By ;Description</item>
    /// <item>Date ;By ;Description</item>
    /// </modifications>
    public class ContactList
    {
        /// <summary>
        /// GetMatterContactRole methode is used to get matter contact role. e.g. Tarrif Analyst
        /// </summary>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactRoleEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/11/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item> 
        public GenericExecutionResult<List<MatterContactRoleEntity>> GetMatterContactRole()
        {
            GenericExecutionResult<List<MatterContactRoleEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactRoleEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMatterContactRole();
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// This methode is used to add new member in "Service List", or in "ActiveParty List" or in "MatterContact List" as New member as per ListName value
        /// Here member is new so information is also insert in CQM_member
        /// ListName value is used to determine member will add in which List
        /// </summary>
        /// <param name="srviceListMemberEntity">Member Information</param>
        /// <param name="ListName">ServiceList or Activity Party List or Matter Contact List</param>
        /// <returns>MemberSeq of New member</returns>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-01-25</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> AddNewMember(ContactListEntity contactListEntity, System.String listName)
        {
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(contactListEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        String str = validationResult.Message;
                        message.AppendLine(String.Format("{0}", str));
                    }
                    throw new InvalidOperationException(message.ToString());
                }
            }
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.AddNewMember(contactListEntity, listName);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        /// <summary>
        /// GetMemberList is used to get all member for given search criteria to add in any contact list. 
        /// </summary>
        /// <param name="serviceListMemberEntity">ServiceListMemberEntity contain value for search criteria</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactEntity of list type as return value</returns>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-01-25</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MatterContactEntity>> GetMemberList(ContactListEntity contactListEntity, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(contactListEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        String str = validationResult.Message;
                        message.AppendLine(String.Format("{0}", str));
                    }
                    throw new InvalidOperationException(message.ToString());
                }
            }
            GenericExecutionResult<List<MatterContactEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMemberList(contactListEntity, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        ///  GetMemberByMemberSeq method is used to get member information by member seq 
        /// </summary>
        /// <param name="MemberSeq">Member seq</param>
        /// <param name="ListName">List Name e.g. ServiceList, ActivePartyList, MatterContactList</param>
        /// <param name="CaseNumber">Case Number</param>
        /// <returns>object of GenericExecutionResult that contain object of type MatterContactRoleEntity as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/11/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<ContactListEntity> GetMemberByMemberSeq(System.Int32 memberSeq, System.String listName, System.String CaseNumber)
        {
            GenericExecutionResult<ContactListEntity> ObjGenEx = new GenericExecutionResult<ContactListEntity>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMemberByMemberSeq(memberSeq, listName, CaseNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        
        /// <summary>
        /// GetPgdMatterContactList method is used to get all matter specific member and their address information 
        /// </summary>
        /// <param name="caseNumber">case Number</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/10/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MatterContactEntity>> GetPgdMatterContactList(System.String caseNumber, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MatterContactEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetPgdMatterContactList(caseNumber, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        //GetSecuredServiceListForMember
        //added on 17/2/2012
        public GenericExecutionResult<List<ListMemberEntity>> GetSecuredServiceListForMember(System.Int32 memberSeq, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<ListMemberEntity>> ObjGenEx = new GenericExecutionResult<List<ListMemberEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetSecuredServiceListForMember(memberSeq, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
      
        public GenericExecutionResult<List<ListMemberEntity>> GetServiceListForMember(System.Int32 memberSeq, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<ListMemberEntity>> ObjGenEx = new GenericExecutionResult<List<ListMemberEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetServiceListForMember(memberSeq, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ListMemberEntity>> GetActivePartyListForMember(System.Int32 memberSeq, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<ListMemberEntity>> ObjGenEx = new GenericExecutionResult<List<ListMemberEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetActivePartyListForMember(memberSeq, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ListMemberEntity>> GetMatterContactListForMember(System.Int32 memberSeq, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<ListMemberEntity>> ObjGenEx = new GenericExecutionResult<List<ListMemberEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMatterContactListForMember(memberSeq, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ListMemberEntity>> GetMailingListForMember(System.Int32 memberSeq, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<ListMemberEntity>> ObjGenEx = new GenericExecutionResult<List<ListMemberEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMailingListForMember(memberSeq, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        

        
        /// <summary>
        /// This methode is used to add Existing Member in "Service List", or in "ActiveParty List" or in "MatterContact List" as New member as per ListName value
        /// Here member is new so information is also insert in CQM_member
        /// ListName value is used to determine member will add in which List
        /// </summary>
        /// <param name="srviceListMemberEntity">Member Information</param>
        /// <param name="ListName">ServiceList or Activity Party List or Matter Contact List</param>
        /// <returns>MemberSeq of New member</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/08/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> AddExistingMember(ContactListEntity contactListEntity, System.String listName, System.Int16 isUpdatable)
        {
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(contactListEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        String str = validationResult.Message;
                        message.AppendLine(String.Format("{0}", str));
                    }
                    throw new InvalidOperationException(message.ToString());
                }
            }
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.AddExistingMember(contactListEntity, listName, isUpdatable);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// AddNewMailinglist method is used to add new mailing list.
        /// </summary>
        /// <param name="mailingList">Object of mailingList Entity</param>
        /// <returns>MailingList seq</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>09/29/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> InsertMailingList(MailingListEntity mailingListEntity)
        {
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(mailingListEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        String str = validationResult.Message;
                        message.AppendLine(String.Format("{0}", str));
                    }
                    throw new InvalidOperationException(message.ToString());
                }
            }
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.InsertMailingList(mailingListEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// UpdateMailinglist is used to update mailing list information.
        /// </summary>
        /// <param name="mailingList">Object of mailingList Entity</param>
        /// <returns>MailingList seq</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>09/29/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> UpdateMailingList(MailingListEntity mailingListEntity)
        {
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(mailingListEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        String str = validationResult.Message;
                        message.AppendLine(String.Format("{0}", str));
                    }
                    throw new InvalidOperationException(message.ToString());
                }
            }
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.UpdateMailingList(mailingListEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// DeleteMailinglist method is used to delete mailing list by mailing list seq.
        /// </summary>
        /// <param name="mlistSeq">mailing list seq</param>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-01-25</ceationDate>
        /// <modifications>
        /// <item>19th March 2012; Ritika; Added a parameter -UpdatedBy</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> DeleteMailinglist(System.Int32 mlistSeq, System.String UpdatedBy)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.DeleteMailinglist(mlistSeq, UpdatedBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetPgdMailinglist method is used to get all mailing list.
        /// </summary>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MailingListEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>09/29/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MailingListEntity>> GetMailinglist(System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MailingListEntity>> ObjGenEx = new GenericExecutionResult<List<MailingListEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMailinglist(pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetMailinglistByMlistSeq method is used to get mailing list information.
        /// </summary>
        /// <param name="mlistSeq">mailing list seq</param>
        /// <returns>object of GenericExecutionResult that contain object of MailingListEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>09/29/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MailingListEntity>> GetMailingListBySeq(System.Int32 mlistSeq)
        {
            GenericExecutionResult<List<MailingListEntity>> ObjGenEx = new GenericExecutionResult<List<MailingListEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMailingListBySeq(mlistSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetMailingListMember methode is used to get all member of perticular mailing list.
        /// </summary>
        /// <param name="MlistSeq">mailing list sequence</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactEntity of list type as return value</returns>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-01-25</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MatterContactEntity>> GetMailingListMembers(System.Int32 mlistSeq, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MatterContactEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMailingListMembers(mlistSeq, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// DeleteMemberFromList methode is used to remove member from service list, matter contact list or mailing list. 
        /// </summary>
        /// <param name="objListMemberEntity">ListMemberEntity</param>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/04/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>        
        public GenericExecutionResult<System.Int32> RemoveMember(ListMemberEntity objListMemberEntity)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.RemoveMember(objListMemberEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetServiceListMailingList methode is used to get all mailing list associated with matter service list.
        /// </summary>
        /// <param name="caseNo">Case Number</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MailingListEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>10/31/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MailingListEntity>> GetMatterMailingList(System.String caseNo, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MailingListEntity>> ObjGenEx = new GenericExecutionResult<List<MailingListEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMatterMailingList(caseNo, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetSearchedMailingListforServiceList method used to all mailing list informtion as per given search criteria.
        /// </summary>
        /// <param name="mailingListEntity">object of MailingListEntity as a search criteria</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MailingListEntity of list type as return value</returns>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-02-02</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>       
        public GenericExecutionResult<List<MailingListEntity>> SearchedMailingList(MailingListEntity mailingListEntity, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MailingListEntity>> ObjGenEx = new GenericExecutionResult<List<MailingListEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.SearchedMailingList(mailingListEntity, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetServiceListMember method is used to get all member associate with matter service list.
        /// </summary>
        /// <param name="CaseNo">Case Number</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/01/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MatterContactEntity>> GetServiceListMember(System.String CaseNo, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MatterContactEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetServiceListMember(CaseNo, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


        /// <summary>
        /// GetActivePartyListMember method is used to get all member associate with matter active party list.
        /// </summary>
        /// <param name="CaseNumber">Case Number</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/07/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MatterContactEntity>> GetActivePartyListMember(System.String CaseNumber, System.String activePartySelected, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MatterContactEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetActivePartyListMember(CaseNumber, activePartySelected, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
       
        /// <summary>
        /// GetActivePartyListMemberForPO method is used to get all member associate with matter active party list for protective order access list.
        /// </summary>
        /// <param name="CaseNumber">Case Number</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactEntity of list type as return value</returns>
        /// <author>Harita Munagala</author>
        /// <creationDate>03/22/2012</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MatterContactEntity>> GetActivePartyListMemberForPO(System.String CaseNumber, System.String activePartySelected, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy, System.Int32 DocSeq)
        {
            GenericExecutionResult<List<MatterContactEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetActivePartyListMemberForPO(CaseNumber, activePartySelected, pageSize, pageNumber, orderBy, DocSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// AddMailingListInServiceList methode is used to add mailing list in matter service list.
        /// </summary>
        /// <param name="caseNumber">Case Number</param>
        /// <param name="MlistSeq">mailing list sequence</param>
        /// <returns>service list sequence</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>12/13/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> AddMailingList(System.String caseNumber, System.Int32 mlistSeq, System.String createdBy)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.AddMailingList(caseNumber, mlistSeq, createdBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// DeleteMailingListFromServiceList method is to remove mailing list from matter service list.
        /// </summary>
        /// <param name="CaseNo">Case Number</param>
        /// <param name="MlistSeq">Mailing list sequence</param>
        /// <returns>object of generic execution result contain int value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/01/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> RemoveMailingList(System.String CaseNo, System.Int32 mlistSeq, System.String UpdatedBy)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.RemoveMailingList(CaseNo, mlistSeq, UpdatedBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// UpdateMemberInfo is used to update member information.
        /// </summary>
        /// <param name="serviceListMemberEntity">object of ServiceListMember Entity</param>
        /// <param name="ListName">list name e.g. servicelist, activepartylist or mattercontactlist </param>
        /// <returns>object of generic execution result contain member sequence as a return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/14/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> UpdateMemberInfo(ContactListEntity serviceListMemberEntity, System.String listName)
        {
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(serviceListMemberEntity);
                if (!validationResults.IsValid)
                {
                    StringBuilder message = new StringBuilder();
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        String str = validationResult.Message;
                        message.AppendLine(String.Format("{0}", str));
                    }
                    throw new InvalidOperationException(message.ToString());
                }
            }
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.UpdateMemberInfo(serviceListMemberEntity, listName);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// ImportServiceListIntoMatter method is used to add Matter Service list into other Matter.
        /// </summary>
        /// <param name="caseNumber">Case Number</param>
        /// <param name="CaseNumberToImport">Case Number To Import</param>
        /// <param name="CreatedBy">created by</param>        
        /// <returns>object of GenericExecutionResult that contain Int value.</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>12/13/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> ImportServiceListIntoMatter(System.String caseNumber, System.String CaseNumberToImport, System.String createdBy)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.ImportServiceListIntoMatter(caseNumber, CaseNumberToImport, createdBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ContactMFEntity>> GetMembersByMemberSeq(System.String MemberSeqList, System.Int32 pageSize, System.Int32 pageNumber, System.String OrderBy)
        {
            GenericExecutionResult<List<ContactMFEntity>> ObjGenEx = new GenericExecutionResult<List<ContactMFEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMembersByMemberSeq(MemberSeqList, pageSize, pageNumber, OrderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<MailingListEntity>> GetPrintMailingListBySeq(System.String MailingListSeqList, System.Int32 pageSize, System.Int32 pageNumber, System.String OrderBy)
        {
            GenericExecutionResult<List<MailingListEntity>> ObjGenEx = new GenericExecutionResult<List<MailingListEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetPrintMailingListBySeq(MailingListSeqList, pageSize, pageNumber, OrderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<PrintLabelEmailEntity> GetUniqueMembersForPrint(System.String ServiceListContactList, System.String ServiceListMailingList, System.String ActivePartyListContactList, System.String MailingList, System.String ContactList, System.String SortOrderLabels, System.String SortOrderEmails, System.String ServiceListMatter, System.String ActivePartyMatters, System.String SecuredServiceContactList, System.String SecuredServiceMatters)
        {
            GenericExecutionResult<PrintLabelEmailEntity> ObjGenEx = new GenericExecutionResult<PrintLabelEmailEntity>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetUniqueMembersForPrint(ServiceListContactList, ServiceListMailingList, ActivePartyListContactList, MailingList, ContactList, SortOrderLabels, SortOrderEmails, ServiceListMatter, ActivePartyMatters, SecuredServiceContactList, SecuredServiceMatters);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<ContactMFEntity>> GetLabels(PrintLabelInfoEntity printLabelInfoEntity)
        {
            GenericExecutionResult<List<ContactMFEntity>> ObjGenEx = new GenericExecutionResult<List<ContactMFEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetLabels(printLabelInfoEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<System.Int32> AddContactsToServiceList(System.String caseNumber, System.String MemberSeq, System.String UserName)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.AddContactsToServiceList(caseNumber, MemberSeq, UserName);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        //@@@@ Strart - admin custom user
        public GenericExecutionResult<List<IDNameEntity>> GetUserCompanyList(System.Int32 memberSeq)
        {
            GenericExecutionResult<List<IDNameEntity>> ObjGenEx = new GenericExecutionResult<List<IDNameEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetUserCompanyList(memberSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<IDNameEntity>> GetUserESCOCompanyList(System.Int32 memberSeq)
        {
            GenericExecutionResult<List<IDNameEntity>> ObjGenEx = new GenericExecutionResult<List<IDNameEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetUserESCOCompanyList(memberSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        public GenericExecutionResult<List<SubscriptionEntity>> GetMemberMatterSubscriptionInfo(System.Int32 memberSeq)
        {
            GenericExecutionResult<List<SubscriptionEntity>> ObjGenEx = new GenericExecutionResult<List<SubscriptionEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetMemberMatterSubscriptionInfo(memberSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// UpdateMatterSubscription implements the wrapper method for business action - UpdateMatterSubscription. 
        /// </summary>
        /// <param name="subscriptionEntity">subscriptionEntity corresponding to which data to be insert</param>        
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-5-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<int> UpdateMatterSubscription(SubscriptionEntity subscriptionEntity)
        {
            GenericExecutionResult<int> ObjGenEx = new GenericExecutionResult<int>();
            try
            {
                ResContactList ObjContactList = new ResContactList();
                ObjGenEx = ObjContactList.UpdateMatterSubscription(subscriptionEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// InsertMatterSubscription implements the wrapper method for business action - InsertMatterSubscription. 
        /// </summary>
        /// <param name="subscriptionEntity">subscriptionEntity corresponding to which data to be insert</param>        
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-5-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<int> InsertMatterSubscription(SubscriptionEntity subscriptionEntity)
        {
            GenericExecutionResult<int> ObjGenEx = new GenericExecutionResult<int>();
            try
            {
                ResContactList ObjContactList = new ResContactList();
                ObjGenEx = ObjContactList.InsertMatterSubscription(subscriptionEntity);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetCaseSubscriptionInformationBySubSeq implements the wrapper method for business action - GetCaseSubscriptionInformationBySubSeq. 
        /// </summary>
        /// <param name="MatterSubSeq">Subscription Seq corresponding to which data to be retreived</param>        
        /// <returns>GenericExecutionResult object with return value-SubscriptionEntity Entity object</returns>
        /// <author>Deepak Kr. Singh</author>
        /// <creationDate>2009-05-26</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<SubscriptionEntity> GetCaseSubscriptionInformationBySubSeq(System.Int32 MatterSubSeq)
        {
            GenericExecutionResult<SubscriptionEntity> ObjGenEx = new GenericExecutionResult<SubscriptionEntity>();
            try
            {
                ResContactList ObjContactList = new ResContactList();
                ObjGenEx = ObjContactList.GetCaseSubscriptionInformationBySubSeq(MatterSubSeq);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjGenEx;
        }
        //@@@@ end - admin custom user

        /// <summary>
        /// Get all Mailing of Matter Service List.
        /// </summary>
        /// <param name="CaseNumber">Case Number</param>      
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MailingListEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/07/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MailingListEntity>> GetAllMatterMailingList(System.String CaseNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MailingListEntity>> ObjGenEx = new GenericExecutionResult<List<MailingListEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetAllMatterMailingList(CaseNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetSecuredServiceList method is used to get all matter specific member and their address information 
        /// </summary>
        /// <param name="caseNumber">case Number</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>11/21/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<MatterContactEntity>> GetSecuredServiceList(System.String caseNumber, System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<MatterContactEntity>> ObjGenEx = new GenericExecutionResult<List<MatterContactEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetSecuredServiceList(caseNumber, pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetSecuredServiceListForSearch method is used to get all matter specific member and their address information 
        /// </summary>
        /// <param name="caseNumber">case Number</param>
        /// <param name="PageSize">page size of record set</param>
        /// <param name="PageNumber">page number of record set</param>
        /// <param name="OrderBy">sort expression</param>
        /// <returns>object of GenericExecutionResult that contain object of MatterContactEntity of list type as return value</returns>
        /// <author>Suruchi Saxena</author>
        /// <creationDate>12/21/2011</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<List<ContactMFEntity>> GetSecuredServiceListForSearch(System.String caseNumber, System.String orderBy)
        {
            GenericExecutionResult<List<ContactMFEntity>> ObjGenEx = new GenericExecutionResult<List<ContactMFEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.GetSecuredServiceListForSearch(caseNumber,orderBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        #region VT integration
        /// <summary>
        /// This methode is used to add new member in "MemberContact List" as New member as per ListName value
        /// Here member is new so information is also insert in CQM_member
        /// ListName value is used to determine member will add in which List
        /// </summary>
        /// <param name="srviceListMemberEntity">Contact Information</param>
        /// <param name="ListName">Member Contact List</param>
        /// <returns>MemberSeq of New Contact</returns>
        /// <author>Rajani Patra</author>
        /// <creationDate>2012-02-03</ceationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        public GenericExecutionResult<System.Int32> AddNewContact(ContactListEntity contactListEntity)
        {
            GenericExecutionResult<System.Int32> ObjGenEx = new GenericExecutionResult<System.Int32>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.AddNewContact(contactListEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// SearchContact implements the wrapper method for business action - SearchContact. 
        /// </summary>
        /// <param name="contactEntity">Contact Entity object</param>
        /// <returns>GenericExecutionResult object with return value-List of Contacts as List of Contactentity objects</returns>
        /// <author>Rajani Patra</author>
        /// <creationDate>2012-02-10</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<ContactMFEntity>> SearchCommonContact(ContactMFEntity contactEntity, System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            GenericExecutionResult<List<ContactMFEntity>> ObjGenEx = new GenericExecutionResult<List<ContactMFEntity>>();
            try
            {
                ResContactList ObjResContactList = new ResContactList();
                ObjGenEx = ObjResContactList.SearchCommonContact(contactEntity, pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        #endregion
    }
}

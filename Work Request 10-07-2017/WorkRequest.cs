using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDb.Domain.Entities
{
    public class WorkRequest
    {
        public WorkRequest()
        {
            UnitTable = new List<Entities.UnitForWorkRequest>();
            WorkRequestAttachments = new List<Entities.Attachments>();
        }
        public int Id { get; set; }
        public int ContextId { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public int DomainId { get; set; }
        public int RequestOriginId { get; set; }
        public int TransactionTypeId { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? SubTransactionTypeId { get; set; }
        public string ContactPersonName { get; set; }
        public string TransactionDescription { get; set; }
        public int? SpecialProjectId { get; set; }
        public bool Emergency { get; set; }
        public bool AllowAddUnit { get; set; }
        public string BulkUnitNumbers { get; set; }
        public string UnitIdsToMap { get; set; }
        public string Comments { get; set; }
        public List<UnitForWorkRequest> UnitTable { get; set; }
        public string AttachedDocList { get; set; }
        public List<Attachments> WorkRequestAttachments { get; set; }
        public bool IsUnitSpecific { get; set; }

        public bool? IsEmergenyType { get; set; }
        public DateTime? FollowUpDate { get; set; }

        public short? PriorityId { get; set; }
    }
    public class UnitForWorkRequest
    {
        public int UnitId { get; set; }
        public string UnitNbr { get; set; }
        public string Vin { get; set; }
        public string TenantName { get; set; }
        public int FleetId { get; set; }
        public string Fleet { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; }

    }

    public class TransactionType
    {
        public int Id { get; set; }
        public int BuId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public bool IsUnitSpecific { get; set; }
        public string HaveSubTransaction { get; set; }
        public bool? IsEmergency { get; set; }
    }

    public class Status
    {
        public int Id { get; set; }
        public int StatusTypeId { get; set; }
        public string Name { get; set; }
        public string StatusTypeName { get; set; }
    }

    public class ListWorkRequest
    {
        public int WorkRequestId { get; set; }
        public string DomainName { get; set; }
        public string TransactionName { get; set; }
        public string SubTransactionName { get; set; }
        public int? UnitCount { get; set; }
        public string Status { get; set; }
        public DateTime? RequestDate { get; set; }
    }

    public class Attachments
    {
        public string AttachmentName { get; set; }
        public string AttachmentDisplayName { get; set; }
        public string AttachmentExtension { get; set; }
        public int AttachmentId { get; set; }
        public string DownloadUrl { get; set; }
    }

}

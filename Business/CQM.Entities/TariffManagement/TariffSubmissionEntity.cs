//---------------------------------------------------------------------
// Author: Rajani Gandha Patra
// Version: 1.0.0
// Date: 08/05/2011
// Description:TariffSubmissionEntity Class
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
    /// This entity class stores the information about TariffSubmissionEntity  property of any Entity specified.
    /// </summary>
    /// <author>Rajani Patra</author>
    /// <creationDate>2011-08-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class TariffSubmissionEntity
    {
        private IDNameTariffEntity industryType = new IDNameTariffEntity();
        public IDNameTariffEntity IndustryType
        {
            get { return industryType; }
            set { if (industryType == null) industryType = new IDNameTariffEntity(); else industryType = value; }                
        }
        //IDNameEntity
        private IDNameTariffEntity industrySubType = new IDNameTariffEntity();
        public IDNameTariffEntity IndustrySubType
        {
            get { return industrySubType; }
            set { if (industrySubType == null) industrySubType = new IDNameTariffEntity(); else industrySubType = value; }
        }
        private IDNameTariffEntity companySeq = new IDNameTariffEntity();
        public IDNameTariffEntity CompanySeq
        {
            get { return companySeq; }
            set { if (companySeq == null) companySeq = new IDNameTariffEntity(); else companySeq = value; }
        }
        private System.String filedById;
        public System.String FiledById
        {
            get { return filedById; }
            set { filedById = value; }
        }
        private System.DateTime effDate;
        public System.DateTime EffDate
        {
            get { return effDate; }
            set { effDate = value; }
        }
        private System.String refCaseNo;
        public System.String RefCaseNo
        {
            get { return refCaseNo; }
            set { refCaseNo = value; }
        }
        private System.String explFiling;
        public System.String ExplFiling
        {
            get { return explFiling; }
            set { explFiling = value; }
        }
        private System.String trfSubmissionStatus;
        public System.String TrfSubmissionStatus
        {
            get { return trfSubmissionStatus; }
            set { trfSubmissionStatus = value; }
        }
        private System.Char isExternal;
        public System.Char IsExternal
        {
            get { return isExternal; }
            set { isExternal = value; }
        }
        private System.String trfSubmissionNumber;
        public System.String TrfSubmissionNumber
        {
            get { return trfSubmissionNumber; }
            set { trfSubmissionNumber = value; }
        }
        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        private System.Char isScanned;
        public System.Char IsScanned
        {
            get { return isScanned; }
            set { isScanned = value; }
        }
        private List<TariffSubmissionDtlEntity> tariffDtlInfo = new List<TariffSubmissionDtlEntity>();
        public List<TariffSubmissionDtlEntity> TariffDtlInfo
        {
            get { return tariffDtlInfo; }
            set { tariffDtlInfo = value; }
        }
        private System.String guidno;
        public System.String GUIDno
        {
            get { return guidno; }
            set { guidno = value; }
        }
        private System.String eventFrom;
        public System.String EventFrom
        {
            get { return eventFrom; }
            set { eventFrom = value; }
        }
        private System.Int32 totalRecords;
        public System.Int32 TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        private System.String companyname;
        public System.String CompanyName
        {
            get { return companyname; }
            set { companyname = value; }
        }

        private System.String _manageTariffType;
        public System.String ManageTariffType
        {
            get { return _manageTariffType; }
            set { _manageTariffType = value; }
        }
    }
}

//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 11/22/2007
// Description: Filing Information Entity
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
    /// This entity class stores the information about Filing Information Entity
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>2007-11-22</ceationDate>
    /// <modifications>
    /// <item>2008-02-02;Ritika Fakay;Added comments</item>
    /// <item></item>
    /// </modifications>

    public class FilingInfoEntity
    {
        private System.String itemNo;
        public System.String ItemNo
        {
            get { return itemNo; }
            set { itemNo = value; }
        }

        private System.Int32 filingID;
        public System.Int32 FilingID
        {
            get { return filingID; }
            set { filingID = value; }
        }

        private System.String desc;
        public System.String Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        private System.String filedDate;
        public System.String FiledDate
        {
            get { return filedDate; }
            set { filedDate = value; }
        }

        private System.String filingCompanyName;
        public System.String FilingCompanyName
        {
            get { return filingCompanyName; }
            set { filingCompanyName = value; }
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
        private System.String descOfFiling;
        public System.String DescOfFiling
        {
            get { return descOfFiling; }
            set { descOfFiling = value; }
        }
        private System.DateTime createdDate;
        public System.DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        private System.String createdBy;
        public System.String CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        private System.String filedBy;
        public System.String FiledBy
        {
            get { return filedBy; }
            set { filedBy = value; }
        }
        private System.DateTime dateFiled;
        public System.DateTime DateFiled
        {
            get { return dateFiled; }
            set { dateFiled = value; }
        }
        private System.String statusCode;
        public System.String StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }
        private System.Int32 docCount;
        public System.Int32 DocCount
        {
            get { return docCount; }
            set { docCount = value; }
        }
        private System.Int32 totalCount;
        public System.Int32 TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        private System.Int32 count;
        public System.Int32 Count
        {
            get { return count; }
            set { count = value; }
        }
        private System.String caseNumber;
        public System.String CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        //Added By Ashish Mamodia For Rejected Filing : Date 24 May 2012
        private System.String deletedComment;
        public System.String DeletedComment
        {
            get { return deletedComment; }
            set { deletedComment = value; }
        }
        //End

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
                                case "FILING_NUMBER":
                                    FilingNumber = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "FILING_SEQ":
                                    FilingSeq = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "DESC_OF_FILING":
                                    DescOfFiling = Convert.ToString(dtReader[index]);
                                    break;
                                case "CREATED_DATE":
                                    CreatedDate = Convert.ToDateTime(dtReader[index]);
                                    break;
                                case "CREATED_BY":
                                    CreatedBy = Convert.ToString(dtReader[index]);
                                    break;
                                case "FILED_BY":
                                    FiledBy = Convert.ToString(dtReader[index]);
                                    break;
                                case "COMPANY":
                                    FilingCompanyName = Convert.ToString(dtReader[index]);
                                    break;
                                case "DATE_FILED":
                                    DateFiled = Convert.ToDateTime(dtReader[index]);
                                    break;
                                case "CASE_NUMBER":
                                    CaseNumber = Convert.ToString(dtReader[index]);
                                    break;
                                case "STATUS_CODE":
                                    StatusCode = Convert.ToString(dtReader[index]);
                                    break;
                                case "DOC_COUNT":
                                    DocCount = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "DELETED_COMMENT":
                                    DeletedComment = Convert.ToString(dtReader[index]);
                                    break;
                                case "TOTALRECORDS":
                                    TotalCount = Convert.ToInt32(dtReader[index]);
                                    break;
                                case "COUNT":
                                    Count = Convert.ToInt32(dtReader[index]);
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

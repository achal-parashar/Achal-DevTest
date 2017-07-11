//---------------------------------------------------------------------
// Author: Ajeet Kumar
// Version: 1.0.0
// Date: 10/22/2007
// Description:Implement Section Master Bussiness Class
//
// History:
// Changed By                       Changed On
//
//----------------------------------------------------------------------
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
    /// This class provide functions related to Section.
    /// </summary>
    /// <author>Ajeet Kumar</author>
    /// <creationDate>2007-10-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications> 
    /// <summary>
    public class Section
    {
        /// <summary>
        /// Delete Section By SectionSeq.
        /// </summary>
        /// <param name="SectionSeq"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> DeleteSectionBySectionSeq(System.Int32 SectionSeq)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResSection ObjResSection = new ResSection();
                ObjGenEx = ObjResSection.DeleteSectionBySectionSeq(SectionSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


        /// <summary>
        /// Insert Section.
        /// </summary>
        /// <param name="sectionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> InsertSection(SectionEntity sectionEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(sectionEntity);
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
            try
            {
                //Process object data
                ResSection ObjResSection = new ResSection();
                ObjGenEx = ObjResSection.InsertSection(sectionEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Update Section.
        /// </summary>
        /// <param name="sectionEntity"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<System.Int16> UpdateSection(SectionEntity sectionEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(sectionEntity);
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
            try
            {
                //Process object data
                ResSection ObjResSection = new ResSection();
                ObjGenEx = ObjResSection.UpdateSection(sectionEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Get all Section .
        /// </summary>
        /// <param name=""></param>
        /// <returns>Return List of SectionEntity</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public List<SectionEntity> GetSectionList()
        {
            List<SectionEntity> ObjSectionEntity = null;
            try
            {
                //Process object data
                ResSection ObjResSection = new ResSection();
                ObjSectionEntity = ObjResSection.GetSectionList();
            }
            catch
            {
                throw;
            }
            return ObjSectionEntity;
        }

        /// <summary>
        /// Get all Section  with paging and sorting functionality .
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="orderBy"></param>
        /// <returns>Return List of SectionEntity</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public GenericExecutionResult<List<SectionEntity>> GetSection(System.Int32 pageSize, System.Int32 pageNumber, System.String orderBy)
        {
            GenericExecutionResult<List<SectionEntity>> ObjSectionEntity = null;
            try
            {
                //Process object data
                ResSection ObjResSection = new ResSection();
                ObjSectionEntity = ObjResSection.GetSection(pageSize, pageNumber, orderBy);
            }
            catch
            {
                throw;
            }
            return ObjSectionEntity;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="OfficeSeq"></param>
        /// <param name="SectionName"></param>
        /// <returns></returns>
        public string GetSectionShortName(System.Decimal OfficeSeq, System.String SectionName)
        {
            string StrSectionShortName = null;
            try
            {
                ResSection ObjResSection = new ResSection();
                StrSectionShortName = ObjResSection.GetSectionShortName(OfficeSeq, SectionName);
            }
            catch
            {
                throw;
            }
            return StrSectionShortName;
        }
        /// <summary>
        /// Return list of Section based on office sequence.
        /// </summary>
        /// <param name="OfficeSeq"></param>
        /// <returns>list of Section entity</returns>
        public List<SectionEntity> GetSectionListByOfficeSeq(int OfficeSeq)
        {
            List<SectionEntity> ObjSectionEntity = null;
            try
            {
                //Process object data
                ResSection ObjResSection = new ResSection();
                ObjSectionEntity = ObjResSection.GetSectionListByOfficeSeq(OfficeSeq);
            }
            catch
            {
                throw;
            }
            return ObjSectionEntity;
        }
    }
}


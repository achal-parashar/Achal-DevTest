// Changed By: Ritika as per changes sent by the product team     Changed On 2011-12-07
// <Item>Add new property private ResMaster ResMaster</Item>
// <Item>Add new function public GenericExecutionResult<List<IndustrySubtypeEntity>> GetIndustrySubTypeListByIndustryType(System.String Utility_Type_Code)</Item>
// <Item>Add new function public List<KeyValueStruct> GetCompanybyIndSubType(string p_strIndustrySubTypeCode)</Item>
// <Item>Add new function public List<KeyValueStruct> GetCompanybyIndSubTypeExtrnal(string p_strIndustrySubTypeCode, string p_strUserSeq)</Item>
// <Item>Add new function public GenericExecutionResult<List<ContactDetailEntity>> SearchContact(ContactDetailEntity contactDetailEntity, System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)</Item>
// <Item>Add new function public CompanyEntity GetCompanyDetailsbyComapnySeq(System.Int32 CompanySeq)</Item>
// <Item>Add new function public List<KeyValueStruct> GetCompanyByUserSeq(Int32 p_UserSeq)</Item>

using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;

using CQM.Entities;
using CQM.Resource;
using CQM.Common.ExecutionResults;
using CQM.Common.Utility;

using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;

namespace CQM.Business
{
    public class Master
    {
        //added for AR integration
        private ResMaster resMaster;
        private ResMaster ResMaster
        {
            get
            {
                if (resMaster == null)
                {
                    resMaster = new ResMaster();
                    return resMaster;
                }
                else
                {
                    return resMaster;
                }
            }
        }   

        /// <summary>
        /// Get all Industry  .
        /// </summary>
        /// <param name=""></param>
        /// <returns>Return List of IndustryEntity</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<IndustryEntity>> GetIndustryList()
        {
            GenericExecutionResult<List<IndustryEntity>> ObjGenEx = new GenericExecutionResult<List<IndustryEntity>>();
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjGenEx = ObjResMaster.GetIndustryList();
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Get all  Company .
        /// </summary>
        /// <param name=""></param>
        /// <returns>List of company Entity</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public List<CompanyEntity> GetCompanyList()
        {
            List<CompanyEntity> ObjCompanyEntity = null;
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjCompanyEntity = ObjResMaster.GetCompanyList();
            }
            catch
            {
                throw;
            }
            return ObjCompanyEntity;
        }

        /// <summary>
        /// Get all MatterType .
        /// </summary>
        /// <param name=""></param>
        /// <returns>Return List of MatterTypeEntity</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public List<MatterTypeEntity> GetMatterTypeList()
        {
            List<MatterTypeEntity> ObjMatterTypeEntity = null;
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjMatterTypeEntity = ObjResMaster.GetMatterTypeList();
            }
            catch
            {
                throw;
            }
            return ObjMatterTypeEntity;
        }

        /// <summary>
        /// Get all MatterSubType .
        /// </summary>
        /// <param name=""></param>
        /// <returns>Return List of MatterSubtypeEntity</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public List<MatterSubtypeEntity> GetMatterSubTypeList()
        {
            List<MatterSubtypeEntity> ObjMatterSubtypeEntity = null;
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjMatterSubtypeEntity = ObjResMaster.GetMatterSubtypeList();
            }
            catch
            {
                throw;
            }
            return ObjMatterSubtypeEntity;
        }

        /// <summary>
        /// Get all  County .
        /// </summary>
        /// <param name=""></param>
        /// <returns>List of county Entity</returns>
        /// <author>Ajeet Kumar</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<CountyEntity>> GetCountyList()
        {
            GenericExecutionResult<List<CountyEntity>> ObjGenEx = new GenericExecutionResult<List<CountyEntity>>();
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjGenEx = ObjResMaster.GetCountyList();
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Get all Municipality by CountySeq .
        /// </summary>
        /// <param name="CountySeq"></param>
        /// <returns>Return list of MunicipalityEntity</returns>
        /// <author>Jatin D. Maradia</author>
        /// <creationDate>2007-10-22</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MunicipalityEntity>> GetMunicipalityListByCountySeq(System.Int32 CountySeq)
        {
            GenericExecutionResult<List<MunicipalityEntity>> ObjGenEx = new GenericExecutionResult<List<MunicipalityEntity>>();
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjGenEx = ObjResMaster.GetMunicipalityListByCountySeq(CountySeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// GetFranchiseForFiling implements the business action - GetFranchiseForFiling. 
        /// </summary>
        /// <param name="CountySeq">County Seq corresponding to which Franchise to be retreived</param>
        /// <param name="MunicipalitySeq">Municipality Seq corresponding to which Franchise to be retreived</param>
        /// <returns>GenericExecutionResult object with return value-List of Franchise</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<FranchiseEntity>> GetFranchiseListByMunicipalitySeq(System.Int32 MunicipalitySeq)
        {
            GenericExecutionResult<List<FranchiseEntity>> ObjGenEx = new GenericExecutionResult<List<FranchiseEntity>>();
            try
            {
                ResMaster ObjResMatter = new ResMaster();
                ObjGenEx = ObjResMatter.GetFranchiseListByMunicipalitySeq(MunicipalitySeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


        /// <summary>
        /// GetPreviousFiling implements the business action - GetPreviousFiling. 
        /// </summary>
        /// <param name="AlphabetIndex">The alphabet</param>
        /// <param name="IndustrySeq">The Industry Sequence corresponding to which Companies to be retreived</param>
        /// <returns>GenericExecutionResult object with return value-List of FilingInfo Entity objects</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2007-11-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<IDNameEntity>> GetCompanyByAlphabet(System.String AlphabetIndex, System.Int32 IndustrySeq, System.String ForPage)
        {
            GenericExecutionResult<List<IDNameEntity>> ObjGenEx = new GenericExecutionResult<List<IDNameEntity>>();
            try
            {
                ResMaster ObjResMaster = new ResMaster();
                ObjGenEx = ObjResMaster.GetCompanyByAlphabet(AlphabetIndex, IndustrySeq, ForPage);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }


        public GenericExecutionResult<List<DocumentTypeEntity>> GetDocTypeList()
        {
            GenericExecutionResult<List<DocumentTypeEntity>> ObjGen = null;
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjGen = ObjResMaster.GetDocTypeList();
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }

        /// <summary>
        /// Implements resource method GetMatterTypeListByWorkFlowRules
        /// </summary>
        /// <param name="MatterFilingType">char value '0' will retreive all the matter types being used in workflow set for office filing and '1' for external matters</param>
        /// <returns>List of MatterTypeEntity  containing list of MatterType</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2008-07-03</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterTypeEntity>> GetMatterTypeListByWorkFlowRules()
        {
            GenericExecutionResult<List<MatterTypeEntity>> ObjGen = new GenericExecutionResult<List<MatterTypeEntity>>();
            try
            {
                //Process object data
                ResMaster ObjResMattertype = new ResMaster();
                ObjGen = ObjResMattertype.GetMatterTypeListByWorkFlowRules();
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }
        
        /// <summary>
        /// Implements resource method GetMatterSubtypeListByWorkFlowRules
        /// </summary>
        /// <param name="MatterFilingType">char value '0' will retreive all the matter sub types being used in workflow set for office filing and '1' for external matters</param>
        /// <returns>List of MatterSubtypeEntity  containing list of MatterSubtype</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2008-07-03</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterSubtypeEntity>> GetMatterSubtypeListByWorkFlowRules()
        {
            GenericExecutionResult<List<MatterSubtypeEntity>> ObjGen = new GenericExecutionResult<List<MatterSubtypeEntity>>();
            try
            {
                //Process object data
                ResMaster ObjResMatterSubtype = new ResMaster();
                ObjGen = ObjResMatterSubtype.GetMatterSubtypeListByWorkFlowRules();
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CompanyEntity"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public GenericExecutionResult<List<CompanyEntity>> GetCompanyBySearchCriteria(CompanyEntity CompanyEntity, String orderBy, String ForPage, int pageSize, int pageNumber)
        {
            GenericExecutionResult<List<CompanyEntity>> ObjGenEx = new GenericExecutionResult<List<CompanyEntity>>();
            try
            {
                ResMaster ObjResMaster = new ResMaster();
                ObjGenEx = ObjResMaster.GetCompanyBySearchCriteria(CompanyEntity, orderBy, ForPage, pageSize, pageNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// added on 13/03/2012 by Harita Munagala
        /// </summary>
        /// <param name="CompanyEntity"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public GenericExecutionResult<List<CompanyEntity>> GetCompBySrchCriteriaforFavSearch(System.String industryTypeCode, System.String companyName, System.String industrySubtypeCode, System.String companyCode, System.String orderBy, System.Int32 pageSize, System.Int32 pageNumber)
        {
            GenericExecutionResult<List<CompanyEntity>> ObjGenEx = new GenericExecutionResult<List<CompanyEntity>>();
            try
            {
                ResMaster ObjResMaster = new ResMaster();
                ObjGenEx = ObjResMaster.GetCompBySrchCriteriaforFavSearch(industryTypeCode, companyName, industrySubtypeCode, companyCode, orderBy, pageSize, pageNumber);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Get all ExternalMatterType .
        /// </summary>
        /// <param name=""></param>
        /// <returns>Return List of MatterTypeEntity</returns>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-06-26</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterTypeEntity>> GetExternalMatterTypeList()
        {
            GenericExecutionResult<List<MatterTypeEntity>> ObjMatterTypeEntity = new GenericExecutionResult<List<MatterTypeEntity>>();
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjMatterTypeEntity = ObjResMaster.GetExternalMatterTypeList();
            }
            catch
            {
                throw;
            }
            return ObjMatterTypeEntity;
        }

        /// <summary>
        /// Get all ExternalMatterSubType .
        /// </summary>
        /// <param name=""></param>
        /// <returns>Return List of MatterSubtypeEntity</returns>
        /// <author>Jatin Maradia</author>
        /// <creationDate>2008-06-26</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<MatterSubtypeEntity>> GetExternalMatterSubtypeList()
        {
            GenericExecutionResult<List<MatterSubtypeEntity>> ObjMatterSubtypeEntity = new GenericExecutionResult<List<MatterSubtypeEntity>>();
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjMatterSubtypeEntity = ObjResMaster.GetExternalMatterSubtypeList();
            }
            catch
            {
                throw;
            }
            return ObjMatterSubtypeEntity;
        }

        /// <summary>
        /// GetDocTypeListForAdvanceSearch method is used to get document type for External user and Internal user in Advance Search page.
        /// </summary>
        /// <param name="RoleName">UserID</param>     
        /// <returns>List of Document Type entity.</returns>
        /// <author>JAtin Maradia</author>
        /// <creationDate>2008-07-30</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public List<DocumentTypeEntity> GetDocTypeListForAdvanceSearch(System.String RoleName,System.String DeletedRequired)
        {
            List<DocumentTypeEntity> ObjDocumentTypeEntity = null;
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjDocumentTypeEntity = ObjResMaster.GetDocTypeListForAdvanceSearch(RoleName, DeletedRequired);
            }
            catch
            {
                throw;
            }
            return ObjDocumentTypeEntity;
        }

        public List<StatusEntity> GetStatusForAdvanceSearch()
        {
            List<StatusEntity> ObjStatusEntity = null;
            try
            {
                //Process object data
                ResMaster ObjResMaster = new ResMaster();
                ObjStatusEntity = ObjResMaster.GetStatusForAdvanceSearch();
            }
            catch
            {
                throw;
            }
            return ObjStatusEntity;
        }

        /// <summary> Implements wrapper method for the business action - GetADUsersFromTable.</summary>
        /// <param name=""></param>
        /// <returns>List of Users</returns>
        /// <author>Partha Pramanick</author>
        /// <creationDate>2009-18-11</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public List<StaffEntity> GetADUsersFromTable()
        {
            List<StaffEntity> ObjStaffEntityList = null;
            ResMaster ObjResMaster = new ResMaster();
            try
            {
                ObjStaffEntityList = ObjResMaster.GetADUsersFromTable();
            }
            catch
            {
                throw;
            }
            return ObjStaffEntityList;
        }

        #region "AR integration"
        #region Get Industry Subtype List By Industry Type: GetIndustrySubTypeListByIndustryType
        /// <summary>
        /// Get Industry Subtype List By Industry Type
        /// </summary>
        /// <param name=""></param>
        /// <returns>Return List of IndustrySubTypeEntity</returns>
        /// <author>Amarendra</author>
        /// <creationDate>01/11/2011</ceationDate>
        /// <modifications>
        /// <item>17-Aug-2011;Rajani;Changed the input parameter from int to string</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<IndustrySubtypeEntity>> GetIndustrySubTypeListByIndustryType(System.String industryCode)
        {
            GenericExecutionResult<List<IndustrySubtypeEntity>> ObjGenEx = new GenericExecutionResult<List<IndustrySubtypeEntity>>();
            try
            {
                //Process object data
                ObjGenEx = ResMaster.GetIndustrySubTypeListByIndustryType(industryCode);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        #endregion

        #region Get Company by Industry Subtype Code: GetCompanybyIndSubType
        /// <summary>
        /// Get Company By Industry SubType Code .
        /// </summary>
        /// <param name="p_strIndustrySubTypeCode"></param>
        /// <returns></returns>
        /// <author>Amarendra</author>
        /// <creationDate>2011-08-20</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public List<KeyValueStruct> GetCompanybyIndSubType(string p_strIndustrySubTypeCode)
        {
            List<KeyValueStruct> p_objCompanyList = null;
            try
            {
                p_objCompanyList = ResMaster.GetCompanybyIndSubType(p_strIndustrySubTypeCode);
            }
            catch
            {
                throw;
            }
            return p_objCompanyList;
        }
        #endregion

        #region Get Company by Industry Subtype Code: GetCompanybyIndSubTypeExtrnal
        /// <summary>
        /// Get Company By Industry SubType Code .
        /// </summary>
        /// <param name="p_strIndustrySubTypeCode"></param>
        /// <param name="p_strUserSeq"></param>
        /// <returns></returns>
        /// <author>Amarendra</author>
        /// <creationDate>2011-08-20</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public List<KeyValueStruct> GetCompanybyIndSubTypeExtrnal(string p_strIndustrySubTypeCode, string p_strUserSeq)
        {
            List<KeyValueStruct> p_objCompanyList = null;
            try
            {
                p_objCompanyList = ResMaster.GetCompanybyIndSubTypeExtrnal(p_strIndustrySubTypeCode, p_strUserSeq);
            }
            catch
            {
                throw;
            }
            return p_objCompanyList;
        }
        #endregion

        #region SearchContact returns a list of Contacts as searched from the application database: SearchContact
        /// <summary>
        /// SearchContact implements the business action - SearchContact. 
        /// </summary>
        /// <param name="contactEntity">Contact Entity object</param>
        /// <returns>GenericExecutionResult object with return value-List of Contacts as List of Contactentity objects</returns>
        /// <author>Amarendera</author>
        /// <creationDate>11/01/2011</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<ContactDetailEntity>> SearchContact(ContactDetailEntity contactDetailEntity, System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy)
        {
            GenericExecutionResult<List<ContactDetailEntity>> ObjGenEx = new GenericExecutionResult<List<ContactDetailEntity>>();
            try
            {
                ObjGenEx = ResMaster.SearchContact(contactDetailEntity, pageSize, pageNumber, sortBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
        #endregion

        #region Get Company Details by Company Sequence: GetCompanyDetailsbyComapnySeq
        /// <summary>
        /// Get CompanyDetails By ComapnySeq .
        /// </summary>
        /// <param name="CompanySeq"></param>
        /// <returns></returns>
        /// <author>Amarendra</author>
        /// <creationDate>2011-11-01</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public CompanyEntity GetCompanyDetailsbyComapnySeq(System.Int32 CompanySeq)
        {
            CompanyEntity ObjCompanyEntity = null;
            try
            {
                ObjCompanyEntity = ResMaster.GetCompanyDetailsbyComapnySeq(CompanySeq);
            }
            catch
            {
                throw;
            }
            return ObjCompanyEntity;
        }
        #endregion

        #region Get Company by User Seq: GetCompanyByUserSeq
        /// <summary>
        /// Get Company By Industry SubType Code .
        /// </summary>
        /// <param name="p_UserSeq"></param>
        /// <returns></returns>
        /// <author>Amarendra</author>
        /// <creationDate>2011-11-02</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>

        public List<KeyValueStruct> GetCompanyByUserSeq(String pUserID )
        {
            List<KeyValueStruct> p_objCompanyList = null;
            try
            {
                p_objCompanyList = ResMaster.GetCompanyByUserSeq(pUserID);
            }
            catch
            {
                throw;
            }
            return p_objCompanyList;
        }
        #endregion
        #endregion

        #region "VT Integration"
        /// <summary>
        ///  Implement Get Industry Sub Type List.
        /// </summary>
        /// <returns>List of Industry Sub Type entity.</returns>
        /// <author>Rajani Patra</author>
        /// <creationDate>2011-12-29</creationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<IndustrySubtypeEntity>> GetIndustrySubTypList()
        {
            GenericExecutionResult<List<IndustrySubtypeEntity>> l_objIndustrySubTypList = new GenericExecutionResult<List<IndustrySubtypeEntity>>();
            try
            {
                l_objIndustrySubTypList = ResMaster.GetIndustrySubTypList();
            }
            catch
            {
                throw;
            }
            return l_objIndustrySubTypList;
        }        
        #endregion
    }
}

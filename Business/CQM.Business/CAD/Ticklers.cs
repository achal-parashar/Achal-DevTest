//---------------------------------------------------------------------
// Author: Ashish Mamodia  
// Version: 1.0.0
// Date: 06/03/2011
// Description:  Implement Ticklers Bussiness Class
//
// History:
// Changed By                       
//Changed On
//
//---------------------------------------------------------------------
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using CQM.Entities;
using CQM.Resource;
using CQM.Common.ExecutionResults;

using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;


namespace CQM.Business
{
    public class Ticklers
    {
        /// <summary>
        /// Method is used to get Used ID according to the user name.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-03</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<IDNameEntity> GetUserID(IDNameEntity userID)
        {
            GenericExecutionResult<IDNameEntity> ObjIDNameEntity = null;
            try
            {
                ResTicklers ObjResTicklers = new ResTicklers();
                ObjIDNameEntity = ObjResTicklers.GetUserID(userID);
            }
            catch (Exception ex)
            {                
               throw;                
            }
            return ObjIDNameEntity;
        }

        /// <summary>
        /// Method is used to get Tickler Today.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <param name="UserSeq"></param>
        /// <returns>Return object of GenericExecutionResult of list of tickler entity</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-03</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TicklerEntity>> GetTicklerToday(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy, System.Int32 UserSeq)
        {
            GenericExecutionResult<List<TicklerEntity>> ObjGenEx = new GenericExecutionResult<List<TicklerEntity>>();
            try
            {
                //Process object data
                ResTicklers ObjResTicklers = new ResTicklers();
                ObjGenEx = ObjResTicklers.GetTicklerToday(pageSize, pageNumber, sortBy,UserSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Method is used to Release Tickler.
        /// </summary>
        /// <param name="releaseID"></param>
        /// <param name="updatedBy"></param>        
        /// <returns>Return object of GenericExecutionResult</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-03</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> ReleaseTickler(System.String releaseID, System.String updatedBy)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            try
            {
                //Process object data
                ResTicklers ObjResTickler = new ResTicklers();
                ObjGenEx = ObjResTickler.ReleaseTickler(releaseID, updatedBy);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Method is used to get Tickler ToDate.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <param name="UserSeq"></param>
        /// <returns>Return object of GenericExecutionResult of list of tickler entity</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-03</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TicklerEntity>> GetTicklerToDate(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy, System.Int32 UserSeq)
        {
            GenericExecutionResult<List<TicklerEntity>> ObjGenEx = new GenericExecutionResult<List<TicklerEntity>>();
            try
            {
                //Process object data
                ResTicklers ObjResTicklers = new ResTicklers();
                ObjGenEx = ObjResTicklers.GetTicklerToDate(pageSize, pageNumber, sortBy, UserSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Method is used to get Tickler History.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <param name="UserSeq"></param>
        /// <returns>Return object of GenericExecutionResult of list of tickler entity</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-03</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TicklerEntity>> GetTicklerHistory(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy, System.Int32 UserSeq)
        {
            GenericExecutionResult<List<TicklerEntity>> ObjGenEx = new GenericExecutionResult<List<TicklerEntity>>();
            try
            {
                //Process object data
                ResTicklers ObjResTicklers = new ResTicklers();
                ObjGenEx = ObjResTicklers.GetTicklerHistory(pageSize, pageNumber, sortBy, UserSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Method is used to get Future Tickler.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="sortBy"></param>
        /// <param name="UserSeq"></param>
        /// <returns>Return object of GenericExecutionResult of list of tickler entity</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-03</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<TicklerEntity>> GetFutureTickler(System.Int32 pageSize, System.Int32 pageNumber, System.String sortBy, System.Int32 UserSeq)
        {
            GenericExecutionResult<List<TicklerEntity>> ObjGenEx = new GenericExecutionResult<List<TicklerEntity>>();
            try
            {
                //Process object data
                ResTicklers ObjResTicklers = new ResTicklers();
                ObjGenEx = ObjResTicklers.GetFutureTickler(pageSize, pageNumber, sortBy, UserSeq);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// Method is used to get User List except Logged in User..
        /// </summary>
        /// <param name="userID"></param>       
        /// <returns>Return object of GenericExecutionResult of list of IDName entity</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-03</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<List<IDNameEntity>> GetUserListExceptLoggedinUser(System.String userID)
        {
            GenericExecutionResult<List<IDNameEntity>> ObjIDNameEntity = null;
            try
            {
                ResTicklers ObjResTicklers = new ResTicklers();
                ObjIDNameEntity = ObjResTicklers.GetUserListExceptLoggedinUser(userID);
            }
            catch (Exception ex)
            {
                throw;
            }
            return ObjIDNameEntity;
        }

        /// <summary>
        /// Method is used to Send Tickler.
        /// </summary>
        /// <param name="TciklerEntity"></param>       
        /// <returns>Return object of GenericExecutionResult of list of tickler entity</returns>
        /// <author>Ashish Mamodia</author>
        /// <creationDate>2011-06-03</ceationDate>
        /// <modifications>
        /// <item>Date;By;Description</item>
        /// <item>Date;By;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Int16> SendTickler(TicklerEntity ticklerEntity)
        {
            GenericExecutionResult<System.Int16> ObjGenEx = null;
            //Entity level Validation
            bool ValidationRequired = false;
            if (ValidationRequired)
            {
                ValidationResults validationResults = Validation.ValidateFromConfiguration(ticklerEntity);
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
                ResTicklers ObjResTicklers = new ResTicklers();
                ObjGenEx = ObjResTicklers.SendTickler(ticklerEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }
    }
}

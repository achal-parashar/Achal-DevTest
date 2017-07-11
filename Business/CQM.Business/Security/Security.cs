using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Security;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

using System.Reflection;
using CQM.Entities;
using CQM.Common.ExecutionResults;
using CQM.Common.MessageRepository;
using CQM.Resource;
using System.Collections.Generic;

using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;


namespace CQM.Business
{
    public class Security
    {
        NetworkStream nwStream;
        string _funcIndicator;
        string _guId;
        string _userId;
        string _roleId;
        string _roleName;
        string _screenName;
        string _actionName;
        string _changedroleId;
        string _ProcessCode;

        string _xmlData;
        int portNo;
        string mstrIpAddress;
        string TokenId, UserId, RoleId, RoleName, Password;
        /// <summary>
        /// Implements wrapper method for the business action - InsertRoleProcess.
        /// </summary>


        public Security()
        {
            portNo = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("PortNumber"));
            mstrIpAddress = System.Configuration.ConfigurationManager.AppSettings.Get("IPAddress");
        }

        #region "Login"
        public List<LoginEntity> GetLoginInformation(string UserID)
        {
            //Process object data
            List<LoginEntity> result = null;
            try
            {
                ResSecurity objResSecurityEntity = new ResSecurity();
                result = objResSecurityEntity.GetLoginInformation(UserID);
            }
            catch
            {
                throw;
            }
            return result;
        }

        protected List<LoginEntity> removeDuplicateRecord(List<LoginEntity> ObjProcessEntityList)
        {
            List<LoginEntity> retcommentEntityList = new List<LoginEntity>();
            LoginEntity objCommentsEntity = new LoginEntity();
            foreach (LoginEntity obj1 in ObjProcessEntityList)
            {
                List<ProcessEntity> objCommentsAttachmentEntityList = new List<ProcessEntity>();
                foreach (ProcessEntity obj2 in obj1.ProcessEntityList)
                {
                    int count = 0;
                    if (objCommentsAttachmentEntityList.Count == 0)
                    {
                        objCommentsAttachmentEntityList.Add(obj2);
                    }
                    else
                    {
                        foreach (ProcessEntity obj3 in objCommentsAttachmentEntityList)
                        {
                            if (obj3.SubProcessID != 0)
                            {
                                if (obj3.SubProcessID == obj2.SubProcessID)
                                {
                                    count++;
                                }
                            }
                        }
                        if (count == 0)
                            objCommentsAttachmentEntityList.Add(obj2);
                    }

                }
                objCommentsEntity = obj1;
                objCommentsEntity.ProcessEntityList = objCommentsAttachmentEntityList;
                retcommentEntityList.Add(objCommentsEntity);
            }
            return retcommentEntityList;

        }

        protected List<LoginEntity> removeDuplicateRecordAdditional(List<LoginEntity> ObjProcessEntityList)
        {
            List<LoginEntity> retcommentEntityList = new List<LoginEntity>();
            LoginEntity objCommentsEntity = new LoginEntity();
            foreach (LoginEntity obj1 in ObjProcessEntityList)
            {
                List<ProcessEntity> objCommentsAttachmentEntityList = new List<ProcessEntity>();
                foreach (ProcessEntity obj2 in obj1.ProcessEntityList_Additional)
                {
                    int count = 0;
                    if (objCommentsAttachmentEntityList.Count == 0)
                    {
                        objCommentsAttachmentEntityList.Add(obj2);
                    }
                    else
                    {
                        foreach (ProcessEntity obj3 in objCommentsAttachmentEntityList)
                        {
                            if (obj3.SubProcessID != 0)
                            {
                                if (obj3.SubProcessID == obj2.SubProcessID)
                                {
                                    count++;
                                }
                            }
                        }
                        if (count == 0)
                            objCommentsAttachmentEntityList.Add(obj2);
                    }

                }
                objCommentsEntity = obj1;
                objCommentsEntity.ProcessEntityList_Additional = objCommentsAttachmentEntityList;
                retcommentEntityList.Add(objCommentsEntity);
            }
            return retcommentEntityList;

        }

        public string Login(string UserID)
        {

            string guid = "";

            CQM.Business.Security sec = new CQM.Business.Security();
            List<CQM.Entities.LoginEntity> loginEntity = sec.GetLoginInformation(UserID);

            List<LoginEntity> ObjLoginEntityList = new List<LoginEntity>();
            ObjLoginEntityList = removeDuplicateRecord(loginEntity);
            ObjLoginEntityList = removeDuplicateRecordAdditional(ObjLoginEntityList);
            loginEntity = ObjLoginEntityList;

            string roleCode = loginEntity[0].RoleCode.ToString();
            string userId = loginEntity[0].UserID.ToString();
            string roleName = loginEntity[0].RoleName.ToString();

            string ChkUsrVldSen = "";
            ChkUsrVldSen = CheckUserValidSession(userId);
            if (ChkUsrVldSen != "SESSION_NOT_EXISTS")
            {
                return ChkUsrVldSen;
            }
            else
            {
                guid = Guid.NewGuid().ToString();
                if (AddUserSession(guid, userId, roleCode, roleName) == true)
                {
                    if (IsRoleScrnExists(guid) == "ROLE_SCREEN_NOT_EXISTS" | IsAdditionalRoleScrnExists(guid) == "ROLE_SCREEN_NOT_EXISTS")
                    {
                        string rsXml;
                        rsXml = "<Role>";
                        for (int i = 0; i < loginEntity[0].ProcessEntityList.Count; i++)
                        {
                            rsXml = rsXml + "<Process RoleCode='";
                            if (loginEntity[0].ProcessEntityList[i].RoleCode != null)
                            {
                                rsXml = rsXml + loginEntity[0].ProcessEntityList[i].RoleCode.ToString();
                            }
                            else
                            {
                                rsXml = rsXml + " ";
                            }
                            rsXml = rsXml + "' Process_name='";
                            if (loginEntity[0].ProcessEntityList[i].SubProcessName != null)
                            {
                                rsXml = rsXml + loginEntity[0].ProcessEntityList[i].SubProcessName.ToString();
                            }
                            else
                            {
                                rsXml = rsXml + " ";
                            }
                            rsXml = rsXml + "' main_process_Id = '";
                            if (loginEntity[0].ProcessEntityList[i].MainProcessId != null)
                            {
                                rsXml = rsXml + loginEntity[0].ProcessEntityList[i].MainProcessId.ToString();
                            }
                            else
                            {
                                rsXml = rsXml + " ";
                            }
                            rsXml = rsXml + "' sub_process_Id = '";
                            if (loginEntity[0].ProcessEntityList[i].SubProcessID.ToString() != null)
                            {
                                rsXml = rsXml + loginEntity[0].ProcessEntityList[i].SubProcessID.ToString();
                            }
                            else
                            {
                                rsXml = rsXml + " ";
                            }
                            rsXml = rsXml + "' main_process_name = '";
                            if (loginEntity[0].ProcessEntityList[i].MainProcessName.ToString() != null)
                            {
                                rsXml = rsXml + loginEntity[0].ProcessEntityList[i].MainProcessName.ToString();
                            }
                            else
                            {
                                rsXml = rsXml + " ";
                            }

                            rsXml = rsXml + "' IsVisible = '";
                            if (loginEntity[0].ProcessEntityList[i].IsVisible.ToString() != null)
                            {
                                rsXml = rsXml + loginEntity[0].ProcessEntityList[i].IsVisible.ToString();
                            }
                            else
                            {
                                rsXml = rsXml + " ";
                            }
                            rsXml = rsXml + "'></Process>";
                        }
                        rsXml = rsXml + "</Role>";
                        InsertRoleScrnDetails(guid, rsXml);
                        rsXml = "";
                        rsXml = "<Role>";
                        if (loginEntity[0].ProcessEntityList_Additional.Count > 0)
                        {
                            if (IsAdditionalRoleScrnExists(guid) == "ROLE_SCREEN_NOT_EXISTS")
                            {
                                for (int i = 0; i < loginEntity[0].ProcessEntityList_Additional.Count; i++)
                                {
                                    rsXml = rsXml + "<Process User_Id='";
                                    rsXml = rsXml + userId.ToString(); //loginEntity[0].ProcessEntityList_Additional[i].RoleID.ToString();
                                    rsXml = rsXml + "' Role_Id='";
                                    if (loginEntity[0].ProcessEntityList_Additional[i].RoleCode != null)
                                    {
                                        rsXml = rsXml + loginEntity[0].ProcessEntityList_Additional[i].RoleCode.ToString();
                                    }
                                    else
                                    {
                                        rsXml = rsXml + " ";
                                    }

                                    //Role_Id
                                    rsXml = rsXml + "' Process_name='";
                                    if (loginEntity[0].ProcessEntityList_Additional[i].SubProcessName != null)
                                    {
                                        rsXml = rsXml + loginEntity[0].ProcessEntityList_Additional[i].SubProcessName.ToString();
                                    }
                                    else
                                    {
                                        rsXml = rsXml + " ";
                                    }
                                    rsXml = rsXml + "' main_process_Id = '";
                                    if (loginEntity[0].ProcessEntityList_Additional[i].MainProcessId != null)
                                    {
                                        rsXml = rsXml + loginEntity[0].ProcessEntityList_Additional[i].MainProcessId.ToString();
                                    }
                                    else
                                    {
                                        rsXml = rsXml + " ";
                                    }
                                    rsXml = rsXml + "' sub_process_Id = '";
                                    if (loginEntity[0].ProcessEntityList_Additional[i].SubProcessID.ToString() != null)
                                    {
                                        rsXml = rsXml + loginEntity[0].ProcessEntityList_Additional[i].SubProcessID.ToString();
                                    }
                                    else
                                    {
                                        rsXml = rsXml + " ";
                                    }
                                    rsXml = rsXml + "' main_process_name = '";
                                    if (loginEntity[0].ProcessEntityList_Additional[i].MainProcessName.ToString() != null)
                                    {
                                        rsXml = rsXml + loginEntity[0].ProcessEntityList_Additional[i].MainProcessName.ToString();
                                    }
                                    else
                                    {
                                        rsXml = rsXml + " ";
                                    }
                                    rsXml = rsXml + "'></Process>";
                                }
                                rsXml = rsXml + "</Role>";
                                InsertAdditionalRoleScrnDetails(guid, rsXml);
                                //string b = GetScreensList(guid);
                            }
                        }
                    }
                }

                if (IsRoleActionExists(guid) == "ROLE_ACTION_NOT_EXISTS")
                {
                    string raXml;
                    raXml = "<Role>";
                    for (int i = 0; i < loginEntity[0].ProcessActivityEntityList.Count; i++)
                    {
                        raXml = raXml + "<Action Role_Id='" + roleCode.ToString() + "' Process_Seq='" + loginEntity[0].ProcessActivityEntityList[i].ProcessID.ToString() + "' actv_seq='" + loginEntity[0].ProcessActivityEntityList[i].ActivityCode.ToString() + "' actv_action_name='" + loginEntity[0].ProcessActivityEntityList[i].ActivityName.ToString() + "' Process_ID='" + loginEntity[0].ProcessActivityEntityList[i].ProcessCode.ToString() + "' Process_Name='" + loginEntity[0].ProcessActivityEntityList[i].ProcessName.ToString() + "'></Action>";
                    }
                    raXml = raXml + "</Role>";
                    InsertRoleActionDetails(guid, raXml);
                    raXml = "";
                    raXml = "<Role>";
                    if (loginEntity[0].ProcessActivityEntityList_Additional.Count > 0)
                    {
                        if (IsAdditionalRoleActionExists(guid) == "ROLE_ACTION_NOT_EXISTS")
                        {
                            for (int i = 0; i < loginEntity[0].ProcessActivityEntityList_Additional.Count; i++)
                            {
                                raXml = raXml + "<Action User_ID='" + userId.ToString();
                                raXml = raXml + "<Action Role_ID='" + roleCode.ToString();
                                raXml = raXml + "' Process_Seq='" + loginEntity[0].ProcessActivityEntityList_Additional[i].ProcessID.ToString();
                                raXml = raXml + "' actv_seq='" + loginEntity[0].ProcessActivityEntityList_Additional[i].ActivityCode.ToString();
                                raXml = raXml + "' actv_action_name='" + loginEntity[0].ProcessActivityEntityList_Additional[i].ActivityName.ToString();
                                raXml = raXml + "' Process_ID='" + loginEntity[0].ProcessActivityEntityList_Additional[i].ProcessCode.ToString() + "' Process_Name='" + loginEntity[0].ProcessActivityEntityList_Additional[i].ProcessName.ToString() + "'></Action>";
                            }
                            raXml = raXml + "</Role>";
                            AdditionalInsertRoleActionDetails(guid, raXml);
                        }
                    }
                }
            }
            return guid;
        }

        /// <Purpose> 
        /// The function inserts the role action relationship. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// <param name="xmlData" type="string">Xml string containing the relationhip</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status of action 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Mukesh " ChangeDescription="Created function that inserts the Additional role action relationship." 
        /// Date: 26-Dec-2007 
        /// </RevisionHistory> 
        public string AdditionalInsertRoleActionDetails(string tokenId, string xmlData)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "IARAD";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = xmlData;
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {
                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }
        /// <Purpose> 
        /// The function checks whether the Additional role screen relationship exists for the user role. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Mukesh K" ChangeDescription="Created function that checks whether the role screen relationship exists for the user role." 
        /// Date: 23-Dec-2007 
        /// </RevisionHistory> 
        public string IsAdditionalRoleActionExists(string tokenId)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "IARAE";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {

                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }
        /// <Purpose> 
        /// The function inserts the role action relationship. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// <param name="xmlData" type="string">Xml string containing the relationhip</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status of action 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Amit" ChangeDescription="Created function that inserts the role action relationship." 
        /// Date: 18-Dec-2006 
        /// </RevisionHistory> 
        public string InsertRoleActionDetails(string tokenId, string xmlData)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "IRAD";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = xmlData;
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {

                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }
        /// <Purpose> 
        /// The function inserts an entry for the user in windows service. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="String">This contains the tokenId of loged on user</param> 
        /// <param name="userId" type="String">This contains the userId of loged on user</param> 
        /// <param name="roleId" type="String">This contains the roleId of loged on user</param> 
        /// <param name="roleName" type="String">This contains the roleName of loged on user</param> 
        /// <param name="workPosId" type="String">This contains the workPosId of loged on user</param> 
        /// <param name="password" type="String">This contains the password of loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue name="returnStatus" type="Boolean"> 
        /// True or false indicating successful or unsuccessful addition 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Amit" ChangeDescription="Created function that inserts an entry for user in windows service" 
        /// Date: 18-Dec-2006 
        /// </RevisionHistory> 
        public bool AddUserSession(string tokenId, string userId, string roleId, string roleName)
        {
            string textToSend;
            bool returnStatus = false;
            _funcIndicator = "AUS";
            _guId = tokenId.Trim();
            _userId = userId.Trim();
            _roleId = roleId.Trim();
            _roleName = roleName.Trim();
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            //Try 
            if (tokenId != "" & roleId != "")
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {
                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = bool.Parse(Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead));
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }
        /// <Purpose> 
        /// The function checks whether the userId session exits or not. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the UserId of the loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Mukesh K" ChangeDescription="Created function that checks whether the UserId session Exits." 
        /// Date: 23-Dec-2007 
        /// </RevisionHistory> 
        public string CheckUserValidSession(string UserId)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "CUVS";
            _guId = "";
            _userId = UserId;
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (_userId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {
                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }
        //#endregion

        public GenericExecutionResult<LoginEntity> IsCustomValidUser(LoginEntity ObjLoginEntity)
        {
            GenericExecutionResult<LoginEntity> ObjGenEx = new GenericExecutionResult<LoginEntity>();
            try
            {
                ResSecurity ObjResSecurity = new ResSecurity();
                ObjGenEx = ObjResSecurity.IsCustomValidUser(ObjLoginEntity);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <summary>
        /// IsUserExisting implements the business wrapper for resource method IsUserExisting
        /// </summary>
        /// <param name="UserID">The UserID to check</param>
        /// <returns>true if UserID exists else false</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2008-07-23</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Boolean> IsUserExisting(System.String UserID)
        {
            GenericExecutionResult<System.Boolean> ObjGen = new GenericExecutionResult<System.Boolean>();
            try
            {
                ResSecurity ObjResSecurity = new ResSecurity();
                ObjGen = ObjResSecurity.IsUserExisting(UserID);
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }

        /// <summary>
        /// IsEmailExisting implements the business wrapper for resource method IsEmailExisting
        /// </summary>
        /// <param name="EmailID">The EmailID to check</param>
        /// <returns>true if EmailID exists else false</returns>
        /// <author>Deepak Singh</author>
        /// <creationDate>2008-07-23</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<System.Boolean> IsEmailExisting(System.String EmailID)
        {
            GenericExecutionResult<System.Boolean> ObjGen = new GenericExecutionResult<System.Boolean>();
            try
            {
                ResSecurity ObjResSecurity = new ResSecurity();
                ObjGen = ObjResSecurity.IsEmailExisting(EmailID);
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }


        public GenericExecutionResult<MemberEntity> CheckMailAndUniqueIDAuthenticity(System.String EmailID, System.String UniqueID)
        {
            GenericExecutionResult<MemberEntity> ObjGen = new GenericExecutionResult<MemberEntity>();
            try
            {
                ResSecurity ObjResSecurity = new ResSecurity();
                ObjGen = ObjResSecurity.CheckMailAndUniqueIDAuthenticity(EmailID, UniqueID);
            }
            catch
            {
                throw;
            }
            return ObjGen;
        }


        /// <Purpose> 
        /// The function gets all the screens for which user is authorized. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// List of screens 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Mukesh K" ChangeDescription="Created function that gets all the screens for which user is authorized" 
        /// Date: 23-Dec-2007 
        /// </RevisionHistory> 
        public string GetScreensList(string tokenId)
        {
            string textToSend;
            string ReturnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "GSL";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {
                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    ReturnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return ReturnStatus;
        }

        /// <summary>
        /// GetExternalUserLoginDetails implements the business action - GetExternalUserLoginDetails. 
        /// </summary>
        /// <param name="UserID">The UserID of the external user</param>
        /// <returns>Object of GenericExecutionResult with LoginEntity</returns>
        /// <author>Ritika Fakay</author>
        /// <creationDate>2008-02-27</creationDate>
        /// <modifications>
        /// <item>Date ;By ;Description</item>
        /// </modifications>
        public GenericExecutionResult<LoginEntity> GetExternalUserLoginDetails(System.String UserID)
        {
            GenericExecutionResult<LoginEntity> ObjGenEx = new GenericExecutionResult<LoginEntity>();
            try
            {
                ResSecurity ObjResSecurity = new ResSecurity();
                ObjGenEx = ObjResSecurity.GetExternalUserLoginDetails(UserID);
            }
            catch
            {
                throw;
            }
            return ObjGenEx;
        }

        /// <Purpose> 
        /// The function checks whether the session of user exists or not. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="String">This contains the tokenId of loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue name="returnStatus" type="string"> 
        /// The status of session 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Amit" ChangeDescription="Created function that checks whether the session of user exists or not" 
        /// Date: 18-Dec-2006 
        /// </RevisionHistory> 
        public string CheckValidSession(string tokenId)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "CVS";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {

                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    //textToSend = "CVS|" & tokenId.Trim & "|" & "" & "|" & "1" & "|" & "" & "|" & "" & "|" & "" & "|" & "" 
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }

        /// <Purpose> 
        /// The function gets all the actions for which user is authorized. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// List of actions 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Mukesh K" ChangeDescription="Created function that gets all the actions for which user is authorized" 
        /// Date: 23-Dec-2007 
        /// </RevisionHistory> 
        public string GetActionsList(string tokenId, string processCode)
        {
            string textToSend;
            string ReturnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "GAL";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = processCode;
            _xmlData = "";
            //'Forming the pipe seperated string to be sent to the port. 
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {
                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    ReturnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return ReturnStatus;
        }

        /// <Purpose> 
        /// The function checks whether the role screen relationship exists for the user role. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Mukesh K" ChangeDescription="Created function that checks whether the role screen relationship exists for the user role." 
        /// Date: 23-Dec-2007 
        /// </RevisionHistory> 
        public string IsRoleScrnExists(string tokenId)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "IRSE";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {

                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }
        /// <Purpose> 
        /// The function deletes an entry of user/user session from the windows service. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="String">This contains the tokenId of loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue name="returnStatus" type="boolean"> 
        /// True or false depending whether the session is deleted successfully or not. 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Amit" ChangeDescription="Created function that deletes an entry of user/user session from the windows service." 
        /// Date: 18-Dec-2006 
        /// </RevisionHistory> 
        public bool LogOut(string tokenId)
        {
            string textToSend;
            bool returnStatus = false;
            //'Assigning to the module level variables 
            _funcIndicator = "LOS";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {

                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = bool.Parse(Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead));
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }
        /// <Purpose> 
        /// The function checks whether the role screen relationship exists for the user role. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Mukesh K" ChangeDescription="Created function that checks whether the role screen relationship exists for the user role." 
        /// Date: 23-Dec-2007 
        /// </RevisionHistory> 
        public string IsAdditionalRoleScrnExists(string tokenId)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "IRSAE";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {

                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }

        /// <Purpose> 
        /// The function inserts the role screen relationship. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// <param name="xmlData" type="string">Xml string containing the relationhip</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status of action 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Amit" ChangeDescription="Created function that inserts the role screen relationship." 
        /// Date: 18-Dec-2006 
        /// </RevisionHistory> 
        public string InsertRoleScrnDetails(string tokenId, string xmlData)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "IRSD";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = xmlData;
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {
                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    //textToSend = "IRSD|" & tokenId.Trim & "|" & "" & "|" & "1" & "|" & "" & "|" & "" & "|" & "" & "|" & xmlData.Trim 
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }

        /// <Purpose> 
        /// The function inserts the role screen relationship. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// <param name="xmlData" type="string">Xml string containing the relationhip</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status of action 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Amit" ChangeDescription="Created function that inserts the role screen relationship." 
        /// Date: 18-Dec-2006 
        /// </RevisionHistory> 
        public string InsertAdditionalRoleScrnDetails(string tokenId, string xmlData)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "IRSAD";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = xmlData;
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                lock (tcpclient)
                {
                    tcpclient.Connect(mstrIpAddress, portNo);
                    nwStream = tcpclient.GetStream();
                    //textToSend = "IRSD|" & tokenId.Trim & "|" & "" & "|" & "1" & "|" & "" & "|" & "" & "|" & "" & "|" & xmlData.Trim 
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                    object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                    returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                    nwStream.Close();
                    tcpclient.Close();
                }
            }
            return returnStatus;
        }

        /// <Purpose> 
        /// The function checks whether the role screen relationship exists for the user role. 
        /// </Purpose> 
        /// <Inputs> 
        /// <param name="tokenId" type="string">This contains the tokenId of the loged on user</param> 
        /// </Inputs> 
        /// <Outputs>None</Outputs> 
        /// <ReturnValue type="string"> 
        /// returns the status 
        /// </ReturnValue> 
        /// <RevisionHistory> 
        /// Author:"Mukesh K" ChangeDescription="Created function that checks whether the role screen relationship exists for the user role." 
        /// Date: 23-Dec-2007 
        /// </RevisionHistory> 
        public string IsRoleActionExists(string tokenId)
        {
            string textToSend;
            string returnStatus = "";
            //'Assigning to the module level variables 
            _funcIndicator = "IRAE";
            _guId = tokenId.Trim();
            _userId = "";
            _roleId = "";
            _roleName = "";
            _screenName = "";
            _actionName = "";
            _changedroleId = "";
            _ProcessCode = "";
            _xmlData = "";
            textToSend = _funcIndicator + "|" + _guId + "|" + _userId + "|" + _roleId + "|" + _roleName + "|" + _screenName + "|" + _actionName + "|" + _changedroleId + "|" + _ProcessCode + "|" + _xmlData;
            if (tokenId.Length > 0)
            {
                System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();
                tcpclient.Connect(mstrIpAddress, portNo);
                nwStream = tcpclient.GetStream();
                byte[] bytesToSend = Encoding.ASCII.GetBytes(textToSend);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                byte[] bytesToRead = new byte[tcpclient.ReceiveBufferSize + 1];
                object numBytesRead = nwStream.Read(bytesToRead, 0, tcpclient.ReceiveBufferSize);
                returnStatus = Encoding.ASCII.GetString(bytesToRead, 0, (int)numBytesRead);
                tcpclient.Close();
            }
            return returnStatus;
        }
    }
}
        #endregion
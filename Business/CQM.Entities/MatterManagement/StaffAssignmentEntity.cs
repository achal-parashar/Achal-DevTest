using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQM.Entities
{
   public class StaffAssignmentEntity
    {
       private System.Int32 serialNo;
       public System.Int32 SerialNo
       {
           get { return serialNo; }
           set { serialNo = value; }
       }
       private System.Int32 userMatterRoleSeq;
       public System.Int32 UserMatterRoleSeq
       {
           get { return userMatterRoleSeq; }
           set { userMatterRoleSeq = value; }
       }
       private System.String fullName;
       public System.String FullName
       {
           get { return fullName; }
           set { fullName = value; }
       }
       private System.String roleName;
       public System.String RoleName
       {
           get { return roleName; }
           set { roleName = value; }
       }
       private System.DateTime assignDate;
       public System.DateTime AssignDate
       {
           get { return assignDate; }
           set { assignDate = value; }
       }
       private System.String createdBy;
       public System.String CreatedBy
       {
           get { return createdBy; }
           set { createdBy = value; }
       }
       private System.Int32 count;
       public System.Int32 Count
       {
           get { return count; }
           set { count = value; }
       }
       private System.Int32 totalCount;
       public System.Int32 TotalCount
       {
           get { return totalCount; }
           set { totalCount = value; }
       }

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
                               case "SERIAL_NO":
                                   SerialNo = Convert.ToInt32(dtReader[index]);
                                   break;
                               case "USER_MATTER_ROLE_SEQ":
                                   UserMatterRoleSeq = Convert.ToInt32(dtReader[index]);
                                   break;
                               case "STAFF_NAME":
                                   FullName = Convert.ToString(dtReader[index]);
                                   break;
                               case "ROLE_NAME":
                                   RoleName = Convert.ToString(dtReader[index]);
                                   break;
                               case "ASSIGN_DATE":
                                   AssignDate = Convert.ToDateTime(dtReader[index]);
                                   break;
                               case "CREATED_BY":
                                   CreatedBy = Convert.ToString(dtReader[index]);
                                   break;
                               case "TOTALCOUNT":
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

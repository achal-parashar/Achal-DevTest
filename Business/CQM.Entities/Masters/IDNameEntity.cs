/////////////////////////////////////////////////////////////////////
// Version: 1.0.0
// Date: 12/05/2007
// Author: Abhishek Methi
// Description: Initial Creation
// History:
// Changed By                       Changed On
/////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
 

    /// <summary>
    /// This entity class stores the information about "id" and "Name"  property of any Entity specified.
    /// </summary>
    /// <author>Abhishek Methi</author>
    /// <creationDate>2007-05-12</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class IDNameEntity
    {
        private System.Decimal id;
        public System.Decimal ID
        {
            get { return id; }
            set { id = value; }
        }

        private System.String name;
        public System.String Name
        {
            get { return name; }
            set { name = value; }
        }

        private System.String code;
        public System.String Code
        {
            get { return code; }
            set { code = value; }
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
                                case "NAME":
                                    Name = Convert.ToString(dtReader[index]);
                                    break;
                                case "ID":
                                    ID = Convert.ToDecimal(dtReader[index]);
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

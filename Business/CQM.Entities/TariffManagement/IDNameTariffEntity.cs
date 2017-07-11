using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
 

    /// <summary>
    /// This entity class stores the information about "id" and "Name"  property of any Entity specified.
    /// </summary>
    /// <author>Rajani Patra</author>
    /// <creationDate>2011-08-22</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    /// 
    public class IDNameTariffEntity
    {
        private System.String id;
        public System.String ID
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
        
    }
}

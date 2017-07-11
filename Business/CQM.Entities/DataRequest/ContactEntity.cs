

namespace CQM.Entities
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ServiceModel;
    using System.Runtime.Serialization;

    [DataContract]
    [Serializable]
    public class ContactEntity
    {
        [DataMember]
        public string Suffix { get; set; }


        [DataMember]
        public System.String FName { get; set; }

        [DataMember]
        public System.String MName { get; set; }

        [DataMember]
        public System.String LName { get; set; }

        [DataMember]
        public System.String Company { get; set; }

        [DataMember]
        public System.String StreetAddress { get; set; }

        [DataMember]
        public System.String City { get; set; }

        [DataMember]
        public System.String State { get; set; }

        [DataMember]
        public System.String ZipCode { get; set; }

        [DataMember]
        public System.String PhoneNo { get; set; }

        [DataMember]
        public System.String FaxNo { get; set; }

        [DataMember]
        public System.String Extn { get; set; }

        [DataMember]
        public System.String EmailId { get; set; }

        [DataMember]
        public System.String PrefContactMethod { get; set; }

        [DataMember]
        public System.String Interagency { get; set; }

        [DataMember]
        public System.String CreatedBy { get; set; }

        [DataMember]
        public System.String Country { get; set; }

        [DataMember]
        public System.Int32 MemberSeq { get; set; }

        [DataMember]
        public System.Boolean IsSuccessfull { get; set; }
      
        [DataMember]
        public System.Int32 TotalRecords { get; set; }

        [DataMember]
        public System.String Prefix { get; set; }
        
            
        [DataMember]
        public System.String Title { get; set; }

        [DataMember]
        public System.String UserID { get; set; }


            
            
    }
}

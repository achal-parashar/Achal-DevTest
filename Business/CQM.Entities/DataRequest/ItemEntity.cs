

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
    public class ItemEntity
    {
        [DataMember]
        public bool IsSuccessfull { get; set; }


        [DataMember]
        public System.String ItemCode { get; set; }

        [DataMember]
        public System.String ItemDesc { get; set; }

        [DataMember]
        public System.Int32 ItemSeq { get; set; }

        [DataMember]
        public System.String ItemDescTwo { get; set; }

        [DataMember]
        public System.String ItemDescThree { get; set; }

        [DataMember]
        public System.String ItemDescFour { get; set; }

        [DataMember]
        public System.String ItemDescFive { get; set; }

        [DataMember]
        public System.String ItemDescSix { get; set; }

        [DataMember]
        public System.String ItemDescSeven { get; set; }
    }
}

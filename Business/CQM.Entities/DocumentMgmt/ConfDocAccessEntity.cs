/////////////////////////////////////////////////////////////
// Copyright HCL Technologies Limited
//
// Version: 1.0.0
// Date: 2008-10-10
// Author: Abhishek Methi
// Description: Entity used for Confidential Document Respose Page to update confidential Document Access Table,
//
/////////////////////////////////////////////////////////////////////

namespace CQM.Entities
    {
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// This entity class stores the information about Confidentail Document Response page for Docuemt Access.
    /// </summary>
    /// <author>Abhishek Methi</author>
    /// <creationDate>2008-10-10</ceationDate>
    /// <modifications>
    /// </modifications>
    /// 
    public class ConfDocAccessEntity
        {

        private System.Decimal confidentialdocaccessSeq;
        public System.Decimal ConfidentialdocaccessSeq
            {
            get
                {
                return confidentialdocaccessSeq;
                }
            set
                {
                confidentialdocaccessSeq = value;
                }
            }

        private System.String confidentialdocRevokeSeq;
        public System.String ConfidentialdocRevokeSeq
            {
            get
                {
                return confidentialdocRevokeSeq;
                }
            set
                {
                confidentialdocRevokeSeq = value;
                }
            }

        private System.Decimal documentSeq;
        public System.Decimal DocumentSeq
            {
            get
                {
                return documentSeq;
                }
            set
                {
                documentSeq = value;
                }
            }


        private System.DateTime accessDate;
        public System.DateTime AccessDate
            {
            get
                {
                return accessDate;
                }
            set
                {
                accessDate = value;
                }
            }

        private System.DateTime deniedDate;
        public System.DateTime DeniedDate
            {
            get
                {
                return deniedDate;
                }
            set
                {
                deniedDate = value;
                }
            }

        private System.Decimal userSeq;
        public System.Decimal UserSeq
            {
            get
                {
                return userSeq;
                }
            set
                {
                userSeq = value;
                }
            }
        private System.String isAccessible;
        public System.String IsAccessible
            {
            get
                {
                return isAccessible;
                }
            set
                {
                isAccessible = value;
                }
            }
        private System.String isRead;
        public System.String IsRead
            {
            get
                {
                return isRead;
                }
            set
                {
                isRead = value;
                }
            }
        private System.String userId;
        public System.String UserId
            {
            get
                {
                return userId;
                }
            set
                {
                userId = value;
                }
            }
        private System.String docStatus;
        public System.String DocStatus
            {
            get
                {
                return docStatus;
                }
            set
                {
                docStatus = value;
                }
            }


        private System.Boolean isSelfRevoked;
        public System.Boolean IsSelfRevoked
            {
                get
                {
                    return isSelfRevoked;
                }
                set
                {
                    isSelfRevoked = value;
                }
            }

            private System.String sentFrom;
            public System.String SentFrom
            {
                get
                {
                    return sentFrom;
                }
                set
                {
                    sentFrom = value;
                }
            }


        }

    }

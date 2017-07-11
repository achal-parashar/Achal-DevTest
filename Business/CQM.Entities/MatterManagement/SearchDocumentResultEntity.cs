//---------------------------------------------------------------------
// Author: Ritika Fakay
// Version: 1.0.0
// Date: 07-13-2009
// Description: SearchDocumentResultEntity Entity
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about the result sets of the SearchDocument
    /// </summary>
    /// <author>Ritika Fakay</author>
    /// <creationDate>07-13-2009</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class SearchDocumentResultEntity
    {
        private List<MatterDocumentEntity> publicDocuments;
        private List<MatterDocumentEntity> internalDocuments;
        private List<PublicCommentEntity> publicComments;

        public List<MatterDocumentEntity> PublicDocuments
        {
            get { return publicDocuments; }
            set { publicDocuments = value; }
        }
        public List<MatterDocumentEntity> InternalDocuments
        {
            get { return internalDocuments; }
            set { internalDocuments = value; }
        }

        public List<PublicCommentEntity> PublicComments
        {
            get { return publicComments; }
            set { publicComments = value; }
        }

    }
}

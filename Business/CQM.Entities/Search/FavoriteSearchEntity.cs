//---------------------------------------------------------------------
// Author: Deepak Kr Singh
// Version: 1.0.0
// Date: 26/12/2007
// Description: FavoriteSearchEntity
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
    /// This entity class stores the information about FavoriteSearchEntity required for search favorites
    /// </summary>
    /// <author>Deepak Kr. Singh</author>
    /// <creationDate>2007-12-26</ceationDate>
    /// <modifications>
    /// <item></item>
    /// </modifications>
    public class FavoriteSearchEntity
    {
        private System.Int32 favoriteSearchSeq;
        public System.Int32 FavoriteSearchSeq
        {
            get { return favoriteSearchSeq; }
            set { favoriteSearchSeq = value; }
        }
        private System.Int32 numberOfDays;
        public System.Int32 NumberOfDays
        {
            get { return numberOfDays; }
            set { numberOfDays = value; }
        }
        private System.String userID;
        public System.String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private System.String favoriteName;
        public System.String FavoriteName
        {
            get { return favoriteName; }
            set { favoriteName = value; }
        }
        private System.String searchPhrase;
        public System.String SearchPhrase
        {
            get { return searchPhrase; }
            set { searchPhrase = value; }
        }
        private System.String searchQueryDisplay;
        public string SearchQueryDisplay
        {
            get { return searchQueryDisplay; }
            set { searchQueryDisplay = value; }
        }
        private System.String searchForCaseOrDoc;
        public string SearchForCaseOrDoc
        {
            get { return searchForCaseOrDoc; }
            set { searchForCaseOrDoc = value; }
        }
    }
}






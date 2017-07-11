namespace CQM.Entities
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class PrintLabelInfoEntity
    {
        private System.String serviceListContacts;
        public System.String ServiceListContacts
        {
            get { return serviceListContacts; }
            set { serviceListContacts = value; }
        }

        private System.String serviceListMailingList;
        public System.String ServiceListMailingList
        {
            get { return serviceListMailingList; }
            set { serviceListMailingList = value; }
        }

        private System.String activePartyContactList;
        public System.String ActivePartyContactList
        {
            get { return activePartyContactList; }
            set { activePartyContactList = value; }
        }

        private System.String mailingList;
        public System.String MailingList
        {
            get { return mailingList; }
            set { mailingList = value; }
        }

        private System.String contactList;
        public System.String ContactList
        {
            get { return contactList; }
            set { contactList = value; }
        }

        private System.String serviceListMatterList;
        public System.String ServiceListMatterList
        {
            get { return serviceListMatterList; }
            set { serviceListMatterList = value; }
        }

        private System.String activePartyMatterList;
        public System.String ActivePartyMatterList
        {
            get { return activePartyMatterList; }
            set { activePartyMatterList = value; }
        }

        private System.Boolean isNameRequired;
        public System.Boolean IsNameRequired
        {
            get { return isNameRequired; }
            set { isNameRequired = value; }
        }

        private System.Boolean isCompanyRequired;
        public System.Boolean IsCompanyRequired
        {
            get { return isCompanyRequired; }
            set { isCompanyRequired = value; }
        }

        private System.Boolean isAddressRequired;
        public System.Boolean IsAddressRequired
        {
            get { return isAddressRequired; }
            set { isAddressRequired = value; }
        }

        private System.Boolean isRepCompanyRequired;
        public System.Boolean IsRepCompanyRequired
        {
            get { return isRepCompanyRequired; }
            set { isRepCompanyRequired = value; }
        }

        private System.Boolean isEmailRequired;
        public System.Boolean IsEmailRequired
        {
            get { return isEmailRequired; }
            set { isEmailRequired = value; }
        }

        private System.Boolean isPhoneFaxRequired;
        public System.Boolean IsPhoneFaxRequired
        {
            get { return isPhoneFaxRequired; }
            set { isPhoneFaxRequired = value; }
        }

        private System.String securedServiceListContacts;
        public System.String SecuredServiceListContacts
        {
            get { return securedServiceListContacts; }
            set { securedServiceListContacts = value; }
        }

        private System.String securedServiceListMatters;
        public System.String SecuredServiceListMatters
        {
            get { return securedServiceListMatters; }
            set { securedServiceListMatters = value; }
        }
    }
}

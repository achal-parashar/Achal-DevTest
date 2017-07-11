namespace CQM.Entities
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class PrintLabelEmailEntity
    {
        private List<ContactMFEntity> mailingLabels;
        public List<ContactMFEntity> MailingLabels
        {
            get { return mailingLabels; }
            set { mailingLabels = value; }
        }

        private List<ContactMFEntity> emails;
        public List<ContactMFEntity> Emails
        {
            get { return emails; }
            set { emails = value; }
        }        
    }
}




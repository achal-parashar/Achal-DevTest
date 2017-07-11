//---------------------------------------------------------------------
// Author: JAY Prakash  
// Version: 1.0.0
// Date: 9/June/2011
// Description: Template Entity
//
// History:
// Changed By          
// Changed On
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Template.
    /// </summary>
    /// <author>Jay Prakash</author>
    /// <creationDate>2011-09-June</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class TemplateEntity
    {
        private System.String letterfilename;
        public System.String Letter_FileName
        {
            get { return letterfilename; }
            set { letterfilename = value; }
        }
        private System.String envelopfilename;
        public System.String Envelop_FileName
        {
            get { return envelopfilename; }
            set { envelopfilename = value; }
        }
        private System.String mm_full_name;
        public System.String Mm_full_name
        {
            get { return mm_full_name; }
            set { mm_full_name = value; }
        }
        private System.String mm_business_name;
        public System.String Mm_business_name
        {
            get { return mm_business_name; }
            set { mm_business_name = value; }
        }

        private System.String mm_dba_name;
        public System.String Mm_dba_name
        {
            get { return mm_dba_name; }
            set { mm_dba_name = value; }
        }

        private System.String mm_add_1;
        public System.String Mm_add_1
        {
            get { return mm_add_1; }
            set { mm_add_1 = value; }
        }

        private System.String mm_add_2;
        public System.String Mm_add_2
        {
            get { return mm_add_2; }
            set { mm_add_2 = value; }
        }

        private System.String mm_case_id;
        public System.String Mm_case_id
        {
            get { return mm_case_id; }
            set { mm_case_id = value; }
        }
        private System.String mm_greeting_code;
        public System.String Mm_greeting_code
        {
            get { return mm_greeting_code; }
            set { mm_greeting_code = value; }
        }

        private System.String mm_recipient_last_name;
        public System.String Mm_recipient_last_name
        {
            get { return mm_recipient_last_name; }
            set { mm_recipient_last_name = value; }
        }

        private System.String mm_utility_name;
        public System.String Mm_utility_name
        {
            get { return mm_utility_name; }
            set { mm_utility_name = value; }
        }

        private System.String mm_utility_acct_number;
        public System.String Mm_utility_acct_number
        {
            get { return mm_utility_acct_number; }
            set { mm_utility_acct_number = value; }
        }
        private System.String mm_servloc_county;
        public System.String Mm_servloc_county
        {
            get { return mm_servloc_county; }
            set { mm_servloc_county = value; }
        }

        private System.String mm_servloc_address1;
        public System.String Mm_servloc_address1
        {
            get { return mm_servloc_address1; }
            set { mm_servloc_address1 = value; }
        }
        private System.String mm_servloc_address2;
        public System.String Mm_servloc_address2
        {
            get { return mm_servloc_address2; }
            set { mm_servloc_address2 = value; }
        }
        private System.String mm_servloc_address3;
        public System.String Mm_servloc_address3
        {
            get { return mm_servloc_address3; }
            set { mm_servloc_address3 = value; }
        }
        private System.String mm_servloc_city;
        public System.String Mm_servloc_city
        {
            get { return mm_servloc_city; }
            set { mm_servloc_city = value; }
        }
        private System.String mm_affadavit_event_note;
        public System.String Mm_aff_event_note
        {
            get { return mm_affadavit_event_note; }
            set { mm_affadavit_event_note = value; }
        }

        private System.String mm_case_created_date;
        public System.String Mm_case_created_date
        {
            get { return mm_case_created_date; }
            set { mm_case_created_date = value; }
        }
        private System.String mm_customer_name;
        public System.String Mm_customer_name
        {
            get { return mm_customer_name; }
            set { mm_customer_name = value; }
        }

        private System.String mm_staff_name;
        public System.String Mm_staff_name
        {
            get { return mm_staff_name; }
            set { mm_staff_name = value; }
        }
        private System.String mm_staff_email;
        public System.String Mm_staff_email
        {
            get { return mm_staff_email; }
            set { mm_staff_email = value; }
        }

        private System.String mm_appeal_docket_id;
        public System.String Mm_appeal_docket_id
        {
            get { return mm_appeal_docket_id; }
            set { mm_appeal_docket_id = value; }
        }

        private System.String mm_disposition_date;
        public System.String Mm_disposition_date
        {
            get { return mm_disposition_date; }
            set { mm_disposition_date = value; }
        }

        private System.String mm_issue_subcategory;
        public System.String Mm_issue_subcategory
        {
            get { return mm_issue_subcategory; }
            set { mm_issue_subcategory = value; }
        }

        private System.String mm_utility_contact;
        public System.String Mm_utility_contact
        {
            get { return mm_utility_contact; }
            set { mm_utility_contact = value; }
        }

        private System.String mm_wrtd_response_due_date;
        public System.String Mm_wrtd_response_due_date
        {
            get { return mm_wrtd_response_due_date; }
            set { mm_wrtd_response_due_date = value; }
        }
        private System.String mm_telephone_number;
        public System.String Mm_telephone_number
        {
            get { return mm_telephone_number; }
            set { mm_telephone_number = value; }
        }
        private System.String casenumber;
        public System.String CaseNo
        {
            get { return casenumber; }
            set { casenumber = value; }
        }
        private System.Int32 letterseq;
        public System.Int32 Letter_Seq
        {
            get { return letterseq; }
            set { letterseq = value; }
        }
        private System.Int32 lettertitleseq;
        public System.Int32 LETTERTITLE_Seq
        {
            get { return lettertitleseq; }
            set { lettertitleseq = value; }
        }
        private System.String createdby;
        public System.String CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
        private System.String mm_Name_BusinessName_DBA;
        public System.String Mm_Name_BusinessName_DBA
        {
            get { return mm_Name_BusinessName_DBA; }
            set { mm_Name_BusinessName_DBA = value; }
        }
        private System.String mm_FullAddress;
        public System.String Mm_FullAddress
        {
            get { return mm_FullAddress; }
            set { mm_FullAddress = value; }
        }

        //added on 22/2/2012 for fullserviceaddress
        private System.String mm_FullServiceAddress;
        public System.String Mm_FullServiceAddress
        {
            get { return mm_FullServiceAddress; }
            set { mm_FullServiceAddress = value; }
        }

        //added on 23/2/2012 for utility_type
        private System.String mm_utility_type;
        public System.String Mm_utility_type
        {
            get { return mm_utility_type; }
            set { mm_utility_type = value; }
        }

        //added on 23/2/2012
        private System.String mm_current_date;
        public System.String Mm_current_date
        {
            get { return mm_current_date; }
            set { mm_current_date = value; }
        }

    }
}

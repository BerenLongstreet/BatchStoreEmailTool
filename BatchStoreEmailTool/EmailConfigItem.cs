using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace BatchStoreEmailTool
{
    public enum EmailAddressType
    {
        TO_EMAIL_ADDRESS,
        FROM_EMAIL_ADDRESS,
        CC_EMAIL_ADDRESS
    }

    public enum AttachmentType
    {
        SITE_ATTACHMENT,
        GLOBAL_ATACHMENT
    }

    class EmailConfigItem
    {
        private List<string> _ToEmailAddresses = new List<string> { };
        private List<string> _FromEmailAddresses = new List<string> { };
        private List<string> _CCEmailAddresses = new List<string> { };

        private List<string> _SiteAttachmentFilePaths = new List<string> { };
        private List<string> _GlobalAttachmentFilePaths = new List<string> { };

        public ref List<string> ToEmailAddresses { get { return ref _ToEmailAddresses; } }
        public ref List<string> FromEmailAddresses { get { return ref _FromEmailAddresses; } }
        public ref List<string> CCEmailAddresses { get { return ref _CCEmailAddresses; } }

        public ref List<string> GlobalAttachmentFilePaths { get { return ref _GlobalAttachmentFilePaths; } }
        public ref List<string> SiteAttachmentFilePaths { get { return ref _GlobalAttachmentFilePaths; } }

        public string Subject { get; set; }
        public string BodyText { get; set; }

        public void AddEmailAddress(string EmailAddress, EmailAddressType Type)
        {
            switch(Type)
            {
                case EmailAddressType.TO_EMAIL_ADDRESS: _ToEmailAddresses.Add(EmailAddress); break;
                case EmailAddressType.FROM_EMAIL_ADDRESS: _FromEmailAddresses.Add(EmailAddress);  break;
                case EmailAddressType.CC_EMAIL_ADDRESS: _CCEmailAddresses.Add(EmailAddress); break;
                default: break;
            }
        }

        public void AddFileAttachmentPath(string FilePath, AttachmentType Type)
        {
            switch(Type)
            {
                case AttachmentType.SITE_ATTACHMENT: _SiteAttachmentFilePaths.Add(FilePath); break;
                case AttachmentType.GLOBAL_ATACHMENT: _GlobalAttachmentFilePaths.Add(FilePath); break;
                default: break;
            }
        }

        public void ConfigureEmailItem(ref Microsoft.Office.Interop.Outlook.MailItem mailItem)
        {
            mailItem.To = _ToEmailAddresses.Aggregate((m, n) => m + ";" + n);
            mailItem.CC = _CCEmailAddresses.Aggregate((m, n) => m + ";" + n);


            foreach(string attachment in _SiteAttachmentFilePaths.Concat(_GlobalAttachmentFilePaths))
            {
                mailItem.Attachments.Add(attachment);
            }
            
        }
    }


public class OutlookMail
    {
        protected Outlook.Application oApp;
        //protected Outlook._NameSpace oNameSpace;
        //private Outlook.MAPIFolder oSentItemsFolder;
        internal string Mode = "LIVE";

        public OutlookMail(ref Outlook.Application ThisOutlook)
        {
            oApp = ThisOutlook;
            // 
            // Return a reference to the MAPI layer      
            //oApp = new Outlook.Application();
            //oNameSpace = oApp.GetNamespace("MAPI");
            //oNameSpace.Logon();

            //oSentItemsFolder = oNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderSentMail);
        }

        public void SendMail(string Subject, string ToAddress, string CCAddress, string Body, string Attachment, bool RequestReadReceipt)
        {
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            
            oMailItem.Recipients.Add(ToAddress);
            oMailItem.CC = CCAddress;

            oMailItem.BodyFormat = Outlook.OlBodyFormat.olFormatPlain;
            oMailItem.Subject = Subject;
            oMailItem.Body = Body;
            //oMailItem.SaveSentMessageFolder = oSentItemsFolder;
            oMailItem.ReadReceiptRequested = RequestReadReceipt;
            oMailItem.Attachments.Add(Attachment);

            if (oMailItem.Recipients.ResolveAll())
            {
                if (Mode == "LIVE")
                    oMailItem.Send();
                else
                    oMailItem.Save();
            }
            else
            {
                throw new ApplicationException("Problem with recipient " + ToAddress);
            }
        }

        public void SendMail(string Subject, string ToAddress, string CCAddress, string Body, List<string> Attachments, bool RequestReadReceipt, bool HighPriority)
        {
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            
            oMailItem.Recipients.Add(ToAddress);
            oMailItem.CC = CCAddress;

            oMailItem.BodyFormat = Outlook.OlBodyFormat.olFormatPlain;
            oMailItem.Subject = Subject;
            oMailItem.Body = Body;
            //oMailItem.SaveSentMessageFolder = oSentItemsFolder;
            oMailItem.ReadReceiptRequested = RequestReadReceipt;

            if (HighPriority)
            {
                oMailItem.Importance = Outlook.OlImportance.olImportanceHigh;
            }

            if (Attachments.Count > 0)
            {
                string thisAttachment;

                for (int i = 0; i <= Attachments.Count - 1; i++)
                {
                    thisAttachment = Convert.ToString(Attachments[i]);
                    if (thisAttachment != string.Empty)
                        oMailItem.Attachments.Add(thisAttachment);
                }
            }
            
            if (oMailItem.Recipients.ResolveAll())
            {
                if (Mode == "LIVE")
                    oMailItem.Send();
                else
                    oMailItem.Save();
            }
            else
            {
                throw new ApplicationException("Problem with recipient " + ToAddress);
            }
        }

        public void SendTestMail(string TestEmailAddress)
        {
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

            oMailItem.To = TestEmailAddress;
            oMailItem.Subject = "Test";
            oMailItem.Body = "Test";
            //oMailItem.SaveSentMessageFolder = oSentItemsFolder;
            //oMailItem.Attachments.Add(@"C:\test.xml");

            // uncomment this to also save this in your draft      
            // oMailItem.Save(); 

            // adds it to the outbox      
            oMailItem.Send();
            
            oMailItem = null /* TODO Change to default(_) if this is not a reference type */;
        }

        public void Cleanup()
        {            //oSentItemsFolder = null;
            //oNameSpace = null;
            oApp = null;
        }

        ~OutlookMail()
        {
            if(oApp!=null)
            {
                Cleanup();
            }
        }
     }

}

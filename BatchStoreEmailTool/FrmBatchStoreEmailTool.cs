using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using Outlook = Microsoft.Office.Interop.Outlook;
using BatchStoreEmailTool.Properties.DataSources;
using System.IO;


namespace BatchStoreEmailTool
{

    public partial class FrmBatchStoreEmailTool : Form
    {
        private bool bIsTest = false;
        private bool bLoadedState = false;
        private bool bIsMakingSelection = false;
        private bool bSingleFileMode = true;
        private int iFileNameSelectionStart = 0;
        private int iFileNameSelectionLength = 0;
        private int nMaxAttachments = 12;

        private string sTestEmailAddress = "";
        private string OverrideWebServiceAddress = "X";
        //private AddinTraceListener MyLogListener = null;

        private System.Timers.Timer thisRefreshTimer = null;

        private SiteList thisSiteList = null;

        private string thisVariableFileName = String.Empty;

        private FileInfo thisFileInfo = null;

        private List<string> AdditionalAttachments = new List<string>();

        public void SetTestMode()
        {
            if(bIsTest != true)
            {
                bIsTest = true;

                this.Text += " [TEST MODE]";

                this.BtnChangeTestAddress.Visible = bIsTest;

                ShowWelcomeTestModeMessage();
            }
        }

        //private BatchStoreEmailSystem_WS.CommonSoapClient soapclient_CommonWebService = null;

        public FrmBatchStoreEmailTool()
        {
            InitializeComponent();

            //this.MyLogListener = new AddinTraceListener();

            //this.MyLogListener.MessageLogged += (s,e) =>
            //{
            //    if(this.bLoadedState == true)
            //    {
            //        this.lblStatusMessage.Text += e.GetInfo() + Environment.NewLine;
            //    }
            //};

        }


        private void FrmBatchStoreEmailTool_Load(object sender, EventArgs e)
        {
            GetSettings();

            chkUncheckAll.Checked = true;

            lstNumberFormat.SelectedIndex = 0;

            LoadCompanyList();

            bLoadedState = true;

            string thisCompanyID = ((CompanyListItem)lstCompanyList.SelectedItem).CompanyID;

            LoadSiteListForCompany(thisCompanyID);

            //Trace.WriteLine("testing...");
            this.openFileDialog1.InitialDirectory = Globals.ThisAddIn.GetSoftwareSetting("LastAttachmentLocation", "C:\\");

            if(thisRefreshTimer!=null)
            { 
            thisRefreshTimer.Elapsed -= thisRefreshTimer_Elapsed;
            }

            thisRefreshTimer = new System.Timers.Timer();
            thisRefreshTimer.Elapsed += thisRefreshTimer_Elapsed;

            ShowWelcomeTestModeMessage();
        }

        private void GetSettings()
        {
            this.OverrideWebServiceAddress = Globals.ThisAddIn.GetSoftwareSetting("WebServiceAddress","X");
            if (Globals.ThisAddIn.GetSoftwareSetting("Mode", "LIVE") == "TEST")
            {
                SetTestMode();
            }

            this.nMaxAttachments = Int32.Parse(Globals.ThisAddIn.GetSoftwareSetting("MaxAttachments", "12"));
            this.sTestEmailAddress = Globals.ThisAddIn.GetSoftwareSetting("TestEmailAddress", "support@classicburgers.com");

        }

        private void ShowWelcomeTestModeMessage()
        {
            if(this.bLoadedState && this.bIsTest && this.sTestEmailAddress != string.Empty)
            {
                MessageBox.Show(string.Format("Welcome to Test Mode! Any mail produced will currently be sent to \n\n{0}\n\n To set another test email address, use the button at the top right.", this.sTestEmailAddress), this.Text, MessageBoxButtons.OK);
            }
        }

        public void SetStatusMessageLocation(bool Visibility)
        {
            lblStatusMessage.SetBounds(104, 96, 360, 200);
            lblStatusMessage.Visible = Visibility;
            lblStatusMessage.Clear();
            lblStatusMessage.Update();
        }

        public void LoadCompanyList()
        {
            BatchStoreEmailSystem_WS.CommonSoapClient soapclient_CommonWebService = null;

            try
            {
                soapclient_CommonWebService = GetCommonSoapClient();

                DataSet dsCompanyList = soapclient_CommonWebService.GetCompanyList();

                var dsRows = dsCompanyList.Tables[0].AsEnumerable().Select(r => new
                {
                    CompanyID = r.Field<System.Guid>("CompanyID").ToString(),
                    CompanyName = r.Field<string>("CompanyName")
                });

                IEnumerable<CompanyListItem> CompanyList = from item in dsRows.AsEnumerable()
                                                           select new CompanyListItem(item.CompanyName, item.CompanyID);

                lstCompanyList.DataSource = CompanyList.ToList();
                lstCompanyList.DisplayMember = "CompanyName";
                lstCompanyList.ValueMember = "CompanyID";

            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                soapclient_CommonWebService.Close();
                soapclient_CommonWebService = null;
            }

        }

        public void LoadSiteListForCompany(string CompanyID)
        {
            BatchStoreEmailSystem_WS.CommonSoapClient soapclient_CommonWebService = null;

            DataSet dsSiteList = null;

            try
            {
                soapclient_CommonWebService = GetCommonSoapClient();

                dsSiteList = soapclient_CommonWebService.GetSitesForCompany_v2(CompanyID);

                thisSiteList = new SiteList();
                //thisSiteList.Load(dsSiteList.Tables[0].CreateDataReader(), LoadOption.OverwriteChanges, thisSiteList.CompanySites);


                if (thisSiteList.LoadFromUntypedDataset(ref dsSiteList))
                {
                   //var VSiteList = thisSiteList.CompanySites.AsEnumerable().Select(r => new
                   // {
                   //     SiteKey = r.Field<System.Guid>("SiteKey").ToString(),
                   //     SiteID = r.Field<int>("SiteID").ToString().PadLeft(3),
                   //     SiteName = r.Field<string>("SiteName"),
                   //     DistrictName = r.Field<string>("DistrictName")
                   // });

                    lstSiteList.Items.Clear();

                    foreach (SiteList.CompanySitesRow s in thisSiteList.CompanySites)//foreach (var s in VSiteList)
                    {

                        ListViewItem i = new ListViewItem(s.SiteID.ToString().PadLeft(3), 0);
                        i.Checked = true;
                        i.SubItems.Add(s.SiteName);
                        i.SubItems.Add(s.DistrictName);
                        i.SubItems.Add(s.SiteKey);
                    
                        lstSiteList.Items.Add(i);
                    }

                    //VSiteList = null;

                    lstSiteList.Update();

                }
                else
                {
                    //TODO : 1 Display Error message because of SiteList load failure

                }

                dsSiteList.Dispose();
                dsSiteList = null;
               
 
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {

                soapclient_CommonWebService.Close();
                soapclient_CommonWebService = null;

            }

        }

        private BatchStoreEmailSystem_WS.CommonSoapClient GetCommonSoapClient()
        {
            var thisCommonSoapClient = new BatchStoreEmailSystem_WS.CommonSoapClient();

            if(!OverrideWebServiceAddress.Equals("X"))
            {
                thisCommonSoapClient.Endpoint.Address = new System.ServiceModel.EndpointAddress(OverrideWebServiceAddress + "/common.asmx");
            }

            return thisCommonSoapClient;
        }

        private void lstCompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bLoadedState==true)
            {
                ComboBox thisCombo = (ComboBox) sender;

                string thisCompanyID = ((CompanyListItem)thisCombo.SelectedItem).CompanyID;

                LoadSiteListForCompany(thisCompanyID);
            }

        }

        private void BtnBrowse_Click(System.Object sender, System.EventArgs e)
        {
            DialogResult thisResult = this.openFileDialog1.ShowDialog(this);
            if (thisResult == DialogResult.OK)
            {
                this.txtPathAndFileName.Text = this.openFileDialog1.FileName;
                if (File.Exists(this.openFileDialog1.FileName))
                {
                    thisFileInfo = new FileInfo(this.txtPathAndFileName.Text);
                    this.rtbFileNameSelection.Text = thisFileInfo.Name;
                    this.thisVariableFileName = thisFileInfo.Name;

                    MakeSampleResultNames();

                    this.openFileDialog1.InitialDirectory = thisFileInfo.DirectoryName;
                    SetLastUsedAttachmentFolderLocation(thisFileInfo.DirectoryName);
                }
            }
        }


        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lstSiteList.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void chkUncheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if(bLoadedState == true)
            {
                foreach(ListViewItem i in lstSiteList.Items)
                {
                    i.Checked = ((CheckBox)sender).Checked;
                }

                MakeSampleResultNames();
            }
        }

        private void SetLastUsedAttachmentFolderLocation(string Path)
        {
            Globals.ThisAddIn.SetSoftwareSetting("LastAttachmentLocation", Path);

            //MessageBox.Show(Globals.ThisAddIn.GetSoftwareSetting("LastAttachmentLocation", "XXX"));
        }

        private void SendEmailBatch(object sender, EventArgs e)
        {
            try
            {
                SetInterfaceInteractions(false);

                //BatchStoreEmailTool.EmailConfigItem configItem = new EmailConfigItem();
                //Outlook.MailItem mailItem = (Outlook.MailItem) Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);

                if(thisVariableFileName != null && this.lstSiteList.CheckedItems.Count > 0)
                {
                    OutlookMail oMail = new OutlookMail(ref Globals.ThisAddIn.Application);

                    if(bIsTest){oMail.Mode = "TEST";}

                    SiteInfo thisSiteInfo = null;

                    foreach (ListViewItem i in lstSiteList.CheckedItems)
                    {
                        try
                        {
                            string thisSiteKey = i.SubItems[3].Text;
                            string thisToAddress = string.Empty;
                            string thisCCAddress = string.Empty;
                            string thisFormattedSiteNumber = string.Empty;

                            thisSiteInfo = thisSiteList.GetSingleSiteInfo(thisSiteKey);

                            thisFormattedSiteNumber = FormatStoreNum(thisSiteInfo.SiteNumber, lstNumberFormat.SelectedItem.ToString().Length);

                            thisToAddress = thisSiteInfo.EmailAddress;

                            ShowStatusMessage(string.Format("Processing # {0} ({1})...", thisSiteInfo.SiteNumber, thisSiteInfo.EmailAddress));
                            
                            if (bIsTest)
                            {
                                ShowStatusMessage("\tStore email address: " + thisSiteInfo.EmailAddress);
                            }

                            if (this.ChkCopyOperatingPartner.Checked )
                            {
                                thisCCAddress = thisSiteInfo.DistrictEmailAddress;

                                if(bIsTest)
                                {
                                    ShowStatusMessage("\tCC address: " + thisCCAddress);
                                }
                            }

                            Application.DoEvents();

                            if (bIsTest)
                            {
                                thisToAddress = sTestEmailAddress;
                                thisCCAddress = sTestEmailAddress;
                            }

                            List<string> thisAttachmentList = new List<string>();

                            if (bSingleFileMode)
                            {
                                string thisAttachmentName = thisVariableFileName.Replace(((char)234).ToString(), thisFormattedSiteNumber);
                                thisAttachmentName = Path.Combine(thisFileInfo.DirectoryName.ToString(), thisAttachmentName);

                                if (File.Exists(thisAttachmentName))
                                {
                                    thisAttachmentList.Add(thisAttachmentName);
                                }
                                else
                                {
                                    throw new ApplicationException(string.Format("The file '{0}' was not found.", thisAttachmentName));
                                }
                            }
                            else
                            {
                                var FileList = thisFileInfo.Directory.GetFiles(thisFormattedSiteNumber + "-*")
                                                .Union(thisFileInfo.Directory.GetFiles(thisFormattedSiteNumber + "_*"))
                                                .Union(thisFileInfo.Directory.GetFiles(thisFormattedSiteNumber + " *"))
                                                ;
                                var FilePaths = from f in FileList
                                                select f.FullName;

                                thisAttachmentList.AddRange(FilePaths);
                            }

                            bool bHandledEdgeCase = false;
                            string ErrorMessage = string.Empty;

                            //NO FILES FOUND
                            if (!bHandledEdgeCase && !thisAttachmentList.Any())
                            {
                                ErrorMessage = "No files found matching this store number.";
                                bHandledEdgeCase = true;
                            }

                            //TOO MANY FILES FOUND
                            if (!bHandledEdgeCase && !bSingleFileMode && thisAttachmentList.Count > nMaxAttachments)
                            {
                                ErrorMessage = string.Format("Too many files - the max attachment count per store is {0}", nMaxAttachments);
                                bHandledEdgeCase = true;
                            }

                            //SEE IF ANY OF THE ABOVE EDGE CASES WERE TRUE
                            if(!bHandledEdgeCase)
                            {
                                thisAttachmentList.AddRange(this.AdditionalAttachments);

                                try
                                {
                                    oMail.SendMail(this.txtMessageSubject.Text, thisToAddress, thisCCAddress, this.txtEmailBody.Text, thisAttachmentList, this.ChkReadReceipt.Checked, this.ChkHighPriority.Checked);
                                }
                                catch (System.Exception ex)
                                {
                                    throw new ApplicationException("oMail.SendMail exception:" + ex.Message);
                                }
                            }
                            else
                            {
                                throw new ApplicationException(ErrorMessage);
                            }

                        }
                        catch(System.Exception Ex)
                        {
                            if(MessageBox.Show("An error occurred while sending mail to store " + thisSiteInfo.SiteNumber + ". " + Environment.NewLine + Environment.NewLine +

                                                    "Would you like to continue to process remaining stores?\n\n" +

                                                    "Error Message: " + Ex.Message,

                                                    "Error sending email",

                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.No)
                            {
                                throw new ApplicationException(string.Format("Processing of the email batch was halted at #{0}. The details of the error are as follows: {1}", thisSiteInfo.SiteNumber,Ex.Message));
                            }
                            else
                            {
                                throw new ApplicationException(string.Format("Skipped processing the email batch for #{0} due to an error. The details of the error are as follows: {1}", thisSiteInfo.SiteNumber, Ex.Message));
                            }
                        }
                    } //NEXT CHECKED SITE
                }
            }
            catch(System.ApplicationException AppEx)
            {
                ShowStatusMessage(AppEx.Message);
                Application.DoEvents();
            }
            catch(System.Exception Ex)
            {
                ShowStatusMessage("We experienced a problem while sending the email batch: " + Ex.Message);
                Application.DoEvents();
            }
            finally
            {
                SetInterfaceInteractions(true);
                GC.Collect();
                Application.DoEvents();
            }
        }

        private void ShowStatusMessage(string StatusMessage)
        {
            if (bLoadedState == true)
            {

                lblStatusMessage.Text += StatusMessage + Environment.NewLine;
                lblStatusMessage.SelectionStart = lblStatusMessage.Text.Length;

                lblStatusMessage.ScrollToCaret();

                if (lblStatusMessage.Visible == true)
                {
                    timer1.Stop();
                    timer1.Start();
                }
                else
                {
                    lblStatusMessage.Show();
                    timer1.Start();
                }
            }
   
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            //this.MyLogListener.Dispose();
            //this.MyLogListener = null;
     
            base.OnFormClosed(e);
        }

        private void FrmBatchStoreEmailTool_Shown(object sender, EventArgs e)
        {
            SetStatusMessageLocation(false);
        }

        private void thisRefreshTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                // Do stuff on ANY control on the form.
                MakeSampleResultNames();
            });
            
            thisRefreshTimer.Stop();
        }

        private void lstSiteList_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if(bLoadedState && thisRefreshTimer!=null)
            {
                thisRefreshTimer.Interval = 500;
                thisRefreshTimer.Start();
            }
        }

        private void lstNumberFormat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            MakeSampleResultNames();
        }

        private void rdoOneFilePerStore_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (this.bSingleFileMode & this.rdoOneFilePerStore.Checked)
            {
            }
            else if (this.bSingleFileMode & !this.rdoOneFilePerStore.Checked)
                // Changing from single file mode to multiple file mode
                // The store number selection field must be cleared then only allowed 
                // to be at the front of the file name.
                rtbFileNameSelection.Select(0, 0);
            else if (!this.bSingleFileMode & this.rdoOneFilePerStore.Checked)
                // Changing from multiple file mode to single mode
                // The store number selection must be cleared
                rtbFileNameSelection.Select(0, 0);
            else
            {
            }

            this.bSingleFileMode = this.rdoOneFilePerStore.Checked;
        }

        private void rtbFileNameSelection_MouseEnter(object sender, EventArgs e)
        {
            this.bIsMakingSelection = true;
        }

        private void rtbFileNameSelection_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.bIsMakingSelection = true;
        }

        private void rtbFileNameSelection_SelectionChanged(object sender, System.EventArgs e)
        {
            if (!this.bIsMakingSelection)
            {
                this.iFileNameSelectionStart = this.rtbFileNameSelection.SelectionStart;
                this.iFileNameSelectionLength = this.rtbFileNameSelection.SelectionLength;

                if (iFileNameSelectionLength > 0)
                {
                    if (!this.bSingleFileMode && iFileNameSelectionStart > 0)
                    {
                        MessageBox.Show("In multiple file mode the store number must be at the front of the file name.");
                        rtbFileNameSelection.Select(0, 0);
                        return;
                    }

                    thisVariableFileName = thisFileInfo.Name.Substring(0, this.iFileNameSelectionStart);
                    thisVariableFileName += (char)234;
                    thisVariableFileName += thisFileInfo.Name.Substring(this.iFileNameSelectionStart + iFileNameSelectionLength);
                }
                else
                    thisVariableFileName = thisFileInfo.Name;

                MakeSampleResultNames();
            }
        }


        private void rtbFileNameSelection_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.bIsMakingSelection = false;

            this.rtbFileNameSelection_SelectionChanged(null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
        }

        private void lstSiteList_MouseClick(object sender, MouseEventArgs e)
        {
            if (bLoadedState == true)
            {
                switch(e.Button)
                {
                    case MouseButtons.Right: {
                            string DistrictName = ((ListView)sender).FocusedItem.SubItems[2].Text;

                            string FilterMessage = String.Format("Check all stores for {0}?", DistrictName);

                            if (MessageBox.Show(FilterMessage, this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                foreach (ListViewItem i in lstSiteList.Items)
                                {
                                    if(i.SubItems[2].Text == DistrictName)
                                    {
                                        i.Checked = true;
                                    }
                                }
                            }
                        };
                        break;
                    case MouseButtons.Middle: {

                        }
                        break;
                    default: break;
                }
            }
        }

        private void MakeSampleResultNames(int ExemptIndex = default(int))
        {
            if (bLoadedState && (thisVariableFileName != String.Empty) && this.lstSiteList.CheckedItems.Count > 0 && this.lstNumberFormat.SelectedItem != null)
            {
                string thisResultFileNameSampleString = string.Empty;
                this.txtResultFileNameSample.Text = string.Empty;

                int iCount = 0;

                if (this.lstSiteList.CheckedItems.Count < 3)
                    iCount = lstSiteList.CheckedItems.Count;
                else
                    iCount = 3;

                int iListCount = 0;
                int iIndex = 0;

                while (iListCount < iCount)
                {
                    if ((ExemptIndex != default(int)) && iIndex == ExemptIndex)
                    {
                    }
                    else
                    {
                        string thisSiteNum = this.lstSiteList.Items[iIndex].SubItems[0].Text.Trim();

                        if (this.lstSiteList.Items[iIndex].Checked)
                        {
                            if (this.bSingleFileMode)
                            {
                                thisResultFileNameSampleString += ", " + thisVariableFileName.Replace(new String((char)234,1), FormatStoreNum(thisSiteNum, lstNumberFormat.SelectedItem.ToString().Length));
                                iListCount += 1;
                            }
                            else
                            {

                                string thisFormattedSiteNumber = FormatStoreNum(thisSiteNum, lstNumberFormat.SelectedItem.ToString().Length);

                                {
                                    var FileList = thisFileInfo.Directory.GetFiles(thisFormattedSiteNumber + "-*")
                                                .Union(thisFileInfo.Directory.GetFiles(thisFormattedSiteNumber + "_*"))
                                                .Union(thisFileInfo.Directory.GetFiles(thisFormattedSiteNumber + " *"))
                                                ;
                                    var FilePaths = from f in FileList
                                                    select f.FullName;

                                    //FileInfo[] thisResultFilesList = dirMultipleFileDirectory.GetFiles(thisFormattedSiteNumber + "*");

                                    if (FilePaths.Any())
                                    {
                                        if (FilePaths.Count() > this.nMaxAttachments)
                                        {
                                            MessageBox.Show("Be aware that a maximum of " + this.nMaxAttachments.ToString("0") + " attachments per recipient are allowed. If you must exceed this number, please contact technical support");
                                        }
                                        else
                                        {
                                            thisResultFileNameSampleString = String.Join(",", FilePaths.ToArray().Take(this.nMaxAttachments));
                                        }

                                        thisResultFileNameSampleString += Environment.NewLine;
                                        thisResultFileNameSampleString = thisResultFileNameSampleString.Replace(Environment.NewLine + ", ", Environment.NewLine);
                                    }
                                }
                                iListCount += 1;
                            }
                        }
                    }
                    iIndex += 1;
                }
                try
                {
                    txtResultFileNameSample.Text = thisResultFileNameSampleString.Substring(2);
                }
                catch
                {
                    txtResultFileNameSample.Text = thisResultFileNameSampleString;
                }
            }
        }

        private string FormatStoreNum(string thisStoreNum, int Length)
        {
            if (Length > thisStoreNum.Length)
                return new String('0', Length - thisStoreNum.Length) + thisStoreNum;
            else
                return thisStoreNum;
        }

        private void Timer1_Tick(System.Object sender, System.EventArgs e)
        {
            this.lblStatusMessage.Hide();
            // Me.lblStatusMessage.Text = String.Empty
            this.timer1.Stop();
        }

        private void SetInterfaceInteractions(bool CanInteract)
        {
            this.btnSendEmailBatch.Enabled = CanInteract;
            this.btnBrowse.Enabled = CanInteract;
            this.ChkReadReceipt.Enabled = CanInteract;
            this.ChkCopyOperatingPartner.Enabled = CanInteract;
            this.chkUncheckAll.Enabled = CanInteract;
            this.lstCompanyList.Enabled = CanInteract;
            this.lstSiteList.Enabled = CanInteract;
            this.txtPathAndFileName.Enabled = CanInteract;
            this.txtResultFileNameSample.Enabled = CanInteract;
            this.rtbFileNameSelection.Enabled = CanInteract;
            this.txtEmailBody.Enabled = CanInteract;
            this.txtMessageSubject.Enabled = CanInteract;
        }

        private void LblStatusMessage_DoubleClick(object sender, EventArgs e)
        {
            lblStatusMessage.Hide();
        }

        private void BtnShowHideStatusMessage_Click(object sender, EventArgs e)
        {
            lblStatusMessage.Visible = !lblStatusMessage.Visible;
        }

        private void BtnBrowseAdditional_Click(object sender, EventArgs e)
        {
            DialogResult thisResult = this.openFileDialog1.ShowDialog(this);
            if (thisResult == DialogResult.OK)
            {
                string thisAdditionalAttachmentPath = this.openFileDialog1.FileName;

                if (File.Exists(thisAdditionalAttachmentPath))
                {
                    this.AdditionalAttachments.Add(thisAdditionalAttachmentPath);
                    UpdateAdditionalAttachmentsCount();
                }
            }
        }

        private void BtnClearAdditional_Click(object sender, EventArgs e)
        {
            this.AdditionalAttachments.Clear();
            UpdateAdditionalAttachmentsCount();
        }

        private void UpdateAdditionalAttachmentsCount()
        {
            int AttachmentCount = this.AdditionalAttachments.Count();

            if (AttachmentCount == 0)
            {
                this.LblAddedAttachmentCount.Text = this.LblAddedAttachmentCount.Tag.ToString();
            }
            else
            {
                this.LblAddedAttachmentCount.Text = string.Format("{0} attachments added", this.AdditionalAttachments.Count());
            }

            Application.DoEvents();
        }

        private void BtnChangeTestAddress_Click(object sender, EventArgs e)
        {
            string sNewTestEmailAddress = string.Empty;

            Outlook.SelectNamesDialog oDialog = Globals.ThisAddIn.Application.Session.GetSelectNamesDialog();
            oDialog.InitialAddressList = Globals.ThisAddIn.Application.Session.GetGlobalAddressList();
            oDialog.AllowMultipleSelection = false;
            oDialog.Display();

            if(oDialog.Recipients.Count > 0)
            {
                Outlook.ExchangeUser exchangeUser = null;

                foreach (Outlook.Recipient recip in oDialog.Recipients)
                {
                    exchangeUser = null;
                    exchangeUser = recip.AddressEntry.GetExchangeUser();

                    if(exchangeUser!=null)
                    {
                        sNewTestEmailAddress += exchangeUser.PrimarySmtpAddress;
                    }
                    else
                    {
                        sNewTestEmailAddress = oDialog.Recipients[1].Address;
                    }

                    sNewTestEmailAddress += ';';
                }

                oDialog = null;
                exchangeUser = null;

                this.sTestEmailAddress = sNewTestEmailAddress;

                //COMMENT TEST FOR GITHUB
                //COMMENT TEST FOR LIVE SHARE!!! 🎯

                MessageBox.Show(string.Format("The test mode email address has been changed to \n\n{0}\n\nTo set another test email address, use the button at the top right.", this.sTestEmailAddress), this.Text, MessageBoxButtons.OK);

            }

        }
    }
}

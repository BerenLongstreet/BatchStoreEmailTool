namespace BatchStoreEmailTool
{
    partial class FrmBatchStoreEmailTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatchStoreEmailTool));
            this.lstCompanyList = new System.Windows.Forms.ComboBox();
            this.lstSiteList = new System.Windows.Forms.ListView();
            this.colSiteNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSiteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDistrict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSiteID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSendEmailBatch = new System.Windows.Forms.Button();
            this.chkUncheckAll = new System.Windows.Forms.CheckBox();
            this.lblStatusMessage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ChkReadReceipt = new System.Windows.Forms.CheckBox();
            this.ChkCopyOperatingPartner = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoManyFilesPerStore = new System.Windows.Forms.RadioButton();
            this.rdoOneFilePerStore = new System.Windows.Forms.RadioButton();
            this.txtPathAndFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.rtbFileNameSelection = new System.Windows.Forms.RichTextBox();
            this.lstNumberFormat = new System.Windows.Forms.ComboBox();
            this.txtResultFileNameSample = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtMessageSubject = new System.Windows.Forms.TextBox();
            this.txtEmailBody = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnShowHideStatusMessage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClearAdditional = new System.Windows.Forms.Button();
            this.BtnBrowseAdditional = new System.Windows.Forms.Button();
            this.LblAddedAttachmentCount = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ChkHighPriority = new System.Windows.Forms.CheckBox();
            this.BtnChangeTestAddress = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCompanyList
            // 
            this.lstCompanyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCompanyList.FormattingEnabled = true;
            this.lstCompanyList.Location = new System.Drawing.Point(136, 6);
            this.lstCompanyList.Name = "lstCompanyList";
            this.lstCompanyList.Size = new System.Drawing.Size(203, 21);
            this.lstCompanyList.TabIndex = 0;
            this.lstCompanyList.Text = "Please Choose a Company:";
            this.lstCompanyList.SelectedIndexChanged += new System.EventHandler(this.lstCompanyList_SelectedIndexChanged);
            // 
            // lstSiteList
            // 
            this.lstSiteList.AllowColumnReorder = true;
            this.lstSiteList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSiteList.CheckBoxes = true;
            this.lstSiteList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSiteNum,
            this.colSiteName,
            this.colDistrict,
            this.colSiteID});
            this.lstSiteList.FullRowSelect = true;
            this.lstSiteList.GridLines = true;
            this.lstSiteList.Location = new System.Drawing.Point(31, 240);
            this.lstSiteList.Name = "lstSiteList";
            this.lstSiteList.Size = new System.Drawing.Size(521, 149);
            this.lstSiteList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstSiteList.TabIndex = 7;
            this.lstSiteList.UseCompatibleStateImageBehavior = false;
            this.lstSiteList.View = System.Windows.Forms.View.Details;
            this.lstSiteList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            this.lstSiteList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSiteList_ItemCheck);
            this.lstSiteList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSiteList_MouseClick);
            // 
            // colSiteNum
            // 
            this.colSiteNum.Text = "Store #";
            // 
            // colSiteName
            // 
            this.colSiteName.Text = "Store Name";
            this.colSiteName.Width = 250;
            // 
            // colDistrict
            // 
            this.colDistrict.Text = "Oper. Partner";
            this.colDistrict.Width = 190;
            // 
            // colSiteID
            // 
            this.colSiteID.Text = "SiteKey";
            this.colSiteID.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "1.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "2.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "4.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "3.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "5.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "6.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "7.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "8.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "9.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "10.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSendEmailBatch
            // 
            this.btnSendEmailBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendEmailBatch.BackColor = System.Drawing.Color.Red;
            this.btnSendEmailBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmailBatch.ForeColor = System.Drawing.Color.White;
            this.btnSendEmailBatch.Location = new System.Drawing.Point(136, 576);
            this.btnSendEmailBatch.Margin = new System.Windows.Forms.Padding(15, 3, 15, 15);
            this.btnSendEmailBatch.Name = "btnSendEmailBatch";
            this.btnSendEmailBatch.Size = new System.Drawing.Size(288, 31);
            this.btnSendEmailBatch.TabIndex = 19;
            this.btnSendEmailBatch.Text = "Send Email Batch";
            this.btnSendEmailBatch.UseVisualStyleBackColor = false;
            this.btnSendEmailBatch.Click += new System.EventHandler(this.SendEmailBatch);
            // 
            // chkUncheckAll
            // 
            this.chkUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUncheckAll.AutoSize = true;
            this.chkUncheckAll.Location = new System.Drawing.Point(398, 224);
            this.chkUncheckAll.Name = "chkUncheckAll";
            this.chkUncheckAll.Size = new System.Drawing.Size(154, 17);
            this.chkUncheckAll.TabIndex = 20;
            this.chkUncheckAll.Text = "Check / uncheck all stores";
            this.chkUncheckAll.UseVisualStyleBackColor = true;
            this.chkUncheckAll.CheckedChanged += new System.EventHandler(this.chkUncheckAll_CheckedChanged);
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.AcceptsReturn = true;
            this.lblStatusMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusMessage.Location = new System.Drawing.Point(387, 6);
            this.lblStatusMessage.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblStatusMessage.Multiline = true;
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.ReadOnly = true;
            this.lblStatusMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblStatusMessage.Size = new System.Drawing.Size(164, 59);
            this.lblStatusMessage.TabIndex = 21;
            this.lblStatusMessage.TabStop = false;
            this.lblStatusMessage.Text = "Status Messages Here:";
            this.lblStatusMessage.DoubleClick += new System.EventHandler(this.LblStatusMessage_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Choose a Company:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Select the Mode:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Browse for Location and Sample File Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(407, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Highlight the portion of the file name that needs to be replaced with the store n" +
    "umber:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(271, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Specify the format for the store numbers in the file name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(208, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Make sure that the file names look correct:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(284, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Uncheck any stores that will not be included in this mailing:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 402);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Enter the Subject for the email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 428);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Type or Paste the body of the email:";
            // 
            // ChkReadReceipt
            // 
            this.ChkReadReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkReadReceipt.AutoSize = true;
            this.ChkReadReceipt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkReadReceipt.Location = new System.Drawing.Point(58, 531);
            this.ChkReadReceipt.Name = "ChkReadReceipt";
            this.ChkReadReceipt.Size = new System.Drawing.Size(241, 17);
            this.ChkReadReceipt.TabIndex = 25;
            this.ChkReadReceipt.Text = "Create a \'Read Receipt\' for the email?     Yes:";
            this.ChkReadReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkReadReceipt.UseVisualStyleBackColor = true;
            // 
            // ChkCopyOperatingPartner
            // 
            this.ChkCopyOperatingPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkCopyOperatingPartner.AutoSize = true;
            this.ChkCopyOperatingPartner.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkCopyOperatingPartner.Location = new System.Drawing.Point(59, 550);
            this.ChkCopyOperatingPartner.Name = "ChkCopyOperatingPartner";
            this.ChkCopyOperatingPartner.Size = new System.Drawing.Size(240, 17);
            this.ChkCopyOperatingPartner.TabIndex = 25;
            this.ChkCopyOperatingPartner.Text = "CC the Operating Partner?                       Yes:";
            this.ChkCopyOperatingPartner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkCopyOperatingPartner.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoManyFilesPerStore);
            this.groupBox1.Controls.Add(this.rdoOneFilePerStore);
            this.groupBox1.Location = new System.Drawing.Point(136, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 39);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // rdoManyFilesPerStore
            // 
            this.rdoManyFilesPerStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoManyFilesPerStore.AutoSize = true;
            this.rdoManyFilesPerStore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoManyFilesPerStore.Location = new System.Drawing.Point(228, 13);
            this.rdoManyFilesPerStore.Name = "rdoManyFilesPerStore";
            this.rdoManyFilesPerStore.Size = new System.Drawing.Size(122, 18);
            this.rdoManyFilesPerStore.TabIndex = 2;
            this.rdoManyFilesPerStore.Text = "Many files per store";
            this.rdoManyFilesPerStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoManyFilesPerStore.UseVisualStyleBackColor = true;
            // 
            // rdoOneFilePerStore
            // 
            this.rdoOneFilePerStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOneFilePerStore.AutoSize = true;
            this.rdoOneFilePerStore.Checked = true;
            this.rdoOneFilePerStore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoOneFilePerStore.Location = new System.Drawing.Point(56, 13);
            this.rdoOneFilePerStore.Name = "rdoOneFilePerStore";
            this.rdoOneFilePerStore.Size = new System.Drawing.Size(111, 18);
            this.rdoOneFilePerStore.TabIndex = 1;
            this.rdoOneFilePerStore.TabStop = true;
            this.rdoOneFilePerStore.Text = "One file per store";
            this.rdoOneFilePerStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoOneFilePerStore.UseVisualStyleBackColor = true;
            this.rdoOneFilePerStore.CheckedChanged += new System.EventHandler(this.rdoOneFilePerStore_CheckedChanged);
            // 
            // txtPathAndFileName
            // 
            this.txtPathAndFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathAndFileName.Location = new System.Drawing.Point(32, 89);
            this.txtPathAndFileName.Name = "txtPathAndFileName";
            this.txtPathAndFileName.ReadOnly = true;
            this.txtPathAndFileName.Size = new System.Drawing.Size(432, 20);
            this.txtPathAndFileName.TabIndex = 27;
            this.txtPathAndFileName.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(470, 88);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 22);
            this.btnBrowse.TabIndex = 28;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // rtbFileNameSelection
            // 
            this.rtbFileNameSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileNameSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFileNameSelection.DetectUrls = false;
            this.rtbFileNameSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFileNameSelection.Location = new System.Drawing.Point(31, 123);
            this.rtbFileNameSelection.Name = "rtbFileNameSelection";
            this.rtbFileNameSelection.Size = new System.Drawing.Size(521, 25);
            this.rtbFileNameSelection.TabIndex = 29;
            this.rtbFileNameSelection.Text = "";
            this.rtbFileNameSelection.SelectionChanged += new System.EventHandler(this.rtbFileNameSelection_SelectionChanged);
            this.rtbFileNameSelection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbFileNameSelection_MouseDown);
            this.rtbFileNameSelection.MouseEnter += new System.EventHandler(this.rtbFileNameSelection_MouseEnter);
            this.rtbFileNameSelection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rtbFileNameSelection_MouseUp);
            // 
            // lstNumberFormat
            // 
            this.lstNumberFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNumberFormat.FormattingEnabled = true;
            this.lstNumberFormat.Items.AddRange(new object[] {
            "1",
            "01",
            "001",
            "0001",
            "00001"});
            this.lstNumberFormat.Location = new System.Drawing.Point(314, 149);
            this.lstNumberFormat.Name = "lstNumberFormat";
            this.lstNumberFormat.Size = new System.Drawing.Size(238, 21);
            this.lstNumberFormat.TabIndex = 30;
            this.lstNumberFormat.SelectedIndexChanged += new System.EventHandler(this.lstNumberFormat_SelectedIndexChanged);
            // 
            // txtResultFileNameSample
            // 
            this.txtResultFileNameSample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultFileNameSample.Location = new System.Drawing.Point(31, 184);
            this.txtResultFileNameSample.Multiline = true;
            this.txtResultFileNameSample.Name = "txtResultFileNameSample";
            this.txtResultFileNameSample.ReadOnly = true;
            this.txtResultFileNameSample.Size = new System.Drawing.Size(521, 40);
            this.txtResultFileNameSample.TabIndex = 31;
            this.txtResultFileNameSample.TabStop = false;
            // 
            // txtMessageSubject
            // 
            this.txtMessageSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageSubject.Location = new System.Drawing.Point(184, 399);
            this.txtMessageSubject.Name = "txtMessageSubject";
            this.txtMessageSubject.Size = new System.Drawing.Size(368, 20);
            this.txtMessageSubject.TabIndex = 32;
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailBody.Location = new System.Drawing.Point(31, 444);
            this.txtEmailBody.Multiline = true;
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(521, 50);
            this.txtEmailBody.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 501);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Options:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnShowHideStatusMessage
            // 
            this.BtnShowHideStatusMessage.BackColor = System.Drawing.SystemColors.Control;
            this.BtnShowHideStatusMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnShowHideStatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowHideStatusMessage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnShowHideStatusMessage.Location = new System.Drawing.Point(521, 576);
            this.BtnShowHideStatusMessage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnShowHideStatusMessage.Name = "BtnShowHideStatusMessage";
            this.BtnShowHideStatusMessage.Size = new System.Drawing.Size(31, 31);
            this.BtnShowHideStatusMessage.TabIndex = 39;
            this.BtnShowHideStatusMessage.Text = "«";
            this.BtnShowHideStatusMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnShowHideStatusMessage.UseVisualStyleBackColor = false;
            this.BtnShowHideStatusMessage.Click += new System.EventHandler(this.BtnShowHideStatusMessage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClearAdditional);
            this.groupBox2.Controls.Add(this.BtnBrowseAdditional);
            this.groupBox2.Controls.Add(this.LblAddedAttachmentCount);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Location = new System.Drawing.Point(314, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 70);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Common File Attachments:";
            // 
            // BtnClearAdditional
            // 
            this.BtnClearAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearAdditional.Location = new System.Drawing.Point(145, 42);
            this.BtnClearAdditional.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearAdditional.Name = "BtnClearAdditional";
            this.BtnClearAdditional.Size = new System.Drawing.Size(82, 22);
            this.BtnClearAdditional.TabIndex = 43;
            this.BtnClearAdditional.Text = "Clear";
            this.BtnClearAdditional.UseVisualStyleBackColor = true;
            this.BtnClearAdditional.Click += new System.EventHandler(this.BtnClearAdditional_Click);
            // 
            // BtnBrowseAdditional
            // 
            this.BtnBrowseAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseAdditional.Location = new System.Drawing.Point(145, 16);
            this.BtnBrowseAdditional.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBrowseAdditional.Name = "BtnBrowseAdditional";
            this.BtnBrowseAdditional.Size = new System.Drawing.Size(82, 22);
            this.BtnBrowseAdditional.TabIndex = 42;
            this.BtnBrowseAdditional.Text = "Add...";
            this.BtnBrowseAdditional.UseVisualStyleBackColor = true;
            this.BtnBrowseAdditional.Click += new System.EventHandler(this.BtnBrowseAdditional_Click);
            // 
            // LblAddedAttachmentCount
            // 
            this.LblAddedAttachmentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddedAttachmentCount.AutoSize = true;
            this.LblAddedAttachmentCount.Location = new System.Drawing.Point(20, 47);
            this.LblAddedAttachmentCount.Name = "LblAddedAttachmentCount";
            this.LblAddedAttachmentCount.Size = new System.Drawing.Size(113, 13);
            this.LblAddedAttachmentCount.TabIndex = 41;
            this.LblAddedAttachmentCount.Tag = "no added attachments";
            this.LblAddedAttachmentCount.Text = "no added attachments";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(127, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "(same attachments for all)";
            // 
            // ChkHighPriority
            // 
            this.ChkHighPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkHighPriority.AutoSize = true;
            this.ChkHighPriority.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkHighPriority.Location = new System.Drawing.Point(60, 512);
            this.ChkHighPriority.Name = "ChkHighPriority";
            this.ChkHighPriority.Size = new System.Drawing.Size(239, 17);
            this.ChkHighPriority.TabIndex = 42;
            this.ChkHighPriority.Text = "Flag as High Priority?                               Yes:";
            this.ChkHighPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkHighPriority.UseVisualStyleBackColor = true;
            // 
            // BtnChangeTestAddress
            // 
            this.BtnChangeTestAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangeTestAddress.BackColor = System.Drawing.Color.Red;
            this.BtnChangeTestAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeTestAddress.ForeColor = System.Drawing.Color.White;
            this.BtnChangeTestAddress.Location = new System.Drawing.Point(383, 6);
            this.BtnChangeTestAddress.Margin = new System.Windows.Forms.Padding(15, 3, 15, 15);
            this.BtnChangeTestAddress.Name = "BtnChangeTestAddress";
            this.BtnChangeTestAddress.Size = new System.Drawing.Size(169, 31);
            this.BtnChangeTestAddress.TabIndex = 43;
            this.BtnChangeTestAddress.Text = "Change Test Address";
            this.BtnChangeTestAddress.UseVisualStyleBackColor = false;
            this.BtnChangeTestAddress.Visible = false;
            this.BtnChangeTestAddress.Click += new System.EventHandler(this.BtnChangeTestAddress_Click);
            // 
            // FrmBatchStoreEmailTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 616);
            this.Controls.Add(this.ChkHighPriority);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnShowHideStatusMessage);
            this.Controls.Add(this.lblStatusMessage);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtEmailBody);
            this.Controls.Add(this.txtMessageSubject);
            this.Controls.Add(this.txtResultFileNameSample);
            this.Controls.Add(this.lstNumberFormat);
            this.Controls.Add(this.rtbFileNameSelection);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPathAndFileName);
            this.Controls.Add(this.ChkCopyOperatingPartner);
            this.Controls.Add(this.ChkReadReceipt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSendEmailBatch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiteList);
            this.Controls.Add(this.lstCompanyList);
            this.Controls.Add(this.chkUncheckAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BtnChangeTestAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBatchStoreEmailTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Batch Store Email Tool";
            this.Load += new System.EventHandler(this.FrmBatchStoreEmailTool_Load);
            this.Shown += new System.EventHandler(this.FrmBatchStoreEmailTool_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstCompanyList;
        private System.Windows.Forms.ListView lstSiteList;
        protected System.Windows.Forms.ColumnHeader colSiteNum;
        protected System.Windows.Forms.ColumnHeader colSiteName;
        protected System.Windows.Forms.ColumnHeader colDistrict;
        protected System.Windows.Forms.ColumnHeader colSiteID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSendEmailBatch;
        private System.Windows.Forms.CheckBox chkUncheckAll;
        private System.Windows.Forms.TextBox lblStatusMessage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox ChkReadReceipt;
        private System.Windows.Forms.CheckBox ChkCopyOperatingPartner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoManyFilesPerStore;
        private System.Windows.Forms.RadioButton rdoOneFilePerStore;
        private System.Windows.Forms.TextBox txtPathAndFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox rtbFileNameSelection;
        private System.Windows.Forms.ComboBox lstNumberFormat;
        private System.Windows.Forms.TextBox txtResultFileNameSample;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtMessageSubject;
        private System.Windows.Forms.TextBox txtEmailBody;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnShowHideStatusMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClearAdditional;
        private System.Windows.Forms.Button BtnBrowseAdditional;
        private System.Windows.Forms.Label LblAddedAttachmentCount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox ChkHighPriority;
        private System.Windows.Forms.Button BtnChangeTestAddress;
    }
}
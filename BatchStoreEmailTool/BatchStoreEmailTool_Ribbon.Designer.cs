namespace BatchStoreEmailTool
{
    partial class BatchStoreEmailTool_Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public BatchStoreEmailTool_Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.CRGGroup = this.Factory.CreateRibbonGroup();
            this.btnOpenBatchStoreEmailForm = this.Factory.CreateRibbonButton();
            this.btnLaunchTestMode = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.CRGGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.CRGGroup);
            this.tab1.Label = "CRG Custom";
            this.tab1.Name = "tab1";
            // 
            // CRGGroup
            // 
            this.CRGGroup.Items.Add(this.btnOpenBatchStoreEmailForm);
            this.CRGGroup.Items.Add(this.btnLaunchTestMode);
            this.CRGGroup.Label = "CRG Custom Tools";
            this.CRGGroup.Name = "CRGGroup";
            // 
            // btnOpenBatchStoreEmailForm
            // 
            this.btnOpenBatchStoreEmailForm.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnOpenBatchStoreEmailForm.Label = "Launch Batch Store Email Tool";
            this.btnOpenBatchStoreEmailForm.Name = "btnOpenBatchStoreEmailForm";
            this.btnOpenBatchStoreEmailForm.OfficeImageId = "AttachFile";
            this.btnOpenBatchStoreEmailForm.ShowImage = true;
            this.btnOpenBatchStoreEmailForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenBatchStoreEmailForm);
            // 
            // btnLaunchTestMode
            // 
            this.btnLaunchTestMode.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLaunchTestMode.Label = "Launch Batch Tool [TEST MODE]";
            this.btnLaunchTestMode.Name = "btnLaunchTestMode";
            this.btnLaunchTestMode.OfficeImageId = "AttachFile";
            this.btnLaunchTestMode.ShowImage = true;
            this.btnLaunchTestMode.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LaunchTestMode);
            // 
            // BatchStoreEmailTool_Ribbon
            // 
            this.Name = "BatchStoreEmailTool_Ribbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.BatchStoreEmailTool_Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.CRGGroup.ResumeLayout(false);
            this.CRGGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup CRGGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOpenBatchStoreEmailForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLaunchTestMode;
    }

    partial class ThisRibbonCollection
    {
        internal BatchStoreEmailTool_Ribbon BatchStoreEmailTool_Ribbon
        {
            get { return this.GetRibbon<BatchStoreEmailTool_Ribbon>(); }
        }
    }
}

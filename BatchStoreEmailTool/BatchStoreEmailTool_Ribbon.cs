using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace BatchStoreEmailTool
{
    public partial class BatchStoreEmailTool_Ribbon
    {
        private FrmBatchStoreEmailTool thisBatchForm = null;

        private void BatchStoreEmailTool_Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            Application.ThreadException += Application_ThreadException;            
        }

        private void OpenBatchStoreEmailForm(object sender, RibbonControlEventArgs e)
        {
            LaunchBatchStoreEmailTool(false);
        }

        private void LaunchTestMode(object sender, RibbonControlEventArgs e)
        {
            LaunchBatchStoreEmailTool(true);
        }

        //private void btnOpenBatchStoreEmailForm_Click(object sender, RibbonControlEventArgs e)
        //{
        //    LaunchBatchStoreEmailTool(false);
        //}

        //private void btnLaunchTestMode_Click(object sender, RibbonControlEventArgs e)
        //{
        //    LaunchBatchStoreEmailTool(true);
        //}

        private void LaunchBatchStoreEmailTool(bool TestMode)
        {

            if (thisBatchForm == null)
            {


                thisBatchForm = new FrmBatchStoreEmailTool();
                thisBatchForm.FormClosed += ThisBatchForm_FormClosed;


                if (TestMode == true)
                {
                    thisBatchForm.SetTestMode();
                }

                thisBatchForm.Show();

            }
            else
            {
                if (TestMode == true)
                {
                    thisBatchForm.SetTestMode();
                }

                thisBatchForm.Activate();
            }
        }

        private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(string.Format("The {0} has thrown the following exception: {1}", this.Name, e.Exception.Message), this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ThisBatchForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            thisBatchForm.Dispose();
            thisBatchForm = null;
        }

    }
}

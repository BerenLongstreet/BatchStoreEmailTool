using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace BatchStoreEmailTool
{

    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

        }

        public string GetSoftwareSetting(string KeyName, string DefaultValue)
        {

            try
            {
                return Properties.Settings.Default.Properties[KeyName].DefaultValue.ToString();
            }
            catch(NullReferenceException)
            {
                return DefaultValue;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public void SetSoftwareSetting(string KeyName, string NewValue)
        {
            try
            {
                Properties.Settings.Default.Properties[KeyName].DefaultValue = NewValue;
            }
            catch (NullReferenceException)
            {
                //Copy the Mode setting to a new setting
                System.Configuration.SettingsProperty newProp = new System.Configuration.SettingsProperty(Properties.Settings.Default.Properties["Mode"]);

                newProp.Name = KeyName;
                newProp.DefaultValue = NewValue;

                Properties.Settings.Default.Properties.Add(newProp);
                Properties.Settings.Default.Save();

            }
            catch (System.Exception)
            {
                throw;
            }
        }


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }


}

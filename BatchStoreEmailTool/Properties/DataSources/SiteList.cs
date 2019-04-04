using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace BatchStoreEmailTool.Properties.DataSources
{

    partial class SiteList
    {
        public bool LoadFromUntypedDataset(ref DataSet DatasetToLoad)
        {
            try
            {
                this.Load(DatasetToLoad.Tables[0].CreateDataReader(), LoadOption.OverwriteChanges, this.CompanySites);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        partial class CompanySitesDataTable
        {
        }

        public SiteInfo GetSingleSiteInfo(string SiteKey)
        {
            try
            {
                var SiteQuery = from s in this.CompanySites
                               where s.SiteKey.Equals(SiteKey)
                               select new SiteInfo
                               {
                                   SiteNumber = s.SiteNumber.ToString(),
                                   SiteName = s.SiteName,
                                   EmailAddress = s.PrimaryEmailAddress,
                                   DistrictEmailAddress = s.DistrictEmail
                               };

                SiteInfo thisSite = SiteQuery.First();

                return thisSite;

            }
            catch (System.Exception)
            { throw; }
        }

        public string GetSiteEmailAddress(string SiteKey)
        {
            string ResultEmailAddress = String.Empty;

            try
            {
                var thisSite = this.CompanySites.Where(Site => Site.SiteKey.Equals(SiteKey));

                foreach (CompanySitesRow Site in thisSite)
                {
                    ResultEmailAddress = Site.PrimaryEmailAddress;
                }
            }
            catch (System.Exception)
            { throw; }

            return ResultEmailAddress;
        }
    }
}

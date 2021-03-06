﻿using System.Collections.Generic;
using Datory;
using Newtonsoft.Json;
using SiteServer.CMS.Database.Core;
using SiteServer.CMS.Database.Models;

namespace SiteServer.Cli.Updater.Tables
{
    public partial class TableSitePermissions
    {
        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("publishmentSystemID")]
        public long PublishmentSystemId { get; set; }

        [JsonProperty("nodeIDCollection")]
        public string NodeIdCollection { get; set; }

        [JsonProperty("channelPermissions")]
        public string ChannelPermissions { get; set; }

        [JsonProperty("websitePermissions")]
        public string WebsitePermissions { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class TableSitePermissions
    {
        public static readonly List<string> OldTableNames = new List<string>
        {
            "siteserver_SystemPermissions",
            "wcm_SystemPermissions"
        };

        public static ConvertInfo Converter => new ConvertInfo
        {
            NewTableName = NewTableName,
            NewColumns = NewColumns,
            ConvertKeyDict = ConvertKeyDict,
            ConvertValueDict = ConvertValueDict
        };

        private static readonly string NewTableName = DataProvider.SitePermissions.TableName;

        private static readonly List<TableColumn> NewColumns = DataProvider.SitePermissions.TableColumns;

        private static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(SitePermissionsInfo.SiteId), nameof(PublishmentSystemId)},
                {nameof(SitePermissionsInfo.ChannelIdCollection), nameof(NodeIdCollection)}
            };

        private static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}

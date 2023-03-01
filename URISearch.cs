using Playnite.SDK;
using Playnite.SDK.Events;
using Playnite.SDK.Models;
using Playnite.SDK.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace URISearch
{
    public class URISearch : GenericPlugin
    {
        private static readonly ILogger logger = LogManager.GetLogger();

        public override Guid Id { get; } = Guid.Parse("98d22f05-e556-42e6-9c62-986207d69812");

        public URISearch(IPlayniteAPI api) : base(api)
        {
            Properties = new GenericPluginProperties
            {
                HasSettings = false
            };
            
            PlayniteApi.UriHandler.RegisterSource("search", (args) =>
            {
                PlayniteApi.MainView.OpenSearch("");
            }

            );
        }


    }
}
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FubuMVC.Core.Ajax;
using FubuMVC.Core.Assets;
using FubuMVC.Core.Assets.Diagnostics;
using HtmlTags;

namespace FubuMVC.Visualizations.Diagnostics.Endpoints.Visualizations.Assets
{
    public class AssetsEndpoint
    {
        private readonly AssetGraph _graph;
        private readonly AssetLogsCache _assetLogs;

        public AssetsEndpoint(AssetGraph graph, AssetLogsCache assetLogs)
        {
            _graph = graph;
            _assetLogs = assetLogs;
        }

        public AjaxContinuation get_dependencies_type(AssetDependenciesRequest request)
        {
            var logs = _assetLogs.Entries
              .Select(l => l.Name);

            IEnumerable<IGrouping<string, string>> fileNames = logs.GroupBy(x => new FileInfo(x).Extension);

            var javascripts =
                fileNames.Where(g => g.Key == ".js");

            object data = null;
            foreach (var javascript in javascripts)
            {
                var dependencies = javascript.Select(x => _graph.FileDependencyFor(x));

                data = dependencies.Select(d => new { d, fromName = d.Name }).SelectMany(@t => @t.d.Dependencies(),
                                                                                       (@t, sub) =>
                                                                                       new
                                                                                       {
                                                                                           source = @t.fromName,
                                                                                           target = sub.Name,
                                                                                           type = "suit"
                                                                                       });
            }

            var datum = AjaxContinuation.Successful();

            datum["datum"] = data;

            return datum;
        }

        public AssetModel get_assets(AssetRequest request)
        {
            return new AssetModel()
                        {
                           
                        };
         }
    }

    public class AssetDependenciesRequest
    {
        public string type { get; set; }
    }

    public class AssetModel
    {
        public IEnumerable<string> AssetNames { get; set; }

        public IEnumerable<IGrouping<string, string>> FileNames { get; set; }
    }

    public class AssetRequest
    {
    }
}
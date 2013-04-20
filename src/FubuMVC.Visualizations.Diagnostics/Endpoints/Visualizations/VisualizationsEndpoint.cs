using FubuMVC.Core.Assets;
using HtmlTags;

namespace FubuMVC.Visualizations.Diagnostics.Endpoints.Visualizations
{
    public class VisualizationsEndpoint
    {
        private readonly IAssetRequirements _requirements;

        public VisualizationsEndpoint(IAssetRequirements requirements)
        {
            _requirements = requirements;
        }

        public VisualizationModel get_visualizations(VisualizationRequest request)
         {

            _requirements.Require("fubu.visualizations.css");
             return new VisualizationModel();
         }
    }

    public class VisualizationModel
    {
    }

    public class VisualizationRequest
    {
    }
}
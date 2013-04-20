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

        public HtmlTag get_visualizations(VisualizationRequest request)
         {

            _requirements.Require("fubu.visualizations.css");
             return new HtmlTag("h1").Text("Herp Derp");
         }
    }

    public class VisualizationRequest
    {
    }
}
using HtmlTags;

namespace FubuMVC.Visualizations.Diagnostics.Endpoints.Visualizations
{
    public class VisualizationsEndpoint
    {
         public HtmlTag get_visualizations(VisualizationRequest request)
         {
             return new HtmlTag("h1").Text("Herp Derp");
         }
    }

    public class VisualizationRequest
    {
    }
}
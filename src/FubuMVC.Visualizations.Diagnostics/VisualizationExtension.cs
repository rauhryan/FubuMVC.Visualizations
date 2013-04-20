using FubuMVC.Core;
using FubuMVC.Diagnostics;
//using FubuMVC.Sass;

namespace FubuMVC.Visualizations.Diagnostics
{
    public class VisualizationExtension : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
//            registry
//                .Import<SassExtension>();

             registry
                 .Import<VisualizationFubuRegistry>(DiagnosticsRegistration.DIAGNOSTICS_URL_ROOT);
        }
    }
}
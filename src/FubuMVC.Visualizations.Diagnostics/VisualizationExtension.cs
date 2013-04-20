using FubuMVC.Core;
using FubuMVC.Diagnostics;

namespace FubuMVC.Visualizations.Diagnostics
{
    public class VisualizationExtension : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
            registry.Import<VisualizationFubuRegistry>(DiagnosticsRegistration.DIAGNOSTICS_URL_ROOT);
        }
    }
}
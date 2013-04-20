using FubuMVC.Core;
using FubuMVC.Visualizations.Diagnostics.Navigation;

namespace FubuMVC.Visualizations.Diagnostics
{
    public class VisualizationFubuRegistry : FubuRegistry
    {
        public VisualizationFubuRegistry()
        {
            Actions.FindBy(classes =>
                               {
                                   classes.Applies.ToThisAssembly();
                                   classes.IncludeClassesSuffixedWithEndpoint();
                               });

            Policies.Add<VisualizationsMenu>();

        }
    }
}
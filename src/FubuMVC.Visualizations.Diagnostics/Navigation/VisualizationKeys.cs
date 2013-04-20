using FubuLocalization;
using FubuMVC.Diagnostics.Navigation;
using FubuMVC.Navigation;
using FubuMVC.Visualizations.Diagnostics.Endpoints.Visualizations;

namespace FubuMVC.Visualizations.Diagnostics.Navigation
{
    public class VisualizationKeys : StringToken
    {
        public static readonly VisualizationKeys Main = new VisualizationKeys("Visualizations");

        public bool Equals(VisualizationKeys other)
        {
            return other.Key.Equals(Key);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals(obj as VisualizationKeys);
        }

        public override int GetHashCode()
        {
            return ("VisualizationKeys:" + Key).GetHashCode();
        }

        protected VisualizationKeys(string defaultValue)
            : base(null, defaultValue, namespaceByType: true)
        {
        }
    }

    public class VisualizationsMenu : NavigationRegistry
    {
        public VisualizationsMenu()
        {
            ForMenu(DiagnosticKeys.Main);
            Add += MenuNode.ForInput<VisualizationRequest>(VisualizationKeys.Main);
        }
    }
}
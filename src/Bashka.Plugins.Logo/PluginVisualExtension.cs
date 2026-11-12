using Bashka.Plugins.Core.Abstract;

namespace Bashka.Plugins.Logo;

public sealed class PluginVisualExtension : VisualExtension
{
    protected override IEnumerable<string> StyleUris =>
    [
        "avares://Bashka.Plugins.Logo/Styles.axaml"
    ];
}
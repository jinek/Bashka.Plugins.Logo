using Autofac;
using Bashka.Plugins.Core.Abstract;
using Bashka.Plugins.Core.Scoping;

namespace Bashka.Plugins.Logo;

public sealed class PluginModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.FullRegister<PluginVisualExtension, VisualExtension>();
    }
}
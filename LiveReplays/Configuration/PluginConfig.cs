using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace LiveReplays.Configuration
{
    internal class PluginConfig
    {
        public static PluginConfig Instance { get; set; }

        public virtual bool UseValue { get; set; } = true;
    }
}
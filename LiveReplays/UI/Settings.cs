using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeatSaberMarkupLanguage.Attributes;
using Zenject;

namespace LiveReplays.UI
{
    internal class Settings
    {
        [Inject]
        public readonly MenuTransitionsHelper menuTransitionsHelper;

        [UIValue("#use")]
        public static bool Use
        {
            get => Configuration.PluginConfig.Instance.UseValue;
            set => Configuration.PluginConfig.Instance.UseValue = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.MenuButtons;
using BeatSaberMarkupLanguage.Settings;
using Zenject;

namespace LiveReplays.UI
{
    internal class MenuButtonManager : IInitializable, IDisposable
    {
        internal readonly MenuTransitionsHelper _helper;

        private readonly MenuButton _menuButton;
        private readonly LiveReplaysFlowCoordinator _liveReplaysFlowCoordinator;
        private readonly Settings _settings;

        public MenuButtonManager(LiveReplaysFlowCoordinator liveReplaysFlowCoordinator, Settings settings)
        {
            _liveReplaysFlowCoordinator = liveReplaysFlowCoordinator;
            _menuButton = new MenuButton("Live Replays", "Live Replay Settings", SummonFlowCoordinator);
            _settings = settings;
            BSMLSettings.instance.AddSettingsMenu("Live Replays", "LiveReplays.Views.SettingsView.bsml", _settings);
        }

        public void Initialize()
        {
            MenuButtons.instance.RegisterButton(_menuButton);
        }

        public void Dispose()
        {
            MenuButtons.instance.UnregisterButton(_menuButton);
        }

        private void SummonFlowCoordinator()
        {
            BeatSaberUI.MainFlowCoordinator.PresentFlowCoordinator(_liveReplaysFlowCoordinator);
        }
    }
}

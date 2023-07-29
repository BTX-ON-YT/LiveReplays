using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BeatSaberMarkupLanguage;

using HMUI;

using Zenject;

namespace LiveReplays.UI
{
    internal class LiveReplaysFlowCoordinator : FlowCoordinator
    {
        [Inject]
        private readonly LiveReplaysViewController _liveReplaysViewController;

        [Inject]
        private readonly MenuTransitionsHelper _helper;
        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (firstActivation)
            {
                showBackButton = true;
                SetTitle("Live Replays");
                ProvideInitialViewControllers(_liveReplaysViewController);
            }
        }

        private void RestartGame()
        {
            _helper.RestartGame(null);
        }

        protected override void BackButtonWasPressed(ViewController topViewController)
        {
            base.BackButtonWasPressed(topViewController);
            BeatSaberUI.MainFlowCoordinator.DismissFlowCoordinator(this, RestartGame, ViewController.AnimationDirection.Horizontal, true);
        }
    }
}

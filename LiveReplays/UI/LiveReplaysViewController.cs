using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Parser;
using BeatSaberMarkupLanguage.ViewControllers;
using LiveReplays.Configuration;
using Zenject;

namespace LiveReplays.UI
{
    internal class LiveReplaysViewController : BSMLResourceViewController, INotifyPropertyChanged
    {
        [Inject]
        public override string ResourceName => "LiveReplays.Views.LiveReplaysView.bsml";
        public readonly LiveReplaysFlowCoordinator _liveReplaysFlowCoordinator;

        [UIParams]
        public readonly BSMLParserParams parserParams;
    }
}

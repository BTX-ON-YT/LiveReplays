using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiraUtil;

using Zenject;

using LiveReplays.UI;

namespace LiveReplays.Installers
{
    internal class OnMenuInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<LiveReplaysViewController>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<LiveReplaysFlowCoordinator>().FromNewComponentOnNewGameObject().AsSingle();
            Container.BindInterfacesAndSelfTo<Settings>().AsSingle();
            Container.BindInterfacesTo<MenuButtonManager>().AsSingle();
        }
    }
}

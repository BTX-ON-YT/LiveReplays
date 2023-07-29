using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using IPA;
using IPA.Config;
using IPA.Config.Stores;
using LiveReplays.Installers;
using SiraUtil.Zenject;
using UnityEngine;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;
using IPAConfig = IPA.Config.Config;

namespace LiveReplays
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {

        internal static IPALogger Log { get; private set; }

        [Init]
        public void Init(IPALogger logger)
        {
            Log = logger;
        }

        [Init]
        public void InitWithConfig(IPAConfig conf)
        {
            Configuration.PluginConfig.Instance = conf.Generated<Configuration.PluginConfig>();
        }

        [Init]
        public void InitWithZenjector(Zenjector zenjector)
        {
            zenjector.Install<OnMenuInstaller>(Location.Menu);
        }
    }
}

using Modules.Core.Names;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoToTwitch.JsonConverter;

public class MainModule : IModule
{
    private readonly IRegionManager _regionManager;

    public MainModule(IRegionManager regionManager)
    {
        _regionManager = regionManager;
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        // 最初に表示するウィンドウ画面
        _regionManager.RequestNavigate(RegionName.Body, NavigationName.Sample);
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }
}

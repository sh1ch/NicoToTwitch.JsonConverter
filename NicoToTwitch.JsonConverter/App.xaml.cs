using Heritage.Systems;
using Modules.Controls;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace NicoToTwitch.JsonConverter;

public partial class App
{
    private CompositeDisposable Disposables = new CompositeDisposable();

    protected override Window CreateShell()
    {
        // shift_jis ファイルを扱う
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        return Container.Resolve<Views.MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<ControlModule>();

        // 最後に実行すること
        moduleCatalog.AddModule<MainModule>();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);

        Disposables.Dispose();
    }
}

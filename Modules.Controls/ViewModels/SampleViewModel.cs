using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Controls.ViewModels;

public class SampleViewModel : BindableBase
{
    /// <summary>
    /// <see cref="SampleViewModel"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    public SampleViewModel()
    {
        Console.WriteLine("Sample ViewModel");
    }
 }

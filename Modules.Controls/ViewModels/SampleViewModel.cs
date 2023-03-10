using HeritageLibrary.Windows.Dialogs;
using Microsoft.Win32;
using Modules.Core.Properties;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Modules.Controls.ViewModels;

public class SampleViewModel : BindableBase
{
    private string ExecutablePath => System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location) ?? "";

    private string _XmlFilePath = "";

    public string XmlFilePath
    {
        get => _XmlFilePath;
        set => SetProperty(ref _XmlFilePath, value);
    }
    public DelegateCommand SelectXmlCommand { get; }

    public DelegateCommand OutputCommand { get; }

    public DelegateCommand SelectOutputFolderCommand { get; }

    /// <summary>
    /// <see cref="SampleViewModel"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    public SampleViewModel()
    {
        Console.WriteLine("Sample ViewModel");

        SelectXmlCommand = new (() =>
        {
            var dialog = new OpenFileDialog();

            dialog.InitialDirectory = ExecutablePath;
            dialog.Filter = CommonResource.XML_FileFilter;

            if (dialog.ShowDialog() ?? false)
            {
                XmlFilePath = dialog.FileName;
            }
        });

        OutputCommand = new (() =>
        {

        });

        SelectOutputFolderCommand = new (() =>
        {
            var browser = new FolderBrowserDialog();
            var window = Application.Current.MainWindow;

            browser.Title = "タイトル";
            browser.SelectedFolderPath = "";
            
            if (browser.ShowDialog(window) == HeritageLibrary.Windows.Dialogs.DialogResult.OK)
            {

            }
        });
    }
 }

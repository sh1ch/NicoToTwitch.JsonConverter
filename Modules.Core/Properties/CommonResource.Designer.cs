﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modules.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CommonResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CommonResource() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Modules.Core.Properties.CommonResource", typeof(CommonResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   json ファイル に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string JSON_File {
            get {
                return ResourceManager.GetString("JSON_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   出力 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Output {
            get {
                return ResourceManager.GetString("Output", resourceCulture);
            }
        }
        
        /// <summary>
        ///   出力フォルダー に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string OutputFolder {
            get {
                return ResourceManager.GetString("OutputFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   選択 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Select {
            get {
                return ResourceManager.GetString("Select", resourceCulture);
            }
        }
        
        /// <summary>
        ///   設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Settings {
            get {
                return ResourceManager.GetString("Settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   XML ファイル に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string XML_File {
            get {
                return ResourceManager.GetString("XML_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   XML ファイル (*.xml)|*.xml|すべてのファイル (*.*)|*.* に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string XML_FileFilter {
            get {
                return ResourceManager.GetString("XML_FileFilter", resourceCulture);
            }
        }
    }
}

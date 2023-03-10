using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.File.NicoNico;

/// <summary>
/// <see cref="NicoChat"/> クラスは、コメントの持つパラメータを表します。
/// </summary>
[DebuggerDisplay("No={No} {SecPos}s Score={Score} {Comment}")]
public record NicoChat
{
    /// <summary>
    /// スレッド ID を取得します。
    /// </summary>
    public int? Thread { get; init; }
    /// <summary>
    /// コメント番号を取得します。
    /// </summary>
    public int No { get; init; }
    /// <summary>
    /// コメントの書き込み位置 (vpos/100) 秒を取得します。
    /// </summary>
    public int Vpos { get; init; }
    /// <summary>
    /// コメントの書き込み位置 (秒) を取得します。
    /// </summary>
    public float SecPos => Vpos / 100F;
    /// <summary>
    /// コメントの書き込み時間 Unix Epoch (ms) を取得します。
    /// </summary>
    public int Date { get; init; }
    /// <summary>
    /// コメントユーザーの ID を取得します。
    /// </summary>
    public string UserId { get; init; } = "";
    /// <summary>
    /// コメントの NG スコアを取得します。
    /// </summary>
    public int Score { get; init; }
    /// <summary>
    /// ニコニコのコマンドを取得します。
    /// </summary>
    public string Mail { get; init; } = "";
    /// <summary>
    /// プレミアムアカウントかどうかを示す内部整数値を取得します。
    /// </summary>
    public int? Premium { get; init; }
    /// <summary>
    /// プレミアムアカウントかどうかを示す値を取得します。
    /// </summary>
    public bool IsPremium => Premium == 0;
    /// <summary>
    /// １週間限定の ID かどうかを示す内部整数値を取得します。
    /// </summary>
    public int? Anonymity { get; init; }
    /// <summary>
    /// １週間限定の ID かどうかを示す値を取得します。
    /// </summary>
    public bool IsAnonymity => Anonymity == 1;
    /// <summary>
    /// コメントを取得します。
    /// </summary>
    public string Comment { get; init; } = "";
    
    /// <summary>
    /// ユーザーの略称名を取得します。
    /// </summary>
    public string AbbreviatedName
    {
        get
        {
            if (string.IsNullOrEmpty(UserId)) return "ななしのよっしん";

            var length = UserId.Length >= 5 ? 5 : UserId.Length;

            return $"ニコ房_{UserId.Substring(0, length)}";
        }
    }

    /// <summary>
    /// <see cref="NicoChat"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    public NicoChat()
    {
    }
}

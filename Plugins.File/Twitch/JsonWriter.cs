using Plugins.File.Twitch.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Plugins.File.Twitch;

public class JsonWriter
{
    /// <summary>
    /// <see cref="JsonWriter"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    public JsonWriter()
    {
    }

    public static void Write(string filePath)
    {
        var file = new v1.ChatData();

        file.Streamer.Name = "永井博之";
        file.Video.Length = 30 * 1;
        file.Video.End = 30 * 1;
        file.Video.Title = "サンプルタイトル";

        var badges = new List<UserBadge>();

        file.Add("なまえA", 3, "テスト3", UserColors.GetRandom(), badges);
        file.Add("なまえB", 5, "テスト５", UserColors.GetRandom(), badges);
        file.Add("なまえC", 10, "テスト10", UserColors.GetRandom(), badges);

        var options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true,
        };

        var jsonText = JsonSerializer.Serialize<v1.ChatData>(file, options);

        System.IO.File.WriteAllText(filePath, jsonText, Encoding.UTF8);
    }
}

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

    public static void Write(string filePath, v1.ChatData chatData)
    {
        var options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true,
        };

        var jsonText = JsonSerializer.Serialize<v1.ChatData>(chatData, options);

        System.IO.File.WriteAllText(filePath, jsonText, Encoding.UTF8);
    }
}

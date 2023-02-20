using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Plugins.File.Twitch.v1;

public class Fragment
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = "";
    [JsonPropertyName("emoticon")]
    public object? Emoticon { get; set; } = null;
}

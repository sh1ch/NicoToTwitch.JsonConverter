using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Plugins.File.Twitch.v1;

public class Video
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = "";
    [JsonPropertyName("start")]
    public float Start { get; set; }
    [JsonPropertyName("end")]
    public float End { get; set; }
    [JsonPropertyName("length")]
    public float Length { get; set; }
}

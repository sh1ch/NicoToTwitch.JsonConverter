using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Plugins.File.Twitch.v1;

public class Streamer
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
}

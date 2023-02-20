using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Plugins.File.Twitch.v1;

public class UserBadge
{
    [JsonPropertyName("_id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("version")]
    public string Version { get; set; } = "";

    public void SetBits(int value)
    {
        Id = "Bits";
        Version = value.ToString();
    }

    public void SetPremium(int value = 1)
    {
        Id = "premium";
        Version = value.ToString();
    }

    public void SetSubscriber(int month)
    {
        Id = "subscriber";
        Version = month.ToString();
    }
}

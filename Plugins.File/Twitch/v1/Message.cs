using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Plugins.File.Twitch.v1;

public class Message
{
    private List<Fragment> _Fragments = new List<Fragment>();

    [JsonPropertyName("body")]
    public string Body { get; set; } = "";
    [JsonPropertyName("fragments")]
    public IEnumerable<Fragment> Fragments => _Fragments;

    public void SetText(string text)
    {
        Body = text;

        var fragment = new Fragment
        {
            Text = text,
            Emoticon = null,
        };

        _Fragments.Add(fragment);
    }
}

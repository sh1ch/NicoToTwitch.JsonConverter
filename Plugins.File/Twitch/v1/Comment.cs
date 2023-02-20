using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Plugins.File.Twitch.v1;

public class Comment
{
    private List<UserBadge> _UserBadge = new List<UserBadge>();

    [JsonPropertyName("content_offset_seconds")]
    public float OffsetSeconds { get; set; }
    [JsonPropertyName("source")]
    public string Source => "chat";
    [JsonPropertyName("state")]
    public string State => "published";
    [JsonPropertyName("is_action")]
    public bool IsAction => false;
    [JsonPropertyName("user_color")]
    public string UserColor { get; set; } = "#FF0000";

    [JsonPropertyName("commenter")]
    public Commenter Commenter { get; init; } = new Commenter();
    [JsonPropertyName("message")]
    public Message Message { get; init; } = new Message();
    [JsonPropertyName("user_badges")]
    public IEnumerable<UserBadge> UserBadges => _UserBadge;

    /// <summary>
    /// <see cref="Comment"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    public Comment()
    {
    }

    public void SetText(string text)
    {
        Message.SetText(text);
    }

    public void SetBadge(string id, string version)
    {
        _UserBadge.Add(new UserBadge 
        {
            Id = id,
            Version = version,
        });
    }

    public void SetBadge(UserBadge badge)
    {
        _UserBadge.Add(badge);
    }
}

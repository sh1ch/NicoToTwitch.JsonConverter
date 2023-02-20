using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Plugins.File.Twitch.v1;

public class ChatData
{
    private List<Comment> _Comments = new List<Comment>();

    public FileInfo FileInfo { get; set; } = new FileInfo();
    public string CreatedAt { get; init; } = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffzzz");
    [JsonPropertyName("streamer")]
    public Streamer Streamer { get; set; } = new Streamer();
    [JsonPropertyName("video")]
    public Video Video { get; set; } = new Video();

    [JsonPropertyName("comments")]
    public IEnumerable<Comment> Comments => _Comments;

    /// <summary>
    /// <see cref="ChatData"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    public ChatData()
    {
    }

    public void Add(string name, float vpos, string text, string color, IEnumerable<UserBadge> badges)
    {
        var commenter = new Commenter
        {
            DisplayName = name,
        };

        var comment = new Comment
        {
            Commenter = commenter,
            OffsetSeconds = vpos,
            UserColor = color,
        };

        comment.SetText(text);

        foreach (var badge in badges) 
        {
            comment.SetBadge(badge);
        }

        _Comments.Add(comment);
    }
}

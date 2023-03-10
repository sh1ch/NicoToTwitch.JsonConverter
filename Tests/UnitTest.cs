using Newtonsoft.Json;
using Plugins.File.Twitch.v1;
using nico = Plugins.File.NicoNico;
using twitch = Plugins.File.Twitch;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Read_ニコ動Xml()
    {
        var comments = nico.XmlReader.Read("samples/data1.xml");

        Assert.Pass();
    }

    [Test]
    public void Test_Write_TwitchJson()
    {
        var chat = new ChatData();

        chat.Streamer.Name = "配信者の名前";
        chat.Video.Length = 30 * 1;
        chat.Video.End = 30 * 1;
        chat.Video.Title = "サンプルタイトル";

        var emptyBadges = new List<UserBadge>();

        // 秒数の早いものから書き込む必要がある
        chat.Add("なまえ A", 3, "テスト3", UserColors.GetRandom(), emptyBadges);
        chat.Add("なまえ B", 5, "テスト５", UserColors.GetRandom(), emptyBadges);
        chat.Add("なまえ C", 10, "テスト10", UserColors.GetRandom(), emptyBadges);

        twitch.JsonWriter.Write(@"output\test.json", chat);
    }

    [Test]
    public void Test_ReadAndWrite()
    {
        var comments1 = nico.XmlReader.Read("samples/data1.xml")
            .Where(p => p.Score >= -200);

        var comments2 = comments1.OrderBy(p => p.SecPos);

        var chat = new ChatData();

        chat.Streamer.Name = "配信者の名前";
        chat.Video.Length = 30 * 60;
        chat.Video.End = 30 * 60;
        chat.Video.Title = "サンプルタイトル";

        var emptyBadges = new List<UserBadge>();

        foreach (var comment in comments2)
        {
            chat.Add(comment.AbbreviatedName, comment.SecPos, comment.Comment, UserColors.GetRandom(), emptyBadges);
        }

        twitch.JsonWriter.Write(@"output\test2.json", chat);
    }
}
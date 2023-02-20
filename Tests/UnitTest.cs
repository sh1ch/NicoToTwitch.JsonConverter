using Newtonsoft.Json;

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
    public void Test1()
    {
        var comments = nico.XmlReader.Read("samples/data1.xml");

        Assert.Pass();
    }

    [Test]
    public void Test_WriteJson()
    {
        twitch.JsonWriter.Write(@"output\test.json");
    }
}
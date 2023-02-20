using Heritage.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.File.Twitch.v1;

public static class UserColors
{
    public const string Blue = "#0000FF";
    public const string Coral = "#FF7F50";
    public const string DodgerBlue = "#1E90FF";
    public const string SpringGreen = "#00FF7F";
    public const string YellowGreen = "#9ACD32";
    public const string Green = "#008000";
    public const string OrangeRed = "#FF4500";
    public const string Red = "#FF0000";
    public const string GoldenRod = "#DAA520";
    public const string HotPink = "#FF69B4";
    public const string CadetBlue = "#5F9EA0";
    public const string SeaGreen = "#2E8B57";
    public const string Chocolate = "#D2691E";
    public const string BlueViolet = "#8A2BE2";
    public const string Firebrick = "#B22222";

    private static List<(int, string)> _RandomData = new List<(int, string)>()
    {
        (1, Blue),
        (2, Coral),
        (3, DodgerBlue),
        (4, SpringGreen),
        (5, YellowGreen),
        (6, Green),
        (7, OrangeRed),
        (8, Red),
        (9, GoldenRod),
        (10, HotPink),
        (11, CadetBlue),
        (12, SeaGreen),
        (13, Chocolate),
        (14, BlueViolet),
        (15, Firebrick),
    };

    public static string GetRandom()
    {
        var no = RandomProvider.Range(1, _RandomData.Count);
        var color = _RandomData.Single(p => p.Item1 == no);

        return color.Item2;
    }
}

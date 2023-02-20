using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Plugins.File.NicoNico;

public class XmlReader
{
    public static IEnumerable<NicoChat> Read(string filePath)
    {
        var xml  = XElement.Load(filePath);
        var chats  = xml.Elements("chat");
        var comments = new List<NicoChat>();

        foreach (var chat in chats)
        {
            var thread = (int?)chat.Attribute("thread");
            var no = (int?)chat.Attribute("no");
            var vpos = (int?)chat.Attribute("vpos");
            var date = (int?)chat.Attribute("date");
            var anonymity = (int?)chat.Attribute("anonymity");
            var premium = (int?)chat.Attribute("premium");
            var userId = chat.Attribute("user_id")?.Value ?? "";
            var mail = chat.Attribute("mail")?.Value ?? "";
            var comment = chat.Value;

            if (vpos == null || string.IsNullOrEmpty(comment)) continue;

            comments.Add(new NicoChat
            {
                Thread = thread,
                No = no ?? 0,
                Vpos = vpos ?? 0,
                Date = date ?? 0,
                Anonymity = anonymity,
                Premium = premium,
                UserId = userId,
                Mail = mail,
                Comment = comment,
            });
        }

        return comments;
    }
}

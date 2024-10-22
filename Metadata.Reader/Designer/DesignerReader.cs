using Metadata.Interfaces;
using System.Xml.Linq;
using U8Xml;

namespace Metadata.Reader.Designer;

internal class DesignerReader : IConfigurationReader
{
    private string path { get; set; }

    public DesignerReader(string path)
    {
        this.path = path;
    }

    public IConfiguration read()
    {
        var metadataPath = Path.Join(path, "Configuration.xml");
        using (XmlObject xml = XmlParser.ParseFile(metadataPath))
        {
            XmlNode root = xml.Root;
            foreach (XmlNode node in root.Children)
            {
                var breakpoint = 1;
            }

            throw new NotImplementedException();
        }
    }
}

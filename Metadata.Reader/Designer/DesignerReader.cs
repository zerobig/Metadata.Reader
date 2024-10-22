using Metadata.Interfaces;

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
        throw new NotImplementedException();
    }
}

using Metadata.Interfaces;

namespace Metadata.Reader.Edt;

internal class EdtReader : IConfigurationReader
{
    private string path { get; set; }

    public EdtReader(string path)
    {
        this.path = path;
    }

    public IConfiguration read()
    {
        throw new NotImplementedException();
    }
}

using Metadata.Interfaces;
using Metadata.Reader.Designer;
using Metadata.Reader.Edt;

namespace Metadata.Reader;

public class MetadataReader
{
    public IConfiguration readMetadata(string path)
    {
        var reader = createReader(path);
        return reader.read();
    }

    private IConfigurationReader createReader(string path)
    {
        var configurationType = getConfigurationType(path);
        if (configurationType == ConfigurationType.DESIGNER)
        {
            return new DesignerReader(path);
        }
        else
        {
            return new EdtReader(path);
        }
    }

    private ConfigurationType getConfigurationType(string path)
    {
        // TODO: Временно
        return ConfigurationType.DESIGNER;
    }
}

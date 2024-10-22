using Metadata.Interfaces;

namespace Metadata.Reader;

internal interface IConfigurationReader
{
    abstract IConfiguration read();
}

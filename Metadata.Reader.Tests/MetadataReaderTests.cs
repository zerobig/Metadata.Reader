using Xunit;

namespace Metadata.Reader.Tests;

public class MetadataReaderTests
{
    [Fact]
    public void ReadDesignerConfiguration()
    {
        // Arrange
        var reader = new MetadataReader();

        // Act
        var configuration = reader.readMetadata("../../../TestFiles/Designer");

        // Assert
        // TODO:
    }
}
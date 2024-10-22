using Metadata.Interfaces;
using Metadata.Interfaces.General;

namespace Metadata.Classes;

internal class Configuration: IConfiguration
{
    List<ISubsystem> subsystems { get; set; } = new List<ISubsystem>();
    List<ILanguage> languages{ get; set; } = new List<ILanguage>();
    List<ICatalog> catalogs { get; set; } = new List<ICatalog>();
    List<IDocument> documents { get; set; } = new List<IDocument>();
}

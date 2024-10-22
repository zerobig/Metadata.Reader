using Metadata.Interfaces.General;

namespace Metadata.Interfaces.Common;

internal interface IObjectReference
{
    Guid uuid { get; }
    string name { get; }
    Dictionary<ILanguage, string> synonyms { get; }
    string comment { get; }
}

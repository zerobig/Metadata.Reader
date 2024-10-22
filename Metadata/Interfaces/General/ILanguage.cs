using Metadata.Interfaces.Common;

namespace Metadata.Interfaces.General;

internal interface ILanguage: IObjectReference
{
    string code { get; }
}

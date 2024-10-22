using Metadata.Interfaces.Common;

namespace Metadata.Interfaces.General;

internal interface ISubsystem: IObjectReference
{
    ISubsystem parent { get; }
    abstract List<IObjectReference> getContent();
    abstract List<IObjectReference> getChilldren();
}

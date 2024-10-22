using Metadata.Interfaces.Common;

namespace Metadata.Interfaces;

internal interface ICatalog: IObjectReference
{
    List<IAttribute> attributes { get; }
    List<ITabularSection> tabularSections { get; }
    List<IForm> forms{ get; }
    List<ITemplate> templates { get; }
    List<ICommand> commands { get; }
}

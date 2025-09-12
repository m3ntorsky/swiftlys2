using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicGameEventListener : CLogicalEntity, ILogicGameEventListener {

  public CLogicGameEventListener(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnEventFired {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xB18EF22E84EA158));
  }
  public ISchemaUntypedField GameEventName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB18EF22C6581BAE));
  }
  public ISchemaUntypedField GameEventItem {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB18EF22ACB669EE));
  }
  public ref bool StartDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB18EF2261ED0C4F));
  }

  public void EnabledUpdated() {
    Schema.Update(_Handle, 0xB18EF226154EB7E);
  }
}
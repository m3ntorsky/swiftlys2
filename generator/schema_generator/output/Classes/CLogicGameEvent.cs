using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicGameEvent : CLogicalEntity, ILogicGameEvent {

  public CLogicGameEvent(nint handle) : base(handle) {
  }

  public ISchemaUntypedField EventName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xBED9751E78114A54));
  }


}
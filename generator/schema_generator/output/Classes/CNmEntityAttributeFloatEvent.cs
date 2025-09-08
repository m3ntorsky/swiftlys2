using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmEntityAttributeFloatEvent : CNmEntityAttributeEventBase, INmEntityAttributeFloatEvent {

  public CNmEntityAttributeFloatEvent(nint handle) : base(handle) {
  }

  public ISchemaUntypedField FloatValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x3ADB66C2ADBE62AA));
  }


}
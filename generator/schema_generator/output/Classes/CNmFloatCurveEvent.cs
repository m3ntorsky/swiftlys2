using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatCurveEvent : CNmEvent, INmFloatCurveEvent {

  public CNmFloatCurveEvent(nint handle) : base(handle) {
  }

  public CNmFloatCurveEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x79BEBEA95066900));
  }
  public ISchemaUntypedField Curve {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x79BEBEABFFA0B34));
  }


}
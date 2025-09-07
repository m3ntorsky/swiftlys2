using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStateNodeTransitionData : SchemaClass, IStateNodeTransitionData {

  public CStateNodeTransitionData(nint handle) : base(handle) {
  }

  public CStateNodeTransitionData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IBlendCurve Curve {
    get => new CBlendCurve(_Handle + Schema.GetOffset(0xFC9FD460BFFA0B34));
  }
  public ISchemaUntypedField BlendDuration {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFC9FD460BC9B1228));
  }
  public ISchemaUntypedField ResetCycleValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFC9FD4609897AC3F));
  }
  public ISchemaUntypedField Reset {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFC9FD460F99F9AA0));
  }
  public ISchemaUntypedField ResetCycleOption {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFC9FD460A597A1E3));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapDistanceToLineSegmentBase : CParticleFunctionOperator, IC_OP_RemapDistanceToLineSegmentBase {

  public C_OP_RemapDistanceToLineSegmentBase(nint handle) : base(handle) {
  }

  public ref int CP0 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD8219F7AD3B1E3E6));
  }
  public ref int CP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD8219F7AD4B1E579));
  }
  public ref float MinInputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD8219F7ABDB4BC64));
  }
  public ref float MaxInputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD8219F7A3EF75C2A));
  }
  public ref bool InfiniteLine {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD8219F7A9C5BC47F));
  }


}
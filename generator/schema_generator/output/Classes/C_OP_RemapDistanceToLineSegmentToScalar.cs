using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapDistanceToLineSegmentToScalar : C_OP_RemapDistanceToLineSegmentBase, IC_OP_RemapDistanceToLineSegmentToScalar {

  public C_OP_RemapDistanceToLineSegmentToScalar(nint handle) : base(handle) {
  }

  public C_OP_RemapDistanceToLineSegmentToScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF4B67462E5729606));
  }
  public ref float MinOutputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF4B67462F63C7011));
  }
  public ref float MaxOutputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF4B67462A91B71B3));
  }


}
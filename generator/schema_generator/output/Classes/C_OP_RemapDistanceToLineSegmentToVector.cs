using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapDistanceToLineSegmentToVector : C_OP_RemapDistanceToLineSegmentBase, IC_OP_RemapDistanceToLineSegmentToVector {

  public C_OP_RemapDistanceToLineSegmentToVector(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF88068A9E5729606));
  }
  public ref Vector MinOutputValue {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xF88068A94BF7BCBF));
  }
  public ref Vector MaxOutputValue {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xF88068A9A7A69BC5));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapVectorComponentToScalar : CParticleFunctionOperator, IC_OP_RemapVectorComponentToScalar {

  public C_OP_RemapVectorComponentToScalar(nint handle) : base(handle) {
  }

  public C_OP_RemapVectorComponentToScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x39413771AE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x39413771E5729606));
  }
  public ref int Component {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x39413771BFD0952C));
  }


}
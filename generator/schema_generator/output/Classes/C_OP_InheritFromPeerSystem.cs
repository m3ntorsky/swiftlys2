using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_InheritFromPeerSystem : CParticleFunctionOperator, IC_OP_InheritFromPeerSystem {

  public C_OP_InheritFromPeerSystem(nint handle) : base(handle) {
  }

  public C_OP_InheritFromPeerSystem(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8105C85DE5729606));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8105C85DAE775669));
  }
  public ref int Increment {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8105C85D2359F182));
  }
  public ref int GroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8105C85D3BB05135));
  }


}
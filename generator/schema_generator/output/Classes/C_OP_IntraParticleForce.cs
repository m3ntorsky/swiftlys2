using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_IntraParticleForce : CParticleFunctionForce, IC_OP_IntraParticleForce {

  public C_OP_IntraParticleForce(nint handle) : base(handle) {
  }

  public C_OP_IntraParticleForce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float AttractionMinDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x784412D0CEAEE62D));
  }
  public ref float AttractionMaxDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x784412D04052F81F));
  }
  public ref float AttractionMaxStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x784412D09FE72EFD));
  }
  public ref float RepulsionMinDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x784412D018F9EFB1));
  }
  public ref float RepulsionMaxDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x784412D05B7D269B));
  }
  public ref float RepulsionMaxStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x784412D0B9401C21));
  }
  public ref bool UseAABB {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x784412D029AAFF2E));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapExternalWindToCP : CParticleFunctionPreEmission, IC_OP_RemapExternalWindToCP {

  public C_OP_RemapExternalWindToCP(nint handle) : base(handle) {
  }

  public C_OP_RemapExternalWindToCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x19366DF9EB661472));
  }
  public ref int CPOutput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x19366DF92077C953));
  }
  public IParticleCollectionVecInput Scale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x19366DF95F596B51));
  }
  public ref bool SetMagnitude {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x19366DF9B87FB05F));
  }
  public ref int OutVectorField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x19366DF9F9041E74));
  }


}
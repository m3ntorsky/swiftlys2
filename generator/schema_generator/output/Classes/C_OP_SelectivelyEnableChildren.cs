using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SelectivelyEnableChildren : CParticleFunctionPreEmission, IC_OP_SelectivelyEnableChildren {

  public C_OP_SelectivelyEnableChildren(nint handle) : base(handle) {
  }

  public C_OP_SelectivelyEnableChildren(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput ChildGroupID {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x73804886E3F3C965));
  }
  public IParticleCollectionFloatInput FirstChild {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x738048862DF4A8BD));
  }
  public IParticleCollectionFloatInput NumChildrenToEnable {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x738048868039247A));
  }
  public ref bool PlayEndcapOnStop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73804886CEC82FA1));
  }
  public ref bool DestroyImmediately {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7380488675F43101));
  }


}
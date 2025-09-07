using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_EnableChildrenFromParentParticleCount : CParticleFunctionPreEmission, IC_OP_EnableChildrenFromParentParticleCount {

  public C_OP_EnableChildrenFromParentParticleCount(nint handle) : base(handle) {
  }

  public C_OP_EnableChildrenFromParentParticleCount(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ChildGroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDF13D5F2E3F3C965));
  }
  public ref int FirstChild {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDF13D5F22DF4A8BD));
  }
  public IParticleCollectionFloatInput NumChildrenToEnable {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDF13D5F28039247A));
  }
  public ref bool DisableChildren {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDF13D5F2F13DBFCC));
  }
  public ref bool PlayEndcapOnStop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDF13D5F2CEC82FA1));
  }
  public ref bool DestroyImmediately {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDF13D5F275F43101));
  }


}
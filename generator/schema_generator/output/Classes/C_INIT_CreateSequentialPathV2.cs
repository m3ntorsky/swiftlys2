using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateSequentialPathV2 : CParticleFunctionInitializer, IC_INIT_CreateSequentialPathV2 {

  public C_INIT_CreateSequentialPathV2(nint handle) : base(handle) {
  }

  public C_INIT_CreateSequentialPathV2(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput MaxDistance {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xEC06632A844E396A));
  }
  public IParticleCollectionFloatInput NumToAssign {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xEC06632AF73366BD));
  }
  public ref bool Loop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEC06632AC668A4CB));
  }
  public ref bool CPPairs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEC06632AA5D36D0F));
  }
  public ref bool SaveOffset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEC06632A43F64E5B));
  }
  public IPathParameters PathParams {
    get => new CPathParameters(_Handle + Schema.GetOffset(0xEC06632A3C10092C));
  }


}
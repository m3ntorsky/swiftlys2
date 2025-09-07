using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateOnGrid : CParticleFunctionInitializer, IC_INIT_CreateOnGrid {

  public C_INIT_CreateOnGrid(nint handle) : base(handle) {
  }

  public C_INIT_CreateOnGrid(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput XCount {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2C82A08B6E80D4FA));
  }
  public IParticleCollectionFloatInput YCount {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2C82A08B51D32897));
  }
  public IParticleCollectionFloatInput ZCount {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2C82A08BCCE7A908));
  }
  public IParticleCollectionFloatInput XSpacing {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2C82A08B374E0750));
  }
  public IParticleCollectionFloatInput YSpacing {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2C82A08B836B50C9));
  }
  public IParticleCollectionFloatInput ZSpacing {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2C82A08BF78FF062));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2C82A08B3F31A6BD));
  }
  public ref bool LocalSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2C82A08B62418E6E));
  }
  public ref bool Center {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2C82A08B69BF05E4));
  }
  public ref bool Hollow {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2C82A08B22E4957E));
  }


}
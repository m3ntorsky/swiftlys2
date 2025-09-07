using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitialVelocityFromHitbox : CParticleFunctionInitializer, IC_INIT_InitialVelocityFromHitbox {

  public C_INIT_InitialVelocityFromHitbox(nint handle) : base(handle) {
  }

  public C_INIT_InitialVelocityFromHitbox(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float VelocityMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x48F25F17FDB3D7E4));
  }
  public ref float VelocityMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x48F25F170BC775A6));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x48F25F173F31A6BD));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x48F25F176A21BB0E));
  }
  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x48F25F1710D1938B));
  }


}
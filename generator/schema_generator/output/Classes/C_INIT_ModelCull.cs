using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_ModelCull : CParticleFunctionInitializer, IC_INIT_ModelCull {

  public C_INIT_ModelCull(nint handle) : base(handle) {
  }

  public C_INIT_ModelCull(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE9ECCC6B3F31A6BD));
  }
  public ref bool BoundBox {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE9ECCC6BAB65CDDC));
  }
  public ref bool CullOutside {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE9ECCC6BA6EF9E04));
  }
  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE9ECCC6B10D1938B));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xE9ECCC6B6A21BB0E));
  }


}
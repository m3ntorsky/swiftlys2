using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ModelCull : CParticleFunctionOperator, IC_OP_ModelCull {

  public C_OP_ModelCull(nint handle) : base(handle) {
  }

  public C_OP_ModelCull(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xED02878A3F31A6BD));
  }
  public ref bool BoundBox {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xED02878AAB65CDDC));
  }
  public ref bool CullOutside {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xED02878AA6EF9E04));
  }
  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xED02878A10D1938B));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xED02878A6A21BB0E));
  }


}
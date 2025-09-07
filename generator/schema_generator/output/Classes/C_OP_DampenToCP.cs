using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DampenToCP : CParticleFunctionOperator, IC_OP_DampenToCP {

  public C_OP_DampenToCP(nint handle) : base(handle) {
  }

  public C_OP_DampenToCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB04699CE3F31A6BD));
  }
  public ref float Range {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB04699CE3FC92844));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB04699CEB731A42F));
  }


}
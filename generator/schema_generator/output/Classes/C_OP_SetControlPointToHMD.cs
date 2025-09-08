using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointToHMD : CParticleFunctionPreEmission, IC_OP_SetControlPointToHMD {

  public C_OP_SetControlPointToHMD(nint handle) : base(handle) {
  }

  public ref int CP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x58898D54D4B1E579));
  }
  public ref Vector CP1Pos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x58898D54408288D9));
  }
  public ref bool OrientToHMD {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x58898D54F3E0D0A6));
  }


}
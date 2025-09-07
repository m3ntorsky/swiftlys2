using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointFieldToWater : CParticleFunctionPreEmission, IC_OP_SetControlPointFieldToWater {

  public C_OP_SetControlPointFieldToWater(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointFieldToWater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int SourceCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x77BA8CA24C01E3B7));
  }
  public ref int DestCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x77BA8CA2E27355DA));
  }
  public ref int CPField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x77BA8CA250B79876));
  }


}
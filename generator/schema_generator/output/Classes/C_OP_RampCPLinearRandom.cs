using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RampCPLinearRandom : CParticleFunctionPreEmission, IC_OP_RampCPLinearRandom {

  public C_OP_RampCPLinearRandom(nint handle) : base(handle) {
  }

  public C_OP_RampCPLinearRandom(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int OutControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF3F4631CD021D73F));
  }
  public ref Vector RateMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xF3F4631CB1C06501));
  }
  public ref Vector RateMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xF3F4631CA3D569AF));
  }


}
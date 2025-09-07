using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_TwistAroundAxis : CParticleFunctionForce, IC_OP_TwistAroundAxis {

  public C_OP_TwistAroundAxis(nint handle) : base(handle) {
  }

  public C_OP_TwistAroundAxis(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float ForceAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE1FA036870831A84));
  }
  public ref Vector TwistAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE1FA0368BEAAB521));
  }
  public ref bool LocalSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE1FA036862418E6E));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE1FA03683F31A6BD));
  }


}
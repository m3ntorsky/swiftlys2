using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ForceBasedOnDistanceToPlane : CParticleFunctionForce, IC_OP_ForceBasedOnDistanceToPlane {

  public C_OP_ForceBasedOnDistanceToPlane(nint handle) : base(handle) {
  }

  public C_OP_ForceBasedOnDistanceToPlane(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MinDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x41A5EAC25219494D));
  }
  public ref Vector ForceAtMinDist {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x41A5EAC23BD9C5EB));
  }
  public ref float MaxDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x41A5EAC2EFFD23F7));
  }
  public ref Vector ForceAtMaxDist {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x41A5EAC24119AAF9));
  }
  public ref Vector PlaneNormal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x41A5EAC221103682));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x41A5EAC23F31A6BD));
  }
  public ref float Exponent {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x41A5EAC220A7BCBC));
  }


}
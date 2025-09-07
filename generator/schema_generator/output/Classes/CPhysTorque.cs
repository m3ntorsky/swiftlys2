using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysTorque : CPhysForce, IPhysTorque {

  public CPhysTorque(nint handle) : base(handle) {
  }

  public CPhysTorque(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Axis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6EADFD042B06DE94));
  }


}
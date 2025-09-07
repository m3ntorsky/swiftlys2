using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysPulley : CPhysConstraint, IPhysPulley {

  public CPhysPulley(nint handle) : base(handle) {
  }

  public CPhysPulley(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Position2 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDCB3A22333568F48));
  }
  public ISchemaFixedArray<Vector> Offset {
    get => new SchemaFixedArray<Vector>(_Handle + Schema.GetOffset(0xDCB3A223F836806A));
  }
  public ref float AddLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDCB3A223A30AA6D8));
  }
  public ref float GearRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDCB3A223DF6EB135));
  }


}
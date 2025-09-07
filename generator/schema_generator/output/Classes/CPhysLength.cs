using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysLength : CPhysConstraint, IPhysLength {

  public CPhysLength(nint handle) : base(handle) {
  }

  public CPhysLength(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<Vector> Offset {
    get => new SchemaFixedArray<Vector>(_Handle + Schema.GetOffset(0x9203A50AF836806A));
  }
  public ref Vector Attach {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9203A50A4CAEA9A4));
  }
  public ref float AddLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9203A50AA30AA6D8));
  }
  public ref float MinLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9203A50A8FD988D7));
  }
  public ref float TotalLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9203A50A6825671D));
  }
  public ref bool EnableCollision {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9203A50A1E5412CE));
  }


}
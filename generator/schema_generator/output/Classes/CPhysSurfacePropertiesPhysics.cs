using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysSurfacePropertiesPhysics : SchemaClass, IPhysSurfacePropertiesPhysics {

  public CPhysSurfacePropertiesPhysics(nint handle) : base(handle) {
  }

  public CPhysSurfacePropertiesPhysics(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Friction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF44ED88D5DBDE05B));
  }
  public ref float Elasticity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF44ED88DEFAD1ED4));
  }
  public ref float Density {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF44ED88D870F96BB));
  }
  public ref float Thickness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF44ED88D5B5FCC35));
  }
  public ref float SoftContactFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF44ED88D2103A65B));
  }
  public ref float SoftContactDampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF44ED88D1FD70102));
  }


}
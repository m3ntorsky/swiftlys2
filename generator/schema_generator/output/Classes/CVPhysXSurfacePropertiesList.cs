using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVPhysXSurfacePropertiesList : SchemaClass, IVPhysXSurfacePropertiesList {

  public CVPhysXSurfacePropertiesList(nint handle) : base(handle) {
  }

  public ref CUtlVector<PointerTo<CPhysSurfaceProperties>> SurfacePropertiesList {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CPhysSurfaceProperties>>>(Schema.GetOffset(0x46700CAAC149A2D));
  }


}
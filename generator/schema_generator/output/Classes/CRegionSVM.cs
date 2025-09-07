using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRegionSVM : SchemaClass, IRegionSVM {

  public CRegionSVM(nint handle) : base(handle) {
  }

  public CRegionSVM(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< RnPlane_t > Planes {
    get => ref _Handle.AsRef<CUtlVector< RnPlane_t >>(Schema.GetOffset(0xFC5717CAF831F452));
  }
  public ref CUtlVector< uint32 > Nodes {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0xFC5717CAEBA045DA));
  }


}
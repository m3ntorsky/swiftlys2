using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRegionSVM : SchemaClass, IRegionSVM {

  public CRegionSVM(nint handle) : base(handle) {
  }

  public ref CUtlVector Planes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xFC5717CAF831F452));
  }
  public ref CUtlVector<uint> Nodes {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0xFC5717CAEBA045DA));
  }


}
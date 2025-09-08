using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMorphData : SchemaClass, IMorphData {

  public CMorphData(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x603F8C4D8F5786));
  }
  public ref CUtlVector MorphRectDatas {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x603F8CB92C9674));
  }


}
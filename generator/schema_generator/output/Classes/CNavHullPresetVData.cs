using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavHullPresetVData : SchemaClass, INavHullPresetVData {

  public CNavHullPresetVData(nint handle) : base(handle) {
  }

  public ref CUtlVector<CUtlString> NavHulls {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0x9963D667366CCF96));
  }


}
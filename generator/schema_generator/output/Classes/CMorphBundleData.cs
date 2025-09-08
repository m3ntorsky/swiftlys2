using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMorphBundleData : SchemaClass, IMorphBundleData {

  public CMorphBundleData(nint handle) : base(handle) {
  }

  public ref float ULeftSrc {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8F3A47DCADC9D147));
  }
  public ref float VTopSrc {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8F3A47DCEF710ED0));
  }
  public ref CUtlVector<float> Offsets {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x8F3A47DCD6CBA75B));
  }
  public ref CUtlVector<float> Ranges {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x8F3A47DC24CF5F13));
  }


}
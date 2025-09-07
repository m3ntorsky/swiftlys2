using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSSDSEndFrameViewInfo : SchemaClass, ISSDSEndFrameViewInfo {

  public CSSDSEndFrameViewInfo(nint handle) : base(handle) {
  }

  public CSSDSEndFrameViewInfo(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ulong ViewId {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0xE2792496AE3CB1A1));
  }
  public ref CUtlString ViewName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xE2792496BA5BBDBB));
  }


}
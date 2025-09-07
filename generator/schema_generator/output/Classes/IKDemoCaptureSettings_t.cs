using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class IKDemoCaptureSettings_t : SchemaClass, IIKDemoCaptureSettings_t {

  public IKDemoCaptureSettings_t(nint handle) : base(handle) {
  }

  public IKDemoCaptureSettings_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString ParentBoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6D63001A95A4F804));
  }
  public ref IKChannelMode Mode {
    get => ref _Handle.AsRef<IKChannelMode>(Schema.GetOffset(0x6D63001A1050A633));
  }
  public ref CUtlString IkChainName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6D63001A50E152ED));
  }
  public ref CUtlString OneBoneStart {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6D63001A95ADD82F));
  }
  public ref CUtlString OneBoneEnd {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6D63001AE57D0DBA));
  }


}
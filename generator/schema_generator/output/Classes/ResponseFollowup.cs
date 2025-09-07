using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ResponseFollowup : SchemaClass, IResponseFollowup {

  public ResponseFollowup(nint handle) : base(handle) {
  }

  public ResponseFollowup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CString Followup_concept {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x6C93EDBE24539C9E));
  }
  public ref CString Followup_contexts {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x6C93EDBE5C4196A6));
  }
  public ref float Followup_delay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6C93EDBEC5E3BE49));
  }
  public ref CString Followup_target {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x6C93EDBEAD89F8D7));
  }
  public ref CString Followup_entityiotarget {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x6C93EDBEFF990A74));
  }
  public ref CString Followup_entityioinput {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x6C93EDBEAB6AD4B7));
  }
  public ref float Followup_entityiodelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6C93EDBE37A3C494));
  }
  public ref bool Fired {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6C93EDBE5ABF7B87));
  }


}
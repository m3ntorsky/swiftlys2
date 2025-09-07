using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPoseHandle : SchemaClass, IPoseHandle {

  public CPoseHandle(nint handle) : base(handle) {
  }

  public CPoseHandle(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort Index {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x2F05C439B73DBE67));
  }
  public ref PoseType_t Type {
    get => ref _Handle.AsRef<PoseType_t>(Schema.GetOffset(0x2F05C43921B39888));
  }


}
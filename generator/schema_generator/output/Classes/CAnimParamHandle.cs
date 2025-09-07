using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimParamHandle : SchemaClass, IAnimParamHandle {

  public CAnimParamHandle(nint handle) : base(handle) {
  }

  public CAnimParamHandle(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref AnimParamType_t Type {
    get => ref _Handle.AsRef<AnimParamType_t>(Schema.GetOffset(0x7B9461E0F04B4ED));
  }
  public ref byte Index {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x7B9461E491963CB));
  }


}
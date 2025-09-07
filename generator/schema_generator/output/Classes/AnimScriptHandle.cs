using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AnimScriptHandle : SchemaClass, IAnimScriptHandle {

  public AnimScriptHandle(nint handle) : base(handle) {
  }

  public AnimScriptHandle(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint Id {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x8A9EC535B4B6E980));
  }


}
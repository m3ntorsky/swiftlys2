using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AnimTagID : SchemaClass, IAnimTagID {

  public AnimTagID(nint handle) : base(handle) {
  }

  public AnimTagID(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint Id {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xCEE1E76DB4B6E980));
  }


}
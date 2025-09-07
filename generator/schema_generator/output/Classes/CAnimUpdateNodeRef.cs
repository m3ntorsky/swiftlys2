using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimUpdateNodeRef : SchemaClass, IAnimUpdateNodeRef {

  public CAnimUpdateNodeRef(nint handle) : base(handle) {
  }

  public CAnimUpdateNodeRef(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int NodeIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x71F7CF87E37313D3));
  }


}
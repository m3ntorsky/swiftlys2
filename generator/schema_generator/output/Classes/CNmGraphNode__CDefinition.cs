using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmGraphNode__CDefinition : SchemaClass, INmGraphNode__CDefinition {

  public CNmGraphNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmGraphNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short NodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x97FBD3EF124AB5CC));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ResourceId_t : SchemaClass, IResourceId_t {

  public ResourceId_t(nint handle) : base(handle) {
  }

  public ref ulong Value {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0x21F7998BDCB0894A));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AggregateVertexAlbedoStreamOnDiskData_t : SchemaClass, IAggregateVertexAlbedoStreamOnDiskData_t {

  public AggregateVertexAlbedoStreamOnDiskData_t(nint handle) : base(handle) {
  }

  public AggregateVertexAlbedoStreamOnDiskData_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlBinaryBlock BufferData {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0x2C9A1CB4ED884C43));
  }


}
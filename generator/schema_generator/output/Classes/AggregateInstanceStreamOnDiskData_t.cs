using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AggregateInstanceStreamOnDiskData_t : SchemaClass, IAggregateInstanceStreamOnDiskData_t {

  public AggregateInstanceStreamOnDiskData_t(nint handle) : base(handle) {
  }

  public AggregateInstanceStreamOnDiskData_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint DecodedSize {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x8EDB1298803205A0));
  }
  public ref CUtlBinaryBlock BufferData {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0x8EDB1298ED884C43));
  }


}
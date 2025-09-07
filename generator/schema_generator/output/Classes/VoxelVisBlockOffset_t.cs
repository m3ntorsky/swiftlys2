using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VoxelVisBlockOffset_t : SchemaClass, IVoxelVisBlockOffset_t {

  public VoxelVisBlockOffset_t(nint handle) : base(handle) {
  }

  public VoxelVisBlockOffset_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint Offset {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x17D2B49827734C8E));
  }
  public ref uint ElementCount {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x17D2B49851A2EF12));
  }


}
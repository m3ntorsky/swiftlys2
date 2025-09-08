using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class WorldNodeOnDiskBufferData_t : SchemaClass, IWorldNodeOnDiskBufferData_t {

  public WorldNodeOnDiskBufferData_t(nint handle) : base(handle) {
  }

  public ref int ElementCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC4F557DA51A2EF12));
  }
  public ref int ElementSizeInBytes {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC4F557DAF602975C));
  }
  public ref CUtlVector InputLayoutFields {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xC4F557DAFDECA2D8));
  }
  public ref CUtlVector<byte> Data {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0xC4F557DA27938BB7));
  }


}
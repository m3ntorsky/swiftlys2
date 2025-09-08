using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMeshletDescriptor : SchemaClass, IMeshletDescriptor {

  public CMeshletDescriptor(nint handle) : base(handle) {
  }

  public IPackedAABB_t PackedAABB {
    get => new PackedAABB_t(_Handle + Schema.GetOffset(0xAF93495D8D638233));
  }
  public IDrawCullingData CullingData {
    get => new CDrawCullingData(_Handle + Schema.GetOffset(0xAF93495DA6D54DC3));
  }
  public ref uint VertexOffset {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xAF93495DF1F6FC40));
  }
  public ref uint TriangleOffset {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xAF93495DAFE22CE6));
  }
  public ref byte VertexCount {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xAF93495D12923E12));
  }
  public ref byte TriangleCount {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xAF93495D5E82E240));
  }


}
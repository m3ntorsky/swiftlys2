using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMaterialDrawDescriptor__RigidMeshPart_t : SchemaClass, IMaterialDrawDescriptor__RigidMeshPart_t {

  public CMaterialDrawDescriptor__RigidMeshPart_t(nint handle) : base(handle) {
  }

  public ref ushort RigidBLASIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xD375EED8EE87873E));
  }
  public ref short BoneIndex {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xD375EED89F407B79));
  }
  public ref uint StartIndexOffset {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xD375EED891EF1626));
  }
  public ref uint PrimitiveCount {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xD375EED8B627A621));
  }


}
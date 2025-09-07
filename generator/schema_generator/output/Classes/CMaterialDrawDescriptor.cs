using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMaterialDrawDescriptor : SchemaClass, IMaterialDrawDescriptor {

  public CMaterialDrawDescriptor(nint handle) : base(handle) {
  }

  public CMaterialDrawDescriptor(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float UvDensity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE7C21000A7661B68));
  }
  public ref Vector TintColor {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE7C2100050AFF21F));
  }
  public ref float Alpha {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE7C21000A0DB7DD1));
  }
  public ref ushort NumMeshlets {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xE7C21000A56D0338));
  }
  public ref uint FirstMeshlet {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xE7C210006DA99901));
  }
  public ref uint AppliedIndexOffset {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xE7C21000A24FA35D));
  }
  public ref byte DepthVertexBufferIndex {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xE7C2100049292FE2));
  }
  public ref byte MeshletPackedIVBIndex {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xE7C21000A98C8BAC));
  }
  public ref CUtlLeanVector< CMaterialDrawDescriptor::RigidMeshPart_t > RigidMeshParts {
    get => ref _Handle.AsRef<CUtlLeanVector< CMaterialDrawDescriptor::RigidMeshPart_t >>(Schema.GetOffset(0xE7C2100062848C01));
  }
  public ref RenderPrimitiveType_t PrimitiveType {
    get => ref _Handle.AsRef<RenderPrimitiveType_t>(Schema.GetOffset(0xE7C2100041517C4A));
  }
  public ref int BaseVertex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7C2100048F55CFA));
  }
  public ref int VertexCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7C2100012923E12));
  }
  public ref int StartIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7C210008A0ACD99));
  }
  public ref int IndexCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7C21000B0202EFE));
  }
  public IRenderBufferBinding IndexBuffer {
    get => new CRenderBufferBinding(_Handle + Schema.GetOffset(0xE7C210003C0C2701));
  }
  public IRenderBufferBinding MeshletPackedIVB {
    get => new CRenderBufferBinding(_Handle + Schema.GetOffset(0xE7C21000015D34E4));
  }
  public ref CStrongHandle< InfoForResourceTypeIMaterial2 > Material {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0xE7C2100034ADFC00));
  }


}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialDrawDescriptor : ISchemaClass {

  
  public ref float UvDensity { get; }
  
  public ref Vector TintColor { get; }
  
  public ref float Alpha { get; }
  
  public ref ushort NumMeshlets { get; }
  
  public ref uint FirstMeshlet { get; }
  
  public ref uint AppliedIndexOffset { get; }
  
  public ref byte DepthVertexBufferIndex { get; }
  
  public ref byte MeshletPackedIVBIndex { get; }
  
  public ISchemaUntypedField RigidMeshParts { get; }
  
  public ref RenderPrimitiveType_t PrimitiveType { get; }
  
  public ref int BaseVertex { get; }
  
  public ref int VertexCount { get; }
  
  public ref int StartIndex { get; }
  
  public ref int IndexCount { get; }
  
  public IRenderBufferBinding IndexBuffer { get; }
  
  public IRenderBufferBinding MeshletPackedIVB { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material { get; }
}
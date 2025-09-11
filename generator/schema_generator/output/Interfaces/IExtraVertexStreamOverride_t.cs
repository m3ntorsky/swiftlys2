using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IExtraVertexStreamOverride_t : IBaseSceneObjectOverride_t {

  
  public ref uint SubSceneObject { get; }
  
  public ref uint DrawCallIndex { get; }
  
  public ref MeshDrawPrimitiveFlags_t AdditionalMeshDrawPrimitiveFlags { get; }
  
  public IRenderBufferBinding ExtraBufferBinding { get; }
}
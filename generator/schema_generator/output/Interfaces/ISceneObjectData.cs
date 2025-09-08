using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISceneObjectData : ISchemaClass {

  public ref Vector MinBounds { get; }
  
  public ref Vector MaxBounds { get; }
  
  public ref CUtlLeanVector<CMaterialDrawDescriptor> DrawCalls { get; }
  
  public ref CUtlLeanVector<AABB_t> DrawBounds { get; }
  
  public ref CUtlLeanVector<CMeshletDescriptor> Meshlets { get; }
  
  public ref Vector4D TintColor { get; }
  
}
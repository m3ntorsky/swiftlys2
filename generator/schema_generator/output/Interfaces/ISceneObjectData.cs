using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISceneObjectData : ISchemaClass {

  
  public ref Vector MinBounds { get; }
  
  public ref Vector MaxBounds { get; }
  
  public ISchemaUntypedField DrawCalls { get; }
  
  public ISchemaUntypedField DrawBounds { get; }
  
  public ISchemaUntypedField Meshlets { get; }
  
  public ref Vector4D TintColor { get; }
}
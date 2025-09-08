using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameSceneNodeHandle : ISchemaClass {

  public ref CEntityHandle Owner { get; }
  
  public ref CUtlStringToken Name { get; }
  
}
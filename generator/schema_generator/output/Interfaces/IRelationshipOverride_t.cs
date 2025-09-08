using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRelationshipOverride_t : IRelationship_t {

  public CHandle<IBaseEntity> Entity { get; }
  
  public ref Class_T ClassType { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRelativeLocation : ISchemaClass {

  
  public ref RelativeLocationType_t Type { get; }
  
  public ref Vector RelativeOffset { get; }
  
  public ref Vector WorldSpacePos { get; }
  
  public ref CHandle<CBaseEntity> Entity { get; }
}
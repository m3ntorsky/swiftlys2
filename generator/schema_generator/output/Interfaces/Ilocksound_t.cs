using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Ilocksound_t : ISchemaClass {

  
  public ISchemaUntypedField LockedSound { get; }
  
  public ISchemaUntypedField UnlockedSound { get; }
  
  public IGameTime_t FlwaitSound { get; }
}
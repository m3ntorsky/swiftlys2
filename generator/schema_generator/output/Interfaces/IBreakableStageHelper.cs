using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBreakableStageHelper : ISchemaClass {

  
  public ref int CurrentStage { get; }
  
  public ref int StageCount { get; }
}
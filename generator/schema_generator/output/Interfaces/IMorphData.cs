using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMorphData : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
// CUtlVector< CMorphRectData >
  public ref CUtlVector MorphRectDatas { get; }
}
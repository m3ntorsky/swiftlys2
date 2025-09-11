using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFlexController : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref CUtlString Type { get; }
  
  public ref float Min { get; }
  
  public ref float Max { get; }
}
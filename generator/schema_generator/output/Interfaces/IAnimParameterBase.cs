using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimParameterBase : ISchemaClass {

  public ref CGlobalSymbol Name { get; }
  
  public ref CUtlString Comment { get; }
  
  public ref CUtlString Group { get; }
  
  public IAnimParamID Id { get; }
  
  public ref CUtlString ComponentName { get; }
  
  public ref bool NetworkingRequested { get; }
  
  public ref bool IsReferenced { get; }
  
}
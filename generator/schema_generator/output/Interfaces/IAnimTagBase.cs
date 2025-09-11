using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimTagBase : ISchemaClass {

  
  public ref CGlobalSymbol Name { get; }
  
  public ref CUtlString Comment { get; }
  
  public ref CGlobalSymbol Group { get; }
  
  public IAnimTagID TagID { get; }
  
  public ref bool IsReferenced { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITagSpan_t : ISchemaClass {

  public ref int TagIndex { get; }
  
  public ref float StartCycle { get; }
  
  public ref float EndCycle { get; }
  
}
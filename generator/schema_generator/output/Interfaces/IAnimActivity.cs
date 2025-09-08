using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimActivity : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public ref int Activity { get; }
  
  public ref int Flags { get; }
  
  public ref int Weight { get; }
  
}
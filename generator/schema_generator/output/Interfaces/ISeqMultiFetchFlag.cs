using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqMultiFetchFlag : ISchemaClass {

  
  public ref bool Realtime { get; }
  
  public ref bool Cylepose { get; }
  
  public ref bool B0D { get; }
  
  public ref bool B1D { get; }
  
  public ref bool B2D { get; }
  
  public ref bool B2D_TRI { get; }
}
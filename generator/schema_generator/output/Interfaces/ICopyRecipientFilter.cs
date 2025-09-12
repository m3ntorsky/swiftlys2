using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICopyRecipientFilter : ISchemaClass {

  
  public ref int Flags { get; }
  
  public ref CUtlVector<uint> Recipients { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IResponseParams : ISchemaClass {

  public ref short Odds { get; }
  
  public ref short Flags { get; }
  
  public IResponseFollowup Followup { get; }
  
}
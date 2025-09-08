using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixOscDesc_t : ISchemaClass {

  public ref VMixLFOShape_t OscType { get; }
  
  public ref float Freq { get; }
  
  public ref float Phase { get; }
  
}
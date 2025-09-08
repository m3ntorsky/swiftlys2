using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixAutoFilterDesc_t : ISchemaClass {

  public ref float EnvelopeAmount { get; }
  
  public ref float AttackTimeMS { get; }
  
  public ref float ReleaseTimeMS { get; }
  
  public IVMixFilterDesc_t Filter { get; }
  
  public ref float LFOAmount { get; }
  
  public ref float LFORate { get; }
  
  public ref float Phase { get; }
  
  public ref VMixLFOShape_t LFOShape { get; }
  
}
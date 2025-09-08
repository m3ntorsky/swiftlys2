using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixDynamicsBand_t : ISchemaClass {

  public ref float FldbGainInput { get; }
  
  public ref float FldbGainOutput { get; }
  
  public ref float FldbThresholdBelow { get; }
  
  public ref float FldbThresholdAbove { get; }
  
  public ref float RatioBelow { get; }
  
  public ref float RatioAbove { get; }
  
  public ref float AttackTimeMS { get; }
  
  public ref float ReleaseTimeMS { get; }
  
  public ref bool Enable { get; }
  
  public ref bool Solo { get; }
  
}
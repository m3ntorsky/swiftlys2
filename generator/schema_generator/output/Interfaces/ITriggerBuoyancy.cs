using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerBuoyancy : IBaseTrigger {

  
  public IBuoyancyHelper BuoyancyHelper { get; }
  
  public ref float FluidDensity { get; }
}
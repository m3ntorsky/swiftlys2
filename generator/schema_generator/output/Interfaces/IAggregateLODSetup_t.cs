using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAggregateLODSetup_t : ISchemaClass {

  public ref Vector LODOrigin { get; }
  
  public ref float MaxObjectScale { get; }
  
  public ref CUtlVector<float> SwitchDistances { get; }
  
}
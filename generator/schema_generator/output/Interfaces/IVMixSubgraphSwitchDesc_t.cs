using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixSubgraphSwitchDesc_t : ISchemaClass {

  
  public ref VMixSubgraphSwitchInterpolationType_t InterpolationMode { get; }
  
  public ref bool OnlyTailsOnFadeOut { get; }
  
  public ref float InterpolationTime { get; }
}
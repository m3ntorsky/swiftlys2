using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleControlPointConfiguration_t : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref CUtlVector Drivers { get; }
  
  public IParticlePreviewState_t PreviewState { get; }
  
}
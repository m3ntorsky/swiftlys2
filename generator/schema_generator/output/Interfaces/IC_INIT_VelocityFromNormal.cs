using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_VelocityFromNormal : IParticleFunctionInitializer {

  
  public ref float SpeedMin { get; }
  
  public ref float SpeedMax { get; }
  
  public ref bool IgnoreDt { get; }
}
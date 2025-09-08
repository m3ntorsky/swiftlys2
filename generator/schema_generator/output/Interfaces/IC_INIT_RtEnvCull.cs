using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RtEnvCull : IParticleFunctionInitializer {

  public ref Vector TestDir { get; }
  
  public ref Vector TestNormal { get; }
  
  public ref bool UseVelocity { get; }
  
  public ref bool CullOnMiss { get; }
  
  public ref bool LifeAdjust { get; }
  
  public ISchemaFixedString RtEnvName { get; }
  
  public ref int RTEnvCP { get; }
  
  public ref int Component { get; }
  
}
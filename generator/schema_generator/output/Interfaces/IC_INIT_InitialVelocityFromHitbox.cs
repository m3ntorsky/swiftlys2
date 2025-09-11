using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitialVelocityFromHitbox : IParticleFunctionInitializer {

  
  public ref float VelocityMin { get; }
  
  public ref float VelocityMax { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
  public ref bool UseBones { get; }
}
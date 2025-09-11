using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_ModelCull : IParticleFunctionInitializer {

  
  public ref int ControlPointNumber { get; }
  
  public ref bool BoundBox { get; }
  
  public ref bool CullOutside { get; }
  
  public ref bool UseBones { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
}
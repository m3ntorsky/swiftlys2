using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Iconstraint_breakableparams_t : ISchemaClass {

  
  public ref float Strength { get; }
  
  public ref float ForceLimit { get; }
  
  public ref float TorqueLimit { get; }
  
  public ISchemaFixedArray<float> BodyMassScale { get; }
  
  public ref bool IsActive { get; }
}
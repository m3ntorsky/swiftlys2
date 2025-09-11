using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointPositionToTimeOfDayValue : IParticleFunctionPreEmission {

  
  public ref int ControlPointNumber { get; }
  
  public ISchemaFixedString TimeOfDayParameter { get; }
  
  public ref Vector DefaultValue { get; }
}
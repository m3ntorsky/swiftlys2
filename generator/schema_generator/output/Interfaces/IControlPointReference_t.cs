using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IControlPointReference_t : ISchemaClass {

  public ref int ControlPointNameString { get; }
  
  public ref Vector OffsetFromControlPoint { get; }
  
  public ref bool OffsetInLocalSpace { get; }
  
}
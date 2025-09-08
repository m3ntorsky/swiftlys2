using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Iconstraint_hingeparams_t : ISchemaClass {

  public ref Vector WorldPosition { get; }
  
  public ref Vector WorldAxisDirection { get; }
  
  public Iconstraint_axislimit_t HingeAxis { get; }
  
  public Iconstraint_breakableparams_t Constraint { get; }
  
}
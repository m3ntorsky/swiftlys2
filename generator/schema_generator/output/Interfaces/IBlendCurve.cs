using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBlendCurve : ISchemaClass {

  public ref float ControlPoint1 { get; }
  
  public ref float ControlPoint2 { get; }
  
}
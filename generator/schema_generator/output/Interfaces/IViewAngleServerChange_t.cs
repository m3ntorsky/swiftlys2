using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IViewAngleServerChange_t : ISchemaClass {

  
  public ref FixAngleSet_t Type { get; }
  
  public ref QAngle Angle { get; }
  
  public ref uint Index { get; }
}
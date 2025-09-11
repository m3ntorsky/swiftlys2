using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIKEffector : ISchemaClass {

  
  public ref int BodyIndex { get; }
  
  public ref bool Enabled { get; }
  
  public ref Vector TargetPosition { get; }
  
  public ref Quaternion TargetOrientation { get; }
  
  public ref float Weight { get; }
}
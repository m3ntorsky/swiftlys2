using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIKJoint : ISchemaClass {

  public ref int ParentIndex { get; }
  
  public ref int BodyIndex { get; }
  
  public ref CTransform XLocalFrame { get; }
  
  public ref float SwingLimit { get; }
  
  public ref float MinTwistLimit { get; }
  
  public ref float MaxTwistLimit { get; }
  
  public ref float Weight { get; }
  
}
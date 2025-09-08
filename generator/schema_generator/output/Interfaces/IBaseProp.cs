using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseProp : IBaseAnimGraph {

  public ref bool ModelOverrodeBlockLOS { get; }
  
  public ref int ShapeType { get; }
  
  public ref bool ConformToCollisionBounds { get; }
  
  public ref CTransform MPreferredCatchTransform { get; }
  
}
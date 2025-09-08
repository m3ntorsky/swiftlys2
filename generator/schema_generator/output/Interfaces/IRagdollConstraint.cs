using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollConstraint : IPhysConstraint {

  public ref float Xmin { get; }
  
  public ref float Xmax { get; }
  
  public ref float Ymin { get; }
  
  public ref float Ymax { get; }
  
  public ref float Zmin { get; }
  
  public ref float Zmax { get; }
  
  public ref float Xfriction { get; }
  
  public ref float Yfriction { get; }
  
  public ref float Zfriction { get; }
  
}
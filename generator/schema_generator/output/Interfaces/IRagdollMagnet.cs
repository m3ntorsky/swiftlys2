using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollMagnet : IPointEntity {

  
  public ref bool Disabled { get; }
  
  public ref float Radius { get; }
  
  public ref float Force { get; }
  
  public ref Vector Axis { get; }
}
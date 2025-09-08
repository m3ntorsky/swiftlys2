using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IOmniLight : IBarnLight {

  public ref float InnerAngle { get; }
  
  public ref float OuterAngle { get; }
  
  public ref bool ShowLight { get; }
  
}
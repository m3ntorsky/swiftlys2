using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMarkupVolumeTagged_NavGame : IMarkupVolumeWithRef {

  public ref NavScopeFlags_t Scopes { get; }
  
  public ref bool FloodFillAttribute { get; }
  
  public ref bool SplitNavSpace { get; }
  
}
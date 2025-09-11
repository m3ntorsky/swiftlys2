using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWarpSectionAnimTag : IWarpSectionAnimTagBase {

  
  public ref bool WarpPosition { get; }
  
  public ref bool WarpOrientation { get; }
}
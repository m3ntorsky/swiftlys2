using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavVolumeBreadthFirstSearch : INavVolumeCalculatedVector {

  public ref Vector StartPos { get; }
  
  public ref float SearchDist { get; }
  
}
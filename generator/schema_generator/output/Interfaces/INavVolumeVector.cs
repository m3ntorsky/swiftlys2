using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavVolumeVector : INavVolume {

  
  public ref bool HasBeenPreFiltered { get; }
}
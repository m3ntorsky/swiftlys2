using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavVolumeSphericalShell : INavVolumeSphere {

  public ref float RadiusInner { get; }
  
}
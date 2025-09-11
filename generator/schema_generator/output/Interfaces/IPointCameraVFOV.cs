using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointCameraVFOV : IPointCamera {

  
  public ref float VerticalFOV { get; }
}
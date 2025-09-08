using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointCameraSettings_t : ISchemaClass {

  public ref float NearBlurryDistance { get; }
  
  public ref float NearCrispDistance { get; }
  
  public ref float FarCrispDistance { get; }
  
  public ref float FarBlurryDistance { get; }
  
}
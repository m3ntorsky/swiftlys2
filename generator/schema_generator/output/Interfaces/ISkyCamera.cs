using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkyCamera : IBaseEntity {

  
  public Isky3dparams_t SkyboxData { get; }
  
  public ref CUtlStringToken SkyboxSlotToken { get; }
  
  public ref bool UseAngles { get; }
  
  public ISkyCamera Next { get; }
}
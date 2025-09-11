using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsPropRespawnable : IPhysicsProp {

  
  public ref Vector OriginalSpawnOrigin { get; }
  
  public ref QAngle OriginalSpawnAngles { get; }
  
  public ref Vector OriginalMins { get; }
  
  public ref Vector OriginalMaxs { get; }
  
  public ref float RespawnDuration { get; }
}
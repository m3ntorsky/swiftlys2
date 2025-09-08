using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointTeleport : IServerOnlyPointEntity {

  public ref Vector SaveOrigin { get; }
  
  public ref QAngle SaveAngles { get; }
  
  public ref bool TeleportParentedEntities { get; }
  
  public ref bool TeleportUseCurrentAngle { get; }
  
}
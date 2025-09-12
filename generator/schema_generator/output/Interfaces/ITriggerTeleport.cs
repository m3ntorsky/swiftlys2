using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerTeleport : IBaseTrigger {

  
  public ISchemaUntypedField Landmark { get; }
  
  public ref bool UseLandmarkAngles { get; }
  
  public ref bool MirrorPlayer { get; }
  
  public ref bool CheckDestIfClearForPlayer { get; }
}
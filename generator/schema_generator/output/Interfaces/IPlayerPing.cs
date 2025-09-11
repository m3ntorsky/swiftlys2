using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayerPing : IBaseEntity {

  
  public ref CHandle<CCSPlayerPawn> Player { get; }
  
  public ref CHandle<CBaseEntity> PingedEntity { get; }
  
  public ref int Type { get; }
  
  public ref bool Urgent { get; }
  
  public ISchemaFixedString PlaceName { get; }
}
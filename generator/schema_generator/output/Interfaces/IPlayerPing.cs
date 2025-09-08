using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayerPing : IBaseEntity {

  public CHandle<ICSPlayerPawn> Player { get; }
  
  public CHandle<IBaseEntity> PingedEntity { get; }
  
  public ref int Type { get; }
  
  public ref bool Urgent { get; }
  
  public ISchemaFixedString PlaceName { get; }
  
}
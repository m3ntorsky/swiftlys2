using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITeam : IBaseEntity {

  public ref CUtlVector<CHandle<CBasePlayerController>> PlayerControllers { get; }
  
  public ref CUtlVector<CHandle<CBasePlayerPawn>> Players { get; }
  
  public ref int Score { get; }
  
  public ISchemaFixedString Teamname { get; }
  
}
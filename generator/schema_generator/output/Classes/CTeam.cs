using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTeam : CBaseEntity, ITeam {

  public CTeam(nint handle) : base(handle) {
  }

  public CTeam(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CHandle< CBasePlayerController > > PlayerControllers {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CBasePlayerController > >>(Schema.GetOffset(0xAF5A77E38933E302));
  }
  public ref CUtlVector< CHandle< CBasePlayerPawn > > Players {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CBasePlayerPawn > >>(Schema.GetOffset(0xAF5A77E307285116));
  }
  public ref int Score {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAF5A77E339E7DEAE));
  }
  public ISchemaFixedString Teamname {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xAF5A77E3AA34880A));
  }

  public void PlayerControllersUpdated() {
    Schema.Update(_Handle, 0xAF5A77E38933E302);
  }
  public void PlayersUpdated() {
    Schema.Update(_Handle, 0xAF5A77E307285116);
  }
  public void ScoreUpdated() {
    Schema.Update(_Handle, 0xAF5A77E339E7DEAE);
  }
  public void TeamnameUpdated() {
    Schema.Update(_Handle, 0xAF5A77E3AA34880A);
  }
}
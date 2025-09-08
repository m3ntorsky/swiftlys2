using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTeam : CBaseEntity, ITeam {

  public CTeam(nint handle) : base(handle) {
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
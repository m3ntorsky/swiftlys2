using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRetakeGameRules : SchemaClass, IRetakeGameRules {

  public CRetakeGameRules(nint handle) : base(handle) {
  }



  public void MatchSeedUpdated() {
    Schema.Update(_Handle, 0x34813D492DE0044B);
  }
  public void BlockersPresentUpdated() {
    Schema.Update(_Handle, 0x34813D49BE2F2F2D);
  }
  public void RoundInProgressUpdated() {
    Schema.Update(_Handle, 0x34813D49AE69021B);
  }
  public void FirstSecondHalfRoundUpdated() {
    Schema.Update(_Handle, 0x34813D49E229A099);
  }
  public void BombSiteUpdated() {
    Schema.Update(_Handle, 0x34813D49E7E88ECF);
  }
}
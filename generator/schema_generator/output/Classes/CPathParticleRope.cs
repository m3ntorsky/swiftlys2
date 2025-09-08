using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathParticleRope : CBaseEntity, IPathParticleRope {

  public CPathParticleRope(nint handle) : base(handle) {
  }

  public ref bool StartActive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC0C741B953CBC21));
  }
  public ref float MaxSimulationTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBC0C741B80F036E5));
  }
  public ref CUtlSymbolLarge EffectName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xBC0C741B82D2BFC7));
  }
  public ref CUtlVector<CUtlSymbolLarge> PathNodes_Name {
    get => ref _Handle.AsRef<CUtlVector<CUtlSymbolLarge>>(Schema.GetOffset(0xBC0C741BFFAFA92F));
  }

  public void ParticleSpacingUpdated() {
    Schema.Update(_Handle, 0xBC0C741B66CCF542);
  }
  public void SlackUpdated() {
    Schema.Update(_Handle, 0xBC0C741B183285C9);
  }
  public void RadiusUpdated() {
    Schema.Update(_Handle, 0xBC0C741B5ACFC08D);
  }
  public void ColorTintUpdated() {
    Schema.Update(_Handle, 0xBC0C741BD55CDDFD);
  }
  public void EffectStateUpdated() {
    Schema.Update(_Handle, 0xBC0C741B4188A2AD);
  }
  public void EffectIndexUpdated() {
    Schema.Update(_Handle, 0xBC0C741B3C93DC73);
  }
  public void PathNodes_PositionUpdated() {
    Schema.Update(_Handle, 0xBC0C741BC84253C7);
  }
  public void PathNodes_TangentInUpdated() {
    Schema.Update(_Handle, 0xBC0C741B4CEA7F8E);
  }
  public void PathNodes_TangentOutUpdated() {
    Schema.Update(_Handle, 0xBC0C741B218FA6AF);
  }
  public void PathNodes_ColorUpdated() {
    Schema.Update(_Handle, 0xBC0C741B6DB8C1DB);
  }
  public void PathNodes_PinEnabledUpdated() {
    Schema.Update(_Handle, 0xBC0C741B830E8AD8);
  }
  public void PathNodes_RadiusScaleUpdated() {
    Schema.Update(_Handle, 0xBC0C741B593CB340);
  }
}
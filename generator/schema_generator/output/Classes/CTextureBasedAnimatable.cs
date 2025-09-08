using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTextureBasedAnimatable : CBaseModelEntity, ITextureBasedAnimatable {

  public CTextureBasedAnimatable(nint handle) : base(handle) {
  }



  public void LoopUpdated() {
    Schema.Update(_Handle, 0xDB45ABACC668A4CB);
  }
  public void FPSUpdated() {
    Schema.Update(_Handle, 0xDB45ABAC38CAA4F6);
  }
  public void PositionKeysUpdated() {
    Schema.Update(_Handle, 0xDB45ABACE6515850);
  }
  public void RotationKeysUpdated() {
    Schema.Update(_Handle, 0xDB45ABACDAC30C39);
  }
  public void AnimationBoundsMinUpdated() {
    Schema.Update(_Handle, 0xDB45ABAC8BDB4B58);
  }
  public void AnimationBoundsMaxUpdated() {
    Schema.Update(_Handle, 0xDB45ABACA1EEF5B2);
  }
  public void StartTimeUpdated() {
    Schema.Update(_Handle, 0xDB45ABAC67FE9DC4);
  }
  public void StartFrameUpdated() {
    Schema.Update(_Handle, 0xDB45ABACB534B906);
  }
}
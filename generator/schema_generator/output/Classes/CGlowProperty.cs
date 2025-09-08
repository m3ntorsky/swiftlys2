using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGlowProperty : SchemaClass, IGlowProperty {

  public CGlowProperty(nint handle) : base(handle) {
  }

  public ref Vector GlowColor {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x3ABE6F3E15CEA997));
  }
  public ref bool Glowing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3ABE6F3E3DEA07DC));
  }

  public void GlowTypeUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3E0600E8DD);
  }
  public void GlowTeamUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3E34FAFCDC);
  }
  public void GlowRangeUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3ED03F97ED);
  }
  public void GlowRangeMinUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3EA28EDB1F);
  }
  public void GlowColorOverrideUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3E50C6E26B);
  }
  public void FlashingUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3EB646AC57);
  }
  public void GlowTimeUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3E11622DBB);
  }
  public void GlowStartTimeUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3E411532C3);
  }
  public void EligibleForScreenHighlightUpdated() {
    Schema.Update(_Handle, 0x3ABE6F3E23B89FB9);
  }
}
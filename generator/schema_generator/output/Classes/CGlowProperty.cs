using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGlowProperty : SchemaClass, IGlowProperty {

  public CGlowProperty(nint handle) : base(handle) {
  }

  public CGlowProperty(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector GlowColor {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x3ABE6F3E15CEA997));
  }
  public ref int GlowType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3ABE6F3E0600E8DD));
  }
  public ref int GlowTeam {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3ABE6F3E34FAFCDC));
  }
  public ref int GlowRange {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3ABE6F3ED03F97ED));
  }
  public ref int GlowRangeMin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3ABE6F3EA28EDB1F));
  }
  public ref Color GlowColorOverride {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x3ABE6F3E50C6E26B));
  }
  public ref bool Flashing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3ABE6F3EB646AC57));
  }
  public ref float GlowTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3ABE6F3E11622DBB));
  }
  public ref float GlowStartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3ABE6F3E411532C3));
  }
  public ref bool EligibleForScreenHighlight {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3ABE6F3E23B89FB9));
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
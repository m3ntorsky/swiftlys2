using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEconEntity : CBaseFlex, IEconEntity {

  public CEconEntity(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> OldProvidee {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0xCD91F684289C89E0));
  }
  public ref int OldOwnerClass {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xCD91F684D62FABE8));
  }

  public void AttributeManagerUpdated() {
    Schema.Update(_Handle, 0xCD91F684537B0586);
  }
  public void OriginalOwnerXuidLowUpdated() {
    Schema.Update(_Handle, 0xCD91F6843C990CE3);
  }
  public void OriginalOwnerXuidHighUpdated() {
    Schema.Update(_Handle, 0xCD91F6842628947F);
  }
  public void FallbackPaintKitUpdated() {
    Schema.Update(_Handle, 0xCD91F6840A12D48F);
  }
  public void FallbackSeedUpdated() {
    Schema.Update(_Handle, 0xCD91F684A1B165B2);
  }
  public void FallbackWearUpdated() {
    Schema.Update(_Handle, 0xCD91F68486253266);
  }
  public void FallbackStatTrakUpdated() {
    Schema.Update(_Handle, 0xCD91F68467ECC1E7);
  }
}
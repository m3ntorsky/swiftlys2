using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CColorCorrection : CBaseEntity, IColorCorrection {

  public CColorCorrection(nint handle) : base(handle) {
  }

  public ref float StartFadeInWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x86645E11E12AF000));
  }
  public ref float StartFadeOutWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x86645E118757D4F9));
  }
  public IGameTime_t TimeStartFadeIn {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x86645E1175A6B4B7));
  }
  public IGameTime_t TimeStartFadeOut {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x86645E118028C93C));
  }
  public ref bool StartDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x86645E1161ED0C4F));
  }
  public ref CUtlSymbolLarge LookupFilename {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x86645E112611A2C6));
  }

  public void FadeInDurationUpdated() {
    Schema.Update(_Handle, 0x86645E1101B5EB8E);
  }
  public void FadeOutDurationUpdated() {
    Schema.Update(_Handle, 0x86645E11543512CF);
  }
  public void MaxWeightUpdated() {
    Schema.Update(_Handle, 0x86645E1155F00F23);
  }
  public void EnabledUpdated() {
    Schema.Update(_Handle, 0x86645E116154EB7E);
  }
  public void MasterUpdated() {
    Schema.Update(_Handle, 0x86645E115AFF9193);
  }
  public void ClientSideUpdated() {
    Schema.Update(_Handle, 0x86645E116B28362D);
  }
  public void ExclusiveUpdated() {
    Schema.Update(_Handle, 0x86645E11D84BE6BB);
  }
  public void MinFalloffUpdated() {
    Schema.Update(_Handle, 0x86645E116628F1F3);
  }
  public void MaxFalloffUpdated() {
    Schema.Update(_Handle, 0x86645E118837D7E1);
  }
  public void CurWeightUpdated() {
    Schema.Update(_Handle, 0x86645E112EA7ED7F);
  }
  public void NetlookupFilenameUpdated() {
    Schema.Update(_Handle, 0x86645E11543AB1EB);
  }
}
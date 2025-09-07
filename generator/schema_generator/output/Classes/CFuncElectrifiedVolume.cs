using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncElectrifiedVolume : CFuncBrush, IFuncElectrifiedVolume {

  public CFuncElectrifiedVolume(nint handle) : base(handle) {
  }

  public CFuncElectrifiedVolume(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge EffectName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x51A0E59866CD81EF));
  }
  public ref CUtlSymbolLarge EffectInterpenetrateName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x51A0E5987691FB19));
  }
  public ref CUtlSymbolLarge EffectZapName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x51A0E598BE142B78));
  }
  public ref CUtlSymbolLarge EffectSource {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x51A0E598300F4ED9));
  }

  public void EffectNameUpdated() {
    Schema.Update(_Handle, 0x51A0E59866CD81EF);
  }
}
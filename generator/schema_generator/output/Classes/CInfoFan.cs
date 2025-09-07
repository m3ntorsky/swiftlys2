using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoFan : CPointEntity, IInfoFan {

  public CInfoFan(nint handle) : base(handle) {
  }

  public CInfoFan(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FanForceMaxRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1372EEA33EA45A67));
  }
  public ref float FanForceMinRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1372EEA352CA71C5));
  }
  public ref float CurveDistRange {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1372EEA3EE91456F));
  }
  public ref CUtlSymbolLarge FanForceCurveString {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1372EEA3CC493A61));
  }

  public void FanForceMaxRadiusUpdated() {
    Schema.Update(_Handle, 0x1372EEA33EA45A67);
  }
  public void FanForceMinRadiusUpdated() {
    Schema.Update(_Handle, 0x1372EEA352CA71C5);
  }
  public void CurveDistRangeUpdated() {
    Schema.Update(_Handle, 0x1372EEA3EE91456F);
  }
  public void FanForceCurveStringUpdated() {
    Schema.Update(_Handle, 0x1372EEA3CC493A61);
  }
}
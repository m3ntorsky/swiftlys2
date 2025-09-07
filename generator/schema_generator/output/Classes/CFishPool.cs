using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFishPool : CBaseEntity, IFishPool {

  public CFishPool(nint handle) : base(handle) {
  }

  public CFishPool(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int FishCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1B71368A31165D02));
  }
  public ref float MaxRange {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1B71368A560879E6));
  }
  public ref float SwimDepth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1B71368AA94321F2));
  }
  public ref float WaterLevel {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1B71368AE63A21D6));
  }
  public ref bool IsDormant {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1B71368A1D7D906E));
  }
  public ref CUtlVector< CHandle< CFish > > Fishes {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CFish > >>(Schema.GetOffset(0x1B71368AFDB58C33));
  }
  public ICountdownTimer VisTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1B71368AC8E45FB6));
  }


}
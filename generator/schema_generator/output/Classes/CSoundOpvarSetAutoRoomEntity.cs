using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundOpvarSetAutoRoomEntity : CSoundOpvarSetPointEntity, ISoundOpvarSetAutoRoomEntity {

  public CSoundOpvarSetAutoRoomEntity(nint handle) : base(handle) {
  }

  public ref CUtlVector TraceResults {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x13ABD76E24ADC8DC));
  }
  public ref CUtlVector DoorwayPairs {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x13ABD76EFAD6453D));
  }
  public ref float Size {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x13ABD76E4CF0EBC6));
  }
  public ref float HeightTolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x13ABD76EB388225F));
  }
  public ref float SizeSqr {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x13ABD76E063EF878));
  }


}
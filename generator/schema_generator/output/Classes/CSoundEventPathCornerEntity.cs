using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventPathCornerEntity : CSoundEventEntity, ISoundEventPathCornerEntity {

  public CSoundEventPathCornerEntity(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge PathCorner {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9EED262E0243CF47));
  }
  public ref int CountMax {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9EED262E6A1AD493));
  }
  public ref float DistanceMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9EED262EFDEBADA6));
  }
  public ref float DistMaxSqr {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9EED262E993EE3BF));
  }
  public ref float DotProductMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9EED262EF9DEDD1D));
  }
  public ref bool Playing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9EED262E4B594215));
  }

  public void CornerPairsNetworkedUpdated() {
    Schema.Update(_Handle, 0x9EED262E4C7A9B2C);
  }
}
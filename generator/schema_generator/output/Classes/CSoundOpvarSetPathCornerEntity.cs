using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundOpvarSetPathCornerEntity : CSoundOpvarSetPointEntity, ISoundOpvarSetPathCornerEntity {

  public CSoundOpvarSetPathCornerEntity(nint handle) : base(handle) {
  }

  public CSoundOpvarSetPathCornerEntity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float DistMinSqr {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x368409543D1989CD));
  }
  public ref float DistMaxSqr {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x36840954993EE3BF));
  }
  public ref CUtlSymbolLarge PathCornerEntityName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x36840954EF6D6403));
  }


}
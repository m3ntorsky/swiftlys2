using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMarkupVolumeTagged : CMarkupVolume, IMarkupVolumeTagged {

  public CMarkupVolumeTagged(nint handle) : base(handle) {
  }

  public CMarkupVolumeTagged(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CGlobalSymbol > GroupNames {
    get => ref _Handle.AsRef<CUtlVector< CGlobalSymbol >>(Schema.GetOffset(0x4113340CB853197C));
  }
  public ref CUtlVector< CGlobalSymbol > Tags {
    get => ref _Handle.AsRef<CUtlVector< CGlobalSymbol >>(Schema.GetOffset(0x4113340C31C5D020));
  }
  public ref bool IsGroup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4113340CB68D3FDC));
  }
  public ref bool GroupByPrefab {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4113340CBCD6E7A7));
  }
  public ref bool GroupByVolume {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4113340CFE19F503));
  }
  public ref bool GroupOtherGroups {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4113340CE6C708E6));
  }
  public ref bool IsInGroup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4113340C19D5C241));
  }


}
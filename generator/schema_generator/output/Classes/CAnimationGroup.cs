using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimationGroup : SchemaClass, IAnimationGroup {

  public CAnimationGroup(nint handle) : base(handle) {
  }

  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x338D4483CE6E9C28));
  }
  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x338D44834D8F5786));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCAnimData>> LocalHAnimArray_Handle {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCAnimData>>>(Schema.GetOffset(0x338D44834059130D));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCAnimationGroup>> IncludedGroupArray_Handle {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCAnimationGroup>>>(Schema.GetOffset(0x338D4483029BD190));
  }
  public ref CStrongHandle<InfoForResourceTypeCSequenceGroupData> DirectHSeqGroup_Handle {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCSequenceGroupData>>(Schema.GetOffset(0x338D44836F0E7A99));
  }
  public IAnimKeyData DecodeKey {
    get => new CAnimKeyData(_Handle + Schema.GetOffset(0x338D4483923D44D6));
  }
  public ref CUtlVector<CBufferString> Scripts {
    get => ref _Handle.AsRef<CUtlVector<CBufferString>>(Schema.GetOffset(0x338D4483F1FF2218));
  }
  public ref CUtlVector<CStrongHandle<oi>> AdditionalExtRefs {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<oi>>>(Schema.GetOffset(0x338D448349CEFD51));
  }


}
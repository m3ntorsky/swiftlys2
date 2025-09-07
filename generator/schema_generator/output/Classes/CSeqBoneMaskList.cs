using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqBoneMaskList : SchemaClass, ISeqBoneMaskList {

  public CSeqBoneMaskList(nint handle) : base(handle) {
  }

  public CSeqBoneMaskList(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xCD7B4EF763D22D49));
  }
  public ref CUtlVector< int16 > LocalBoneArray {
    get => ref _Handle.AsRef<CUtlVector< int16 >>(Schema.GetOffset(0xCD7B4EF70B8EFD6B));
  }
  public ref CUtlVector< float32 > BoneWeightArray {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0xCD7B4EF747E1E612));
  }
  public ref float DefaultMorphCtrlWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCD7B4EF7AA0F3843));
  }
  public ref CUtlVector< std::pair< CBufferString, float32 > > MorphCtrlWeightArray {
    get => ref _Handle.AsRef<CUtlVector< std::pair< CBufferString, float32 > >>(Schema.GetOffset(0xCD7B4EF72C45A089));
  }


}
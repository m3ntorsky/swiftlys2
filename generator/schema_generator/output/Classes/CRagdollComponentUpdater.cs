using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRagdollComponentUpdater : CAnimComponentUpdater, IRagdollComponentUpdater {

  public CRagdollComponentUpdater(nint handle) : base(handle) {
  }

  public CRagdollComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CAnimNodePath > RagdollNodePaths {
    get => ref _Handle.AsRef<CUtlVector< CAnimNodePath >>(Schema.GetOffset(0xDD5F05A990E04B90));
  }
  public ref CUtlVector< CAnimNodePath > FollowAttachmentNodePaths {
    get => ref _Handle.AsRef<CUtlVector< CAnimNodePath >>(Schema.GetOffset(0xDD5F05A95F8325EF));
  }
  public ref CUtlVector< int32 > BoneIndices {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0xDD5F05A9E93AB60C));
  }
  public ref CUtlVector< CUtlString > BoneNames {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xDD5F05A93CC0D1ED));
  }
  public ref CUtlVector< WeightList > WeightLists {
    get => ref _Handle.AsRef<CUtlVector< WeightList >>(Schema.GetOffset(0xDD5F05A9F50C4582));
  }
  public ref CUtlVector< int32 > BoneToWeightIndices {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0xDD5F05A9CA322B97));
  }
  public ref float SpringFrequencyMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDD5F05A937C769A4));
  }
  public ref float SpringFrequencyMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDD5F05A945DB0766));
  }
  public ref float MaxStretch {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDD5F05A9BCF894C4));
  }
  public ref bool SolidCollisionAtZeroWeight {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDD5F05A983AB44C3));
  }


}
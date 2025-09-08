using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSkeleton : SchemaClass, INmSkeleton {

  public CNmSkeleton(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xC923251495066900));
  }
  public ref CUtlLeanVector<CGlobalSymbol> BoneIDs {
    get => ref _Handle.AsRef<CUtlLeanVector<CGlobalSymbol>>(Schema.GetOffset(0xC92325140909C443));
  }
  public ref CUtlVector<int> ParentIndices {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0xC923251480CFB2AA));
  }
  public ref CUtlVector<CTransform> ParentSpaceReferencePose {
    get => ref _Handle.AsRef<CUtlVector<CTransform>>(Schema.GetOffset(0xC92325145BF1EDE7));
  }
  public ref CUtlVector<CTransform> ModelSpaceReferencePose {
    get => ref _Handle.AsRef<CUtlVector<CTransform>>(Schema.GetOffset(0xC92325147B025328));
  }
  public ref int NumBonesToSampleAtLowLOD {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC9232514813C419D));
  }
  public ref CUtlLeanVector<NmBoneMaskSetDefinition_t> MaskDefinitions {
    get => ref _Handle.AsRef<CUtlLeanVector<NmBoneMaskSetDefinition_t>>(Schema.GetOffset(0xC92325147196574D));
  }
  public ref CUtlLeanVector<CNmSkeleton::SecondarySkeleton_t> SecondarySkeletons {
    get => ref _Handle.AsRef<CUtlLeanVector<CNmSkeleton::SecondarySkeleton_t>>(Schema.GetOffset(0xC9232514782F396B));
  }
  public ref bool IsPropSkeleton {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC9232514FD7D351F));
  }


}
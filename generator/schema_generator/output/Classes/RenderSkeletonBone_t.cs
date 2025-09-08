using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RenderSkeletonBone_t : SchemaClass, IRenderSkeletonBone_t {

  public RenderSkeletonBone_t(nint handle) : base(handle) {
  }

  public ref CUtlString BoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6A3BCC9BFDEE0E0C));
  }
  public ref CUtlString ParentName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6A3BCC9BC45C5BBE));
  }
  public ref matrix3x4_t InvBindPose {
    get => ref _Handle.AsRef<matrix3x4_t>(Schema.GetOffset(0x6A3BCC9B265CACBE));
  }
  public ISkeletonBoneBounds_t Bbox {
    get => new SkeletonBoneBounds_t(_Handle + Schema.GetOffset(0x6A3BCC9B39392A72));
  }
  public ref float SphereRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A3BCC9B7AF55658));
  }


}
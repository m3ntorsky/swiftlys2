using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class World_t : SchemaClass, IWorld_t {

  public World_t(nint handle) : base(handle) {
  }

  public IWorldBuilderParams_t BuilderParams {
    get => new WorldBuilderParams_t(_Handle + Schema.GetOffset(0x4CBF8350CE4EEF26));
  }
  public ref CUtlVector WorldNodes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x4CBF835064F33530));
  }
  public IBakedLightingInfo_t WorldLightingInfo {
    get => new BakedLightingInfo_t(_Handle + Schema.GetOffset(0x4CBF83508B843A17));
  }
  public ref CUtlVector<CStrongHandle<opyable<InfoForResourceTypeCEntityLump>> EntityLumps {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<opyable<InfoForResourceTypeCEntityLump>>>(Schema.GetOffset(0x4CBF8350E4A85021));
  }


}
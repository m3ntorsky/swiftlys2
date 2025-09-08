using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMorphSetData : SchemaClass, IMorphSetData {

  public CMorphSetData(nint handle) : base(handle) {
  }

  public ref int Width {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE777C2D4119108BB));
  }
  public ref int Height {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE777C2D4CAB61C56));
  }
  public ref CUtlVector<MorphBundleType_t> BundleTypes {
    get => ref _Handle.AsRef<CUtlVector<MorphBundleType_t>>(Schema.GetOffset(0xE777C2D4B233045A));
  }
  public ref CUtlVector MorphDatas {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xE777C2D4C1280FA2));
  }
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureAtlas {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCTextureBase>>(Schema.GetOffset(0xE777C2D4B63CAC4D));
  }
  public ref CUtlVector FlexDesc {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xE777C2D4D73F3393));
  }
  public ref CUtlVector FlexControllers {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xE777C2D4ABE5EBBB));
  }
  public ref CUtlVector FlexRules {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xE777C2D47FE50585));
  }


}
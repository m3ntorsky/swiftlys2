using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigList : SchemaClass, IModelConfigList {

  public CModelConfigList(nint handle) : base(handle) {
  }

  public ref bool HideMaterialGroupInTools {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5291D8D9214E9E53));
  }
  public ref bool HideRenderColorInTools {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5291D8D9C25B2716));
  }
  public ref CUtlVector<PointerTo<CModelConfig>> Configs {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CModelConfig>>>(Schema.GetOffset(0x5291D8D906111EDC));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmBoneMaskSelectorNode__CDefinition : CNmBoneMaskValueNode::CDefinition, INmBoneMaskSelectorNode__CDefinition {

  public CNmBoneMaskSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmBoneMaskSelectorNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short DefaultMaskNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA90158701E92549D));
  }
  public ref short ParameterValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA90158702696FA7C));
  }
  public ref bool SwitchDynamically {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA9015870461869F8));
  }
  public ref CUtlVectorFixedGrowable< int16, 7 > MaskNodeIndices {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< int16, 7 >>(Schema.GetOffset(0xA90158703326692E));
  }
  public ref CUtlVectorFixedGrowable< CGlobalSymbol, 7 > ParameterValues {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< CGlobalSymbol, 7 >>(Schema.GetOffset(0xA90158709D777E36));
  }
  public ref float BlendTimeSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA90158706D3A08FC));
  }


}
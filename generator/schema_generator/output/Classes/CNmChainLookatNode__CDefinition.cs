using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmChainLookatNode__CDefinition : CNmPassthroughNode::CDefinition, INmChainLookatNode__CDefinition {

  public CNmChainLookatNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmChainLookatNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol ChainEndBoneID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x3D36690222B26274));
  }
  public ref short LookatTargetNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x3D36690221A633B1));
  }
  public ref short EnabledNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x3D366902F7CDF5E9));
  }
  public ref float BlendTimeSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3D3669026D3A08FC));
  }
  public ref byte ChainLength {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x3D366902ACB94336));
  }
  public ref bool IsTargetInWorldSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3D3669025F56E0C5));
  }
  public ref Vector ChainForwardDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x3D36690298A5355A));
  }


}
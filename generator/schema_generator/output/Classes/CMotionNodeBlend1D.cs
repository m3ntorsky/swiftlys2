using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionNodeBlend1D : CMotionNode, IMotionNodeBlend1D {

  public CMotionNodeBlend1D(nint handle) : base(handle) {
  }

  public ref CUtlVector BlendItems {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xB34B43D2BCCB1A7C));
  }
  public ref int ParamIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB34B43D2CA6E6F52));
  }


}
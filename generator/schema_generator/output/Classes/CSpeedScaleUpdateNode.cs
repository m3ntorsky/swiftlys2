using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSpeedScaleUpdateNode : CUnaryUpdateNode, ISpeedScaleUpdateNode {

  public CSpeedScaleUpdateNode(nint handle) : base(handle) {
  }

  public IAnimParamHandle ParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xD43012BC61990A86));
  }


}
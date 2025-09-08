using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmParameterizedBlendNode__Parameterization_t : SchemaClass, INmParameterizedBlendNode__Parameterization_t {

  public CNmParameterizedBlendNode__Parameterization_t(nint handle) : base(handle) {
  }

  public ref CUtlLeanVectorFixedGrowable<CNmParameterizedBlendNode::BlendRange_t,5> BlendRanges {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable<CNmParameterizedBlendNode::BlendRange_t,5>>(Schema.GetOffset(0xD342D3196DA1C61A));
  }
  public ISchemaUntypedField ParameterRange {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD342D319E7E71E25));
  }


}
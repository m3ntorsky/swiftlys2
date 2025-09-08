using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmBlend1DNode__CDefinition : CNmParameterizedBlendNode::CDefinition, INmBlend1DNode__CDefinition {

  public CNmBlend1DNode__CDefinition(nint handle) : base(handle) {
  }

  public INmParameterizedBlendNode::Parameterization_t Parameterization {
    get => new CNmParameterizedBlendNode::Parameterization_t(_Handle + Schema.GetOffset(0xA5E668CDE173A928));
  }


}
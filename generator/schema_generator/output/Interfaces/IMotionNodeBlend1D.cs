using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionNodeBlend1D : IMotionNode {

  public ref CUtlVector BlendItems { get; }
  
  public ref int ParamIndex { get; }
  
}
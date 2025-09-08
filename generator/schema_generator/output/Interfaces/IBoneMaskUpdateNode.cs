using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneMaskUpdateNode : IBinaryUpdateNode {

  public ref int WeightListIndex { get; }
  
  public ref float RootMotionBlend { get; }
  
  public ref BoneMaskBlendSpace BlendSpace { get; }
  
  public ref BinaryNodeChildOption FootMotionTiming { get; }
  
  public ref bool UseBlendScale { get; }
  
  public ref AnimValueSource BlendValueSource { get; }
  
  public IAnimParamHandle BlendParameter { get; }
  
}
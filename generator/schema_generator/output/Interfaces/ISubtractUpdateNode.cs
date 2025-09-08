using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISubtractUpdateNode : IBinaryUpdateNode {

  public ref BinaryNodeChildOption FootMotionTiming { get; }
  
  public ref bool ApplyToFootMotion { get; }
  
  public ref bool ApplyChannelsSeparately { get; }
  
  public ref bool UseModelSpace { get; }
  
}
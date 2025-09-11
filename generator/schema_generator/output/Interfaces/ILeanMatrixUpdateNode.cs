using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILeanMatrixUpdateNode : ILeafUpdateNode {

  
  public ISchemaFixedArray<int[3]> FrameCorners { get; }
  
  public IPoseHandle Poses { get; }
  
  public IAnimInputDamping Damping { get; }
  
  public ref AnimVectorSource BlendSource { get; }
  
  public IAnimParamHandle ParamIndex { get; }
  
  public ref Vector VerticalAxis { get; }
  
  public ref Vector HorizontalAxis { get; }
  
  public IHSequence Sequence { get; }
  
  public ref float MaxValue { get; }
  
  public ref int SequenceMaxFrame { get; }
}
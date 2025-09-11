using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISequenceHistory_t : ISchemaClass {

  
  public IHSequence Sequence { get; }
  
  public IGameTime_t SeqStartTime { get; }
  
  public ref float SeqFixedCycle { get; }
  
  public ref AnimLoopMode_t SeqLoopMode { get; }
  
  public ref float PlaybackRate { get; }
  
  public ref float CyclesPerSecond { get; }
}
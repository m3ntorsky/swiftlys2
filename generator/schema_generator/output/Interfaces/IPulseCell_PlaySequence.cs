using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_PlaySequence : IPulseCell_BaseYieldingInflow {

  public ref CUtlString SequenceName { get; }
  
  public IPulseNodeDynamicOutflows_t PulseAnimEvents { get; }
  
  public IPulse_ResumePoint OnFinished { get; }
  
  public IPulse_ResumePoint OnCanceled { get; }
  
}
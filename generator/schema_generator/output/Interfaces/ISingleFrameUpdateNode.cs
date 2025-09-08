using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISingleFrameUpdateNode : ILeafUpdateNode {

  public ref CUtlVector Actions { get; }
  
  public IPoseHandle PoseCacheHandle { get; }
  
  public IHSequence Sequence { get; }
  
  public ref float Cycle { get; }
  
}
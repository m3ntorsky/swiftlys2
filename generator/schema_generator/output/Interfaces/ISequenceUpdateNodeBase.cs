using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISequenceUpdateNodeBase : ILeafUpdateNode {

  
  public ref float PlaybackSpeed { get; }
  
  public ref bool Loop { get; }
}
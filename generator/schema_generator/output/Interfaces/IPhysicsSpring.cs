using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsSpring : IBaseEntity {

  public ref float Frequency { get; }
  
  public ref float DampingRatio { get; }
  
  public ref float RestLength { get; }
  
  public ref CUtlSymbolLarge NameAttachStart { get; }
  
  public ref CUtlSymbolLarge NameAttachEnd { get; }
  
  public ref Vector Start { get; }
  
  public ref Vector End { get; }
  
  public ref uint TeleportTick { get; }
  
}
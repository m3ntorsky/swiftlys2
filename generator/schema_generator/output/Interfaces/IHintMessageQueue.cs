using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHintMessageQueue : ISchemaClass {

  public ref float TmMessageEnd { get; }
  
  public ref CUtlVector<PointerTo<CHintMessage>> Messages { get; }
  
  public IBasePlayerController PlayerController { get; }
  
}
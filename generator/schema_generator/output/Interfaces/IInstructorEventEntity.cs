using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInstructorEventEntity : IPointEntity {

  public ref CUtlSymbolLarge Name { get; }
  
  public ref CUtlSymbolLarge HintTargetEntity { get; }
  
  public CHandle<IBasePlayerPawn> TargetPlayer { get; }
  
}
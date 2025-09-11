using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvFade : ILogicalEntity {

  
  public ref Color FadeColor { get; }
  
  public ref float Duration { get; }
  
  public ref float HoldDuration { get; }
  
  public IEntityIOOutput OnBeginFade { get; }
}
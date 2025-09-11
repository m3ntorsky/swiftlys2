using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFogTrigger : IBaseTrigger {

  
  public Ifogparams_t Fog { get; }
}
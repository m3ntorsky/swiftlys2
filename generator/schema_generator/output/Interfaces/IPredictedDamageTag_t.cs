using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPredictedDamageTag_t : ISchemaClass {

  public IGameTick_t TagTick { get; }
  
  public ref float FlinchModSmall { get; }
  
  public ref float FlinchModLarge { get; }
  
  public ref float FriendlyFireDamageReductionRatio { get; }
  
}
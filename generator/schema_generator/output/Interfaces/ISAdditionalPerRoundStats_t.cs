using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISAdditionalPerRoundStats_t : ISchemaClass {

  
  public ref int NumChickensKilled { get; }
  
  public ref int KillsWhileBlind { get; }
  
  public ref int BombCarrierkills { get; }
  
  public ref int BurnDamageInflicted { get; }
  
  public ref int BlastDamageInflicted { get; }
  
  public ref int Dinks { get; }
}
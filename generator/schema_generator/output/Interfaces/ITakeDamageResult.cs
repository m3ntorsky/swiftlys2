using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITakeDamageResult : ISchemaClass {

  
  public ITakeDamageInfo OriginatingInfo { get; }
  
  public ref int HealthLost { get; }
  
  public ref int DamageTaken { get; }
  
  public ref float PreModifiedDamage { get; }
  
  public ref int TotalledHealthLost { get; }
  
  public ref int TotalledDamageDealt { get; }
}
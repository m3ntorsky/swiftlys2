using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointHurt : IPointEntity {

  public ref int Damage { get; }
  
  public ref DamageTypes_t BitsDamageType { get; }
  
  public ref float Radius { get; }
  
  public ref float Delay { get; }
  
  public ref CUtlSymbolLarge StrTarget { get; }
  
  public ref CHandle<CBaseEntity> Activator { get; }
  
}
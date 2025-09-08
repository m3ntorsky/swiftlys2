using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDestructiblePartsSystemComponent : ISchemaClass {

  public INetworkVarChainer __m_pChainEntity { get; }
  
  public ref CUtlVector<ushort> DamageLevelTakenByHitGroup { get; }
  
  public CHandle<IBaseModelEntity> Owner { get; }
  
  public ref int LastHitDamageLevel { get; }
  
}
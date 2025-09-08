using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicBranch : ILogicalEntity {

  public ref bool InValue { get; }
  
  public ref CUtlVector<CHandle<CBaseEntity>> Listeners { get; }
  
  public IEntityIOOutput OnTrue { get; }
  
  public IEntityIOOutput OnFalse { get; }
  
}
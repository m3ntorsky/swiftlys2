using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicBranchList : ILogicalEntity {

  public ISchemaFixedArray<CUtlSymbolLarge> LogicBranchNames { get; }
  
  public ref CUtlVector<CHandle<CBaseEntity>> LogicBranchList { get; }
  
  public ref CLogicBranchList::LogicBranchListenerLastState_t LastState { get; }
  
  public IEntityIOOutput OnAllTrue { get; }
  
  public IEntityIOOutput OnAllFalse { get; }
  
  public IEntityIOOutput OnMixed { get; }
  
}
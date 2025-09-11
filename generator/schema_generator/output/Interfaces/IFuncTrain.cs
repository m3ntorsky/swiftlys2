using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncTrain : IBasePlatTrain {

  
  public ref CHandle<CBaseEntity> CurrentTarget { get; }
  
  public ref bool Activated { get; }
  
  public ref CHandle<CBaseEntity> Enemy { get; }
  
  public ref float BlockDamage { get; }
  
  public IGameTime_t NextBlockTime { get; }
  
  public ref CUtlSymbolLarge LastTarget { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISceneListManager : ILogicalEntity {

  
  public ref CUtlVector<CHandle<CSceneListManager>> ListManagers { get; }
  
  public ISchemaFixedArray<CUtlSymbolLarge> Scenes { get; }
  
  public ref CHandle<CBaseEntity> Scenes { get; }
}
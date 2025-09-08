using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISpawnPoint : IServerOnlyPointEntity {

  public ref int Priority { get; }
  
  public ref bool Enabled { get; }
  
  public ref int Type { get; }
  
}
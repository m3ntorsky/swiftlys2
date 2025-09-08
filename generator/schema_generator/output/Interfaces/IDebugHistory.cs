using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDebugHistory : IBaseEntity {

  public ref int NpcEvents { get; }
  
}
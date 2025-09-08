using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHandleTest : IBaseEntity {

  public ref CHandle<CBaseEntity> Handle { get; }
  
  public ref bool SendHandle { get; }
  
}
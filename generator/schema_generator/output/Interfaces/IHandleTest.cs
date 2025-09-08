using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHandleTest : IBaseEntity {

  public CHandle<IBaseEntity> Handle { get; }
  
  public ref bool SendHandle { get; }
  
}
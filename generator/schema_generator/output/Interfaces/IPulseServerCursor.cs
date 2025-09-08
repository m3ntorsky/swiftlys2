using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseServerCursor : IPulseExecCursor {

  public CHandle<IBaseEntity> Activator { get; }
  
  public CHandle<IBaseEntity> Caller { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseServerCursor : IPulseExecCursor {

  
  public ref CHandle<CBaseEntity> Activator { get; }
  
  public ref CHandle<CBaseEntity> Caller { get; }
}
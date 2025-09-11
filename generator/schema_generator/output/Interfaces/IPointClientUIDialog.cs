using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointClientUIDialog : IBaseClientUIEntity {

  
  public ref CHandle<CBaseEntity> Activator { get; }
  
  public ref bool StartEnabled { get; }
}
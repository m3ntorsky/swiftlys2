using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointClientUIDialog : IBaseClientUIEntity {

  public CHandle<IBaseEntity> Activator { get; }
  
  public ref bool StartEnabled { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointGiveAmmo : IPointEntity {

  public CHandle<IBaseEntity> Activator { get; }
  
}
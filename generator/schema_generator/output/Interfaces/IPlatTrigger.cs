using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlatTrigger : IBaseModelEntity {

  public ref CHandle<CFuncPlat> Platform { get; }
  
}
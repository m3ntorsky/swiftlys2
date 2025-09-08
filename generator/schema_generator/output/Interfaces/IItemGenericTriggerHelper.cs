using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IItemGenericTriggerHelper : IBaseModelEntity {

  public ref CHandle<CItemGeneric> ParentItem { get; }
  
}
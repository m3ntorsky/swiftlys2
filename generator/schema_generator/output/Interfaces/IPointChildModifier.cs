using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointChildModifier : IPointEntity {

  
  public ref bool OrphanInsteadOfDeletingChildrenOnRemove { get; }
}
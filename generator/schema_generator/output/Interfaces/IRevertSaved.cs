using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRevertSaved : IModelPointEntity {

  public ref float LoadTime { get; }
  
  public ref float Duration { get; }
  
  public ref float HoldTime { get; }
  
}
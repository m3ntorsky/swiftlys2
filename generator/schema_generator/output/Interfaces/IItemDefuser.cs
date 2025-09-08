using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IItemDefuser : IItem {

  public IEntitySpottedState_t EntitySpottedState { get; }
  
  public ref int SpotRules { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IScriptItem : IItem {

  public ref MoveType_t MoveTypeOverride { get; }
  
}
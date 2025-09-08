using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionTimeBlockLimitSchema : ISosGroupActionSchema {

  public ref int MaxCount { get; }
  
  public ref float MaxDuration { get; }
  
}
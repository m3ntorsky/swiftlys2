using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRulePointEntity : IRuleEntity {

  
  public ref int Score { get; }
}
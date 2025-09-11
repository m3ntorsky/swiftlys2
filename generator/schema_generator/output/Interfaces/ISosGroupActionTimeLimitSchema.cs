using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionTimeLimitSchema : ISosGroupActionSchema {

  
  public ref float MaxDuration { get; }
}
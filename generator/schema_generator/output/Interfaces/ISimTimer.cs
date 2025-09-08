using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISimTimer : ISimpleSimTimer {

  public ref float Interval { get; }
  
}
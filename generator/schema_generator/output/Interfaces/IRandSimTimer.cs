using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRandSimTimer : ISimpleSimTimer {

  public ref float MinInterval { get; }
  
  public ref float MaxInterval { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBtActionParachutePositioning : IBtNode {

  public ICountdownTimer ActionTimer { get; }
  
}
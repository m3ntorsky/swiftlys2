using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathHelperUpdateNode : IUnaryUpdateNode {

  
  public ref float StoppingRadius { get; }
  
  public ref float StoppingSpeedScale { get; }
}
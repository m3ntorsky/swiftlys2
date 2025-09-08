using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFloatAnimParameter : IConcreteAnimParameter {

  public ref float DefaultValue { get; }
  
  public ref float MinValue { get; }
  
  public ref float MaxValue { get; }
  
  public ref bool Interpolate { get; }
  
}
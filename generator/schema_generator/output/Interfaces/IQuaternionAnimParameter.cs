using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IQuaternionAnimParameter : IConcreteAnimParameter {

  
  public ref Quaternion DefaultValue { get; }
  
  public ref bool Interpolate { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVectorAnimParameter : IConcreteAnimParameter {

  public ref Vector DefaultValue { get; }
  
  public ref bool Interpolate { get; }
  
}
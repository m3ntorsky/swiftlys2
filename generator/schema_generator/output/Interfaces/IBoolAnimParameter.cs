using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoolAnimParameter : IConcreteAnimParameter {

  public ref bool DefaultValue { get; }
  
}
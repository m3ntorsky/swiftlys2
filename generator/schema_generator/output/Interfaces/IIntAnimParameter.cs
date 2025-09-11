using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IIntAnimParameter : IConcreteAnimParameter {

  
  public ref int DefaultValue { get; }
  
  public ref int MinValue { get; }
  
  public ref int MaxValue { get; }
}
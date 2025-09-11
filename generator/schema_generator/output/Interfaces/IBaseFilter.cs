using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseFilter : ILogicalEntity {

  
  public ref bool Negated { get; }
  
  public IEntityIOOutput OnPass { get; }
  
  public IEntityIOOutput OnFail { get; }
}
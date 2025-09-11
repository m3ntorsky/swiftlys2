using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterMassGreater : IBaseFilter {

  
  public ref float FilterMass { get; }
}
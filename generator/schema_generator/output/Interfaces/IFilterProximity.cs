using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterProximity : IBaseFilter {

  public ref float Radius { get; }
  
}
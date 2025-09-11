using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterHealth : IBaseFilter {

  
  public ref bool AdrenalineActive { get; }
  
  public ref int HealthMin { get; }
  
  public ref int HealthMax { get; }
}
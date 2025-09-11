using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterDamageType : IBaseFilter {

  
  public ref int DamageType { get; }
}
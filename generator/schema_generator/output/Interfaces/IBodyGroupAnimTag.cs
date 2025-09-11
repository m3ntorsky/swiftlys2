using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBodyGroupAnimTag : IAnimTagBase {

  
  public ref int Priority { get; }
  
// CUtlVector< CBodyGroupSetting >
  public ref CUtlVector BodyGroupSettings { get; }
}
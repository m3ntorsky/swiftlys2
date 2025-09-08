using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootFallAnimTag : IAnimTagBase {

  public ref FootFallTagFoot_t Foot { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathSimple : IBaseEntity {

  
  public IPathQueryComponent CPathQueryComponent { get; }
  
  public ref CUtlString PathString { get; }
  
  public ref bool ClosedLoop { get; }
}
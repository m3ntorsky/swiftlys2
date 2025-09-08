using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathCorner : IPointEntity {

  public ref float Wait { get; }
  
  public ref float Radius { get; }
  
  public IEntityIOOutput OnPass { get; }
  
}
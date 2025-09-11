using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INetworkOriginCellCoordQuantizedVector : ISchemaClass {

  
  public ref ushort CellX { get; }
  
  public ref ushort CellY { get; }
  
  public ref ushort CellZ { get; }
  
  public ref ushort OutsideWorld { get; }
  
  public ref CNetworkedQuantizedFloat X { get; }
  
  public ref CNetworkedQuantizedFloat Y { get; }
  
  public ref CNetworkedQuantizedFloat Z { get; }
}
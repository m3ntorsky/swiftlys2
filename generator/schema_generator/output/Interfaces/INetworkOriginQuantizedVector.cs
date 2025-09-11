using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INetworkOriginQuantizedVector : ISchemaClass {

  
  public ref CNetworkedQuantizedFloat X { get; }
  
  public ref CNetworkedQuantizedFloat Y { get; }
  
  public ref CNetworkedQuantizedFloat Z { get; }
}
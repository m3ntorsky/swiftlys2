using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INetworkTransmitComponent : ISchemaClass {

  
  public ref byte TransmitStateOwnedCounter { get; }
}
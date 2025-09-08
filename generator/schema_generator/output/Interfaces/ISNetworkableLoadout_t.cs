using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISNetworkableLoadout_t : ISchemaClass {

  public IEconItemView Item { get; }
  
  public ref ushort Team { get; }
  
  public ref ushort Slot { get; }
  
}
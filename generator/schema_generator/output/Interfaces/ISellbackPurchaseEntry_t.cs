using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISellbackPurchaseEntry_t : ISchemaClass {

  
  public ref ushort DefIdx { get; }
  
  public ref int Cost { get; }
  
  public ref int PrevArmor { get; }
  
  public ref bool PrevHelmet { get; }
  
  public ref CHandle<IEntityInstance> Item { get; }
}
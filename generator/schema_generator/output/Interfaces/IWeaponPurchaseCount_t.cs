using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWeaponPurchaseCount_t : ISchemaClass {

  
  public ref ushort ItemDefIndex { get; }
  
  public ref ushort Count { get; }
}
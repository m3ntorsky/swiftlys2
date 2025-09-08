using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IServerAuthoritativeWeaponSlot_t : ISchemaClass {

  public ref ushort Class { get; }
  
  public ref ushort Slot { get; }
  
  public ref ushort ItemDefIdx { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSGO_TeamPreviewCharacterPosition : IBaseEntity {

  public ref int Variant { get; }
  
  public ref int Random { get; }
  
  public ref int Ordinal { get; }
  
  public ref CUtlString WeaponName { get; }
  
  public ref ulong Xuid { get; }
  
  public IEconItemView AgentItem { get; }
  
  public IEconItemView GlovesItem { get; }
  
  public IEconItemView WeaponItem { get; }
  
}
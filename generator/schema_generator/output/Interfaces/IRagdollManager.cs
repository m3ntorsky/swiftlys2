using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollManager : IBaseEntity {

  public ref byte CurrentMaxRagdollCount { get; }
  
  public ref int MaxRagdollCount { get; }
  
  public ref bool SaveImportant { get; }
  
  public ref bool CanTakeDamage { get; }
  
}
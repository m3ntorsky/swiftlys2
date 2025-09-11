using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleNode_t : ISchemaClass {

  
  public ref CHandle<CBaseEntity> Entity { get; }
  
  public IParticleIndex_t Index { get; }
  
  public IGameTime_t StartTime { get; }
  
  public ref float GrowthDuration { get; }
  
  public ref Vector GrowthOrigin { get; }
  
  public ref float EndcapTime { get; }
  
  public ref bool MarkedForDelete { get; }
}
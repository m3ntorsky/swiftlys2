using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Ilerpdata_t : ISchemaClass {

  public CHandle<IBaseEntity> Ent { get; }
  
  public ref MoveType_t MoveType { get; }
  
  public IGameTime_t StartTime { get; }
  
  public ref Vector StartOrigin { get; }
  
  public ref Quaternion StartRot { get; }
  
  public IParticleIndex_t FXIndex { get; }
  
}
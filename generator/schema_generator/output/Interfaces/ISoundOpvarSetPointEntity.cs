using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetPointEntity : ISoundOpvarSetPointBase {

  
  public IEntityIOOutput OnEnter { get; }
  
  public IEntityIOOutput OnExit { get; }
  
  public ref bool AutoDisable { get; }
  
  public ref float DistanceMin { get; }
  
  public ref float DistanceMax { get; }
  
  public ref float DistanceMapMin { get; }
  
  public ref float DistanceMapMax { get; }
  
  public ref float OcclusionRadius { get; }
  
  public ref float OcclusionMin { get; }
  
  public ref float OcclusionMax { get; }
  
  public ref float ValSetOnDisable { get; }
  
  public ref bool SetValueOnDisable { get; }
  
  public ref bool Reloading { get; }
  
  public ref int SimulationMode { get; }
  
  public ref int VisibilitySamples { get; }
  
  public ref Vector DynamicProxyPoint { get; }
  
  public ref float DynamicMaximumOcclusion { get; }
  
  public ref CHandle<IEntityInstance> DynamicEntity { get; }
  
  public ISchemaUntypedField DynamicEntityName { get; }
  
  public ref float PathingDistanceNormFactor { get; }
  
  public ref Vector PathingSourcePos { get; }
  
  public ref Vector PathingListenerPos { get; }
  
  public ref Vector PathingDirection { get; }
  
  public ref int PathingSourceIndex { get; }
}
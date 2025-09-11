using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAggregateMeshInfo_t : ISchemaClass {

  
  public ref uint VisClusterMemberOffset { get; }
  
  public ref byte VisClusterMemberCount { get; }
  
  public ref bool HasTransform { get; }
  
  public ref byte LODGroupMask { get; }
  
  public ref short DrawCallIndex { get; }
  
  public ref short LODSetupIndex { get; }
  
  public ref Color TintColor { get; }
  
  public ref ObjectTypeFlags_t ObjectFlags { get; }
  
  public ref int LightProbeVolumePrecomputedHandshake { get; }
  
  public ref uint InstanceStreamOffset { get; }
  
  public ref uint VertexAlbedoStreamOffset { get; }
  
  public ref AggregateInstanceStream_t InstanceStreams { get; }
}
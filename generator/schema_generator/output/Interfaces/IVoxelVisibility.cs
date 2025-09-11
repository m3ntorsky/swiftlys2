using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoxelVisibility : ISchemaClass {

  
  public ref uint BaseClusterCount { get; }
  
  public ref uint PVSBytesPerCluster { get; }
  
  public ref Vector MinBounds { get; }
  
  public ref Vector MaxBounds { get; }
  
  public ref float GridSize { get; }
  
  public ref uint SkyVisibilityCluster { get; }
  
  public ref uint SunVisibilityCluster { get; }
  
  public IVoxelVisBlockOffset_t NodeBlock { get; }
  
  public IVoxelVisBlockOffset_t RegionBlock { get; }
  
  public IVoxelVisBlockOffset_t EnclosedClusterListBlock { get; }
  
  public IVoxelVisBlockOffset_t EnclosedClustersBlock { get; }
  
  public IVoxelVisBlockOffset_t MasksBlock { get; }
  
  public IVoxelVisBlockOffset_t VisBlocks { get; }
}
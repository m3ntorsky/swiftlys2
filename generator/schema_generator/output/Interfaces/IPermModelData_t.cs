using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPermModelData_t : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public IPermModelInfo_t ModelInfo { get; }
  
  public ref CUtlVector ExtParts { get; }
  
  public ref CUtlVector RefMeshes { get; }
  
  public ref CUtlVector<ulong> RefMeshGroupMasks { get; }
  
  public ref CUtlVector<ulong> RefPhysGroupMasks { get; }
  
  public ref CUtlVector<byte> RefLODGroupMasks { get; }
  
  public ref CUtlVector<float> LodGroupSwitchDistances { get; }
  
  public ref CUtlVector RefPhysicsData { get; }
  
  public ref CUtlVector RefPhysicsHitboxData { get; }
  
  public ref CUtlVector RefAnimGroups { get; }
  
  public ref CUtlVector RefSequenceGroups { get; }
  
  public ref CUtlVector<CUtlString> MeshGroups { get; }
  
  public ref CUtlVector MaterialGroups { get; }
  
  public ref ulong DefaultMeshGroupMask { get; }
  
  public IModelSkeletonData_t ModelSkeleton { get; }
  
  public ref CUtlVector<short> RemappingTable { get; }
  
  public ref CUtlVector<ushort> RemappingTableStarts { get; }
  
  public ref CUtlVector BoneFlexDrivers { get; }
  
  public IModelConfigList ModelConfigList { get; }
  
  public ref CUtlVector<CUtlString> BodyGroupsHiddenInTools { get; }
  
  public ref CUtlVector RefAnimIncludeModels { get; }
  
  public ref CUtlVector AnimatedMaterialAttributes { get; }
  
}
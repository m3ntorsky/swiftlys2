using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoxelVisibility : SchemaClass, IVoxelVisibility {

  public CVoxelVisibility(nint handle) : base(handle) {
  }

  public CVoxelVisibility(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint BaseClusterCount {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xDA27CA12A16788C5));
  }
  public ref uint PVSBytesPerCluster {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xDA27CA122C2340E0));
  }
  public ref Vector MinBounds {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDA27CA12114799FE));
  }
  public ref Vector MaxBounds {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDA27CA12C0B4CE60));
  }
  public ref float GridSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA27CA12975208C2));
  }
  public ref uint SkyVisibilityCluster {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xDA27CA12B43BF514));
  }
  public ref uint SunVisibilityCluster {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xDA27CA12848C92AD));
  }
  public IVoxelVisBlockOffset_t NodeBlock {
    get => new VoxelVisBlockOffset_t(_Handle + Schema.GetOffset(0xDA27CA12A64594EA));
  }
  public IVoxelVisBlockOffset_t RegionBlock {
    get => new VoxelVisBlockOffset_t(_Handle + Schema.GetOffset(0xDA27CA121918C67A));
  }
  public IVoxelVisBlockOffset_t EnclosedClusterListBlock {
    get => new VoxelVisBlockOffset_t(_Handle + Schema.GetOffset(0xDA27CA121F5DD1A9));
  }
  public IVoxelVisBlockOffset_t EnclosedClustersBlock {
    get => new VoxelVisBlockOffset_t(_Handle + Schema.GetOffset(0xDA27CA12F75E07CE));
  }
  public IVoxelVisBlockOffset_t MasksBlock {
    get => new VoxelVisBlockOffset_t(_Handle + Schema.GetOffset(0xDA27CA121853F2AB));
  }
  public IVoxelVisBlockOffset_t VisBlocks {
    get => new VoxelVisBlockOffset_t(_Handle + Schema.GetOffset(0xDA27CA128C69D893));
  }


}
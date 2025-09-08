using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PermModelData_t : SchemaClass, IPermModelData_t {

  public PermModelData_t(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3E367D0B4D8F5786));
  }
  public IPermModelInfo_t ModelInfo {
    get => new PermModelInfo_t(_Handle + Schema.GetOffset(0x3E367D0B506D8FE2));
  }
  public ref CUtlVector ExtParts {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x3E367D0B8564C2A6));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCRenderMesh>> RefMeshes {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCRenderMesh>>>(Schema.GetOffset(0x3E367D0B9FB3727B));
  }
  public ref CUtlVector<ulong> RefMeshGroupMasks {
    get => ref _Handle.AsRef<CUtlVector<ulong>>(Schema.GetOffset(0x3E367D0BDC56A19B));
  }
  public ref CUtlVector<ulong> RefPhysGroupMasks {
    get => ref _Handle.AsRef<CUtlVector<ulong>>(Schema.GetOffset(0x3E367D0B902CAAFA));
  }
  public ref CUtlVector<byte> RefLODGroupMasks {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x3E367D0B0FCE2099));
  }
  public ref CUtlVector<float> LodGroupSwitchDistances {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x3E367D0B52CCDE75));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCPhysAggregateData>> RefPhysicsData {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCPhysAggregateData>>>(Schema.GetOffset(0x3E367D0BF18951CB));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCPhysAggregateData>> RefPhysicsHitboxData {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCPhysAggregateData>>>(Schema.GetOffset(0x3E367D0B26C451DD));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCAnimationGroup>> RefAnimGroups {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCAnimationGroup>>>(Schema.GetOffset(0x3E367D0BDC24F793));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCSequenceGroupData>> RefSequenceGroups {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCSequenceGroupData>>>(Schema.GetOffset(0x3E367D0B823AD8A3));
  }
  public ref CUtlVector<CUtlString> MeshGroups {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0x3E367D0B3EF7CCF4));
  }
  public ref CUtlVector MaterialGroups {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x3E367D0BDD36CD50));
  }
  public ref ulong DefaultMeshGroupMask {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0x3E367D0B7320202A));
  }
  public IModelSkeletonData_t ModelSkeleton {
    get => new ModelSkeletonData_t(_Handle + Schema.GetOffset(0x3E367D0BAFF3E579));
  }
  public ref CUtlVector<short> RemappingTable {
    get => ref _Handle.AsRef<CUtlVector<short>>(Schema.GetOffset(0x3E367D0B2AA12BB2));
  }
  public ref CUtlVector<ushort> RemappingTableStarts {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x3E367D0BE4304DFB));
  }
  public ref CUtlVector BoneFlexDrivers {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x3E367D0B3670337F));
  }
  public IModelConfigList ModelConfigList {
    get => new CModelConfigList(_Handle + Schema.GetOffset(0x3E367D0B99085156));
  }
  public ref CUtlVector<CUtlString> BodyGroupsHiddenInTools {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0x3E367D0BE312FA8D));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCModel>> RefAnimIncludeModels {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCModel>>>(Schema.GetOffset(0x3E367D0BD99121D7));
  }
  public ref CUtlVector AnimatedMaterialAttributes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x3E367D0BC29D5124));
  }


}
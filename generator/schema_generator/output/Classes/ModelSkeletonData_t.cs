using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ModelSkeletonData_t : SchemaClass, IModelSkeletonData_t {

  public ModelSkeletonData_t(nint handle) : base(handle) {
  }

  public ModelSkeletonData_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CUtlString > BoneName {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0x8349B622FDEE0E0C));
  }
  public ref CUtlVector< int16 > Parent {
    get => ref _Handle.AsRef<CUtlVector< int16 >>(Schema.GetOffset(0x8349B6220AABB9D1));
  }
  public ref CUtlVector< float32 > BoneSphere {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x8349B6222F22FB5A));
  }
  public ref CUtlVector< uint32 > Flag {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0x8349B622CED32C4B));
  }
  public ref CUtlVector< Vector > BonePosParent {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0x8349B622E59E127F));
  }
  public ref CUtlVector< QuaternionStorage > BoneRotParent {
    get => ref _Handle.AsRef<CUtlVector< QuaternionStorage >>(Schema.GetOffset(0x8349B622A6E3A10C));
  }
  public ref CUtlVector< float32 > BoneScaleParent {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x8349B622FA2ED87F));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SkeletonAnimCapture_t : SchemaClass, ISkeletonAnimCapture_t {

  public SkeletonAnimCapture_t(nint handle) : base(handle) {
  }

  public SkeletonAnimCapture_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CEntityIndex EntIndex {
    get => ref _Handle.AsRef<CEntityIndex>(Schema.GetOffset(0x79FB6D7C5558C54A));
  }
  public ref CEntityIndex EntParent {
    get => ref _Handle.AsRef<CEntityIndex>(Schema.GetOffset(0x79FB6D7C7D9203A6));
  }
  public ref CUtlVector< CEntityIndex > ImportedCollision {
    get => ref _Handle.AsRef<CUtlVector< CEntityIndex >>(Schema.GetOffset(0x79FB6D7C5A900B2F));
  }
  public ref CUtlString ModelName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x79FB6D7CD7A1D881));
  }
  public ref CUtlString CaptureName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x79FB6D7CB508C2DA));
  }
  public ref CUtlVector< SkeletonAnimCapture_t::Bone_t > ModelBindPose {
    get => ref _Handle.AsRef<CUtlVector< SkeletonAnimCapture_t::Bone_t >>(Schema.GetOffset(0x79FB6D7C9960EBF8));
  }
  public ref CUtlVector< SkeletonAnimCapture_t::Bone_t > FeModelInitPose {
    get => ref _Handle.AsRef<CUtlVector< SkeletonAnimCapture_t::Bone_t >>(Schema.GetOffset(0x79FB6D7C0F3CC12E));
  }
  public ref int FlexControllers {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x79FB6D7C024CF17F));
  }
  public ref bool Predicted {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x79FB6D7C419B6D9B));
  }
  public ref CUtlVector< SkeletonAnimCapture_t::Frame_t > Frames {
    get => ref _Handle.AsRef<CUtlVector< SkeletonAnimCapture_t::Frame_t >>(Schema.GetOffset(0x79FB6D7CEA11EACF));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCachedPose : SchemaClass, ICachedPose {

  public CCachedPose(nint handle) : base(handle) {
  }

  public CCachedPose(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CTransform > Transforms {
    get => ref _Handle.AsRef<CUtlVector< CTransform >>(Schema.GetOffset(0x4B6C235988C82C58));
  }
  public ref CUtlVector< float32 > MorphWeights {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x4B6C23596B6689BE));
  }
  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0x4B6C2359E0A0598E));
  }
  public ref float Cycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4B6C23590C77829F));
  }


}
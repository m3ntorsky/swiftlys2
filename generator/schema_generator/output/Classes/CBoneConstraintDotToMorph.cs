using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneConstraintDotToMorph : CBoneConstraintBase, IBoneConstraintDotToMorph {

  public CBoneConstraintDotToMorph(nint handle) : base(handle) {
  }

  public CBoneConstraintDotToMorph(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString BoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x75939F077559AC1F));
  }
  public ref CUtlString TargetBoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x75939F07CBA1BE4A));
  }
  public ref CUtlString MorphChannelName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x75939F0777272AE4));
  }
  public ISchemaFixedArray<float32> Remap {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x75939F07BE3DB1A0));
  }


}
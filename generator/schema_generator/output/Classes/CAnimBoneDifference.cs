using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimBoneDifference : SchemaClass, IAnimBoneDifference {

  public CAnimBoneDifference(nint handle) : base(handle) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xCC65F41E4D8F5786));
  }
  public ref CBufferString Parent {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xCC65F41E2FF7A69D));
  }
  public ref Vector PosError {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xCC65F41E48F0F4CD));
  }
  public ref bool HasRotation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCC65F41E84FE2D9D));
  }
  public ref bool HasMovement {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCC65F41E07AC967A));
  }


}
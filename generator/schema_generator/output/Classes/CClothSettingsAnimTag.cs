using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CClothSettingsAnimTag : CAnimTagBase, IClothSettingsAnimTag {

  public CClothSettingsAnimTag(nint handle) : base(handle) {
  }

  public CClothSettingsAnimTag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Stiffness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF6B586864344C684));
  }
  public ref float EaseIn {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF6B586864514C026));
  }
  public ref float EaseOut {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF6B5868646B49C07));
  }
  public ref CUtlString VertexSet {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xF6B586863EE1A571));
  }


}
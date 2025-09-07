using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimUpdateNodeBase : SchemaClass, IAnimUpdateNodeBase {

  public CAnimUpdateNodeBase(nint handle) : base(handle) {
  }

  public CAnimUpdateNodeBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimNodePath NodePath {
    get => new CAnimNodePath(_Handle + Schema.GetOffset(0xA16B836B69EE5E4E));
  }
  public ref AnimNodeNetworkMode NetworkMode {
    get => ref _Handle.AsRef<AnimNodeNetworkMode>(Schema.GetOffset(0xA16B836BE3307112));
  }
  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xA16B836B4D8F5786));
  }


}
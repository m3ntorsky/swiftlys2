using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimComponentUpdater : SchemaClass, IAnimComponentUpdater {

  public CAnimComponentUpdater(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3E0F51C74D8F5786));
  }
  public IAnimComponentID Id {
    get => new AnimComponentID(_Handle + Schema.GetOffset(0x3E0F51C7B4B6E980));
  }
  public ref AnimNodeNetworkMode NetworkMode {
    get => ref _Handle.AsRef<AnimNodeNetworkMode>(Schema.GetOffset(0x3E0F51C7E3307112));
  }
  public ref bool StartEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3E0F51C7500D5C24));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqSeqDescFlag : SchemaClass, ISeqSeqDescFlag {

  public CSeqSeqDescFlag(nint handle) : base(handle) {
  }

  public ref bool Looping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80B25449B0D));
  }
  public ref bool Snap {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80B817324FD));
  }
  public ref bool Autoplay {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80BB136D8A8));
  }
  public ref bool Post {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80B5698A5A7));
  }
  public ref bool Hidden {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80B57D2DC99));
  }
  public ref bool Multi {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80B04A7F792));
  }
  public ref bool LegacyDelta {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80BADC37FD8));
  }
  public ref bool LegacyWorldspace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80BE598BF5C));
  }
  public ref bool LegacyCyclepose {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80B792D85FD));
  }
  public ref bool LegacyRealtime {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80B8D773F07));
  }
  public ref bool ModelDoc {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEF7A80B815FEAE4));
  }


}
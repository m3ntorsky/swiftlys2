using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEconWearable : CEconEntity, IEconWearable {

  public CEconWearable(nint handle) : base(handle) {
  }

  public ref int ForceSkin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x491C03F4E5817B39));
  }
  public ref bool AlwaysAllow {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x491C03F4AD06B805));
  }


}
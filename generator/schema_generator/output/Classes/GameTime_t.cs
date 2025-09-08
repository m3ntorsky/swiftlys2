using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class GameTime_t : SchemaClass, IGameTime_t {

  public GameTime_t(nint handle) : base(handle) {
  }

  public ref float Value {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1DBEBD4DDCB0894A));
  }


}
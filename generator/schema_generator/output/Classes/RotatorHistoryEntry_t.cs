using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RotatorHistoryEntry_t : SchemaClass, IRotatorHistoryEntry_t {

  public RotatorHistoryEntry_t(nint handle) : base(handle) {
  }

  public ref Quaternion InvChange {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0xB27D5BA9A4E4D41B));
  }
  public IGameTime_t TimeRotationStart {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xB27D5BA9A2B2E208));
  }


}
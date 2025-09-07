using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class IntervalTimer : SchemaClass, IIntervalTimer {

  public IntervalTimer(nint handle) : base(handle) {
  }

  public IntervalTimer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTime_t Timestamp {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8FD39659B6C56F43));
  }
  public ref WorldGroupId_t WorldGroupId {
    get => ref _Handle.AsRef<WorldGroupId_t>(Schema.GetOffset(0x8FD396597414B193));
  }

  public void TimestampUpdated() {
    Schema.Update(_Handle, 0x8FD39659B6C56F43);
  }
  public void WorldGroupIdUpdated() {
    Schema.Update(_Handle, 0x8FD396597414B193);
  }
}
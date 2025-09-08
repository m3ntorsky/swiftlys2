using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CountdownTimer : SchemaClass, ICountdownTimer {

  public CountdownTimer(nint handle) : base(handle) {
  }



  public void DurationUpdated() {
    Schema.Update(_Handle, 0x8A632F13D9FF5AD);
  }
  public void TimestampUpdated() {
    Schema.Update(_Handle, 0x8A632F1B6C56F43);
  }
  public void TimescaleUpdated() {
    Schema.Update(_Handle, 0x8A632F18A240BBE);
  }
  public void WorldGroupIdUpdated() {
    Schema.Update(_Handle, 0x8A632F17414B193);
  }
}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class IntervalTimer : SchemaClass, IIntervalTimer {

  public IntervalTimer(nint handle) : base(handle) {
  }



  public void TimestampUpdated() {
    Schema.Update(_Handle, 0x8FD39659B6C56F43);
  }
  public void WorldGroupIdUpdated() {
    Schema.Update(_Handle, 0x8FD396597414B193);
  }
}
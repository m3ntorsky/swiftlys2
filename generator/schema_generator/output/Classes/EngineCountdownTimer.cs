using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EngineCountdownTimer : SchemaClass, IEngineCountdownTimer {

  public EngineCountdownTimer(nint handle) : base(handle) {
  }



  public void DurationUpdated() {
    Schema.Update(_Handle, 0x3F0C5A433D9FF5AD);
  }
  public void TimestampUpdated() {
    Schema.Update(_Handle, 0x3F0C5A43B6C56F43);
  }
  public void TimescaleUpdated() {
    Schema.Update(_Handle, 0x3F0C5A438A240BBE);
  }
}
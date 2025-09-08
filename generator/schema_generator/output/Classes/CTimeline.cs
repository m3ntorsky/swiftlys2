using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTimeline : IntervalTimer, ITimeline {

  public CTimeline(nint handle) : base(handle) {
  }



  public void ValuesUpdated() {
    Schema.Update(_Handle, 0x36D1E6597BD8BFD5);
  }
  public void ValueCountsUpdated() {
    Schema.Update(_Handle, 0x36D1E65961EF23CA);
  }
  public void BucketCountUpdated() {
    Schema.Update(_Handle, 0x36D1E6596ACA5C8A);
  }
  public void IntervalUpdated() {
    Schema.Update(_Handle, 0x36D1E659320F7B8E);
  }
  public void FinalValueUpdated() {
    Schema.Update(_Handle, 0x36D1E659534A71BA);
  }
  public void CompressionTypeUpdated() {
    Schema.Update(_Handle, 0x36D1E6593FD9B909);
  }
  public void StoppedUpdated() {
    Schema.Update(_Handle, 0x36D1E6591C198C2E);
  }
}
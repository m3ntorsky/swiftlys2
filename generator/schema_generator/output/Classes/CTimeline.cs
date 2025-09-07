using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTimeline : IntervalTimer, ITimeline {

  public CTimeline(nint handle) : base(handle) {
  }

  public CTimeline(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<float32> Values {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x36D1E6597BD8BFD5));
  }
  public ISchemaFixedArray<int32> ValueCounts {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x36D1E65961EF23CA));
  }
  public ref int BucketCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x36D1E6596ACA5C8A));
  }
  public ref float Interval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x36D1E659320F7B8E));
  }
  public ref float FinalValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x36D1E659534A71BA));
  }
  public ref TimelineCompression_t CompressionType {
    get => ref _Handle.AsRef<TimelineCompression_t>(Schema.GetOffset(0x36D1E6593FD9B909));
  }
  public ref bool Stopped {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x36D1E6591C198C2E));
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
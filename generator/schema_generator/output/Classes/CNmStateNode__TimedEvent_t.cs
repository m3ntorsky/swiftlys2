using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmStateNode__TimedEvent_t : SchemaClass, INmStateNode__TimedEvent_t {

  public CNmStateNode__TimedEvent_t(nint handle) : base(handle) {
  }

  public CNmStateNode__TimedEvent_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x256373A95066900));
  }
  public ref float TimeValueSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x256373A3B175F1C));
  }
  public ref CNmStateNode::TimedEvent_t::Comparison_t ComparisionOperator {
    get => ref _Handle.AsRef<CNmStateNode::TimedEvent_t::Comparison_t>(Schema.GetOffset(0x256373A5C6D84A1));
  }


}
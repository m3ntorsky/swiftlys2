using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_LimitCount__InstanceState_t : SchemaClass, IPulseCell_LimitCount__InstanceState_t {

  public CPulseCell_LimitCount__InstanceState_t(nint handle) : base(handle) {
  }

  public ref int CurrentCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8CD3F919BE40B2AD));
  }


}
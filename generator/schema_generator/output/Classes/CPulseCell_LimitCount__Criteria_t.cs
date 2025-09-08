using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_LimitCount__Criteria_t : SchemaClass, IPulseCell_LimitCount__Criteria_t {

  public CPulseCell_LimitCount__Criteria_t(nint handle) : base(handle) {
  }

  public ref bool LimitCountPasses {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3B47B1B460A35826));
  }


}
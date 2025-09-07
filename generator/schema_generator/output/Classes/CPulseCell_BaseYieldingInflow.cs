using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_BaseYieldingInflow : CPulseCell_BaseFlow, IPulseCell_BaseYieldingInflow {

  public CPulseCell_BaseYieldingInflow(nint handle) : base(handle) {
  }

  public CPulseCell_BaseYieldingInflow(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}
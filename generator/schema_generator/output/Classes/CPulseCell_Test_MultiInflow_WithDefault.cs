using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Test_MultiInflow_WithDefault : CPulseCell_BaseFlow, IPulseCell_Test_MultiInflow_WithDefault {

  public CPulseCell_Test_MultiInflow_WithDefault(nint handle) : base(handle) {
  }

  public CPulseCell_Test_MultiInflow_WithDefault(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}
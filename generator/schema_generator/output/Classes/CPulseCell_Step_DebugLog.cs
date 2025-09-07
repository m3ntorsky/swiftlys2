using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Step_DebugLog : CPulseCell_BaseFlow, IPulseCell_Step_DebugLog {

  public CPulseCell_Step_DebugLog(nint handle) : base(handle) {
  }

  public CPulseCell_Step_DebugLog(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}
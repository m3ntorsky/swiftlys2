using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Step_TestDomainTracepoint : CPulseCell_BaseFlow, IPulseCell_Step_TestDomainTracepoint {

  public CPulseCell_Step_TestDomainTracepoint(nint handle) : base(handle) {
  }

  public CPulseCell_Step_TestDomainTracepoint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}
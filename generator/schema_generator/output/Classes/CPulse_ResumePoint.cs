using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_ResumePoint : CPulse_OutflowConnection, IPulse_ResumePoint {

  public CPulse_ResumePoint(nint handle) : base(handle) {
  }




}
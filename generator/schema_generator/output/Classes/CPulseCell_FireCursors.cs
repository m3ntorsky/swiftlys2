using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_FireCursors : CPulseCell_BaseYieldingInflow, IPulseCell_FireCursors {

  public CPulseCell_FireCursors(nint handle) : base(handle) {
  }

  public ref CUtlVector Outflows {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x9BFA034F8F0AFDF8));
  }
  public ref bool WaitForChildOutflows {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BFA034F3F8E29C6));
  }
  public IPulse_ResumePoint OnFinished {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x9BFA034F8D903E5E));
  }
  public IPulse_ResumePoint OnCanceled {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x9BFA034FF02162DB));
  }


}
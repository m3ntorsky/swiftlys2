using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_WaitForCursorsWithTagBase : CPulseCell_BaseYieldingInflow, IPulseCell_WaitForCursorsWithTagBase {

  public CPulseCell_WaitForCursorsWithTagBase(nint handle) : base(handle) {
  }

  public CPulseCell_WaitForCursorsWithTagBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CursorsAllowedToWait {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA8108DB0236617EC));
  }
  public IPulse_ResumePoint WaitComplete {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xA8108DB02C41AD97));
  }


}
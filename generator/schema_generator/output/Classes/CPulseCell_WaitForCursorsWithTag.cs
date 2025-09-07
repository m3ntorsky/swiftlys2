using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_WaitForCursorsWithTag : CPulseCell_WaitForCursorsWithTagBase, IPulseCell_WaitForCursorsWithTag {

  public CPulseCell_WaitForCursorsWithTag(nint handle) : base(handle) {
  }

  public CPulseCell_WaitForCursorsWithTag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool TagSelfWhenComplete {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x550BA6FDA17E8F0E));
  }
  public ref PulseCursorCancelPriority_t DesiredKillPriority {
    get => ref _Handle.AsRef<PulseCursorCancelPriority_t>(Schema.GetOffset(0x550BA6FD341BA991));
  }


}
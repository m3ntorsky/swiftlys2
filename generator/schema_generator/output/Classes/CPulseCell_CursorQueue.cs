using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_CursorQueue : CPulseCell_WaitForCursorsWithTagBase, IPulseCell_CursorQueue {

  public CPulseCell_CursorQueue(nint handle) : base(handle) {
  }

  public CPulseCell_CursorQueue(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CursorsAllowedToRunParallel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDAB7EC55AC04AAF9));
  }


}
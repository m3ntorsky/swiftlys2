using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmOverlayBlendTask : CNmBlendTaskBase, INmOverlayBlendTask {

  public CNmOverlayBlendTask(nint handle) : base(handle) {
  }

  public CNmOverlayBlendTask(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTaskStatusAnimTag : CAnimTagBase, ITaskStatusAnimTag {

  public CTaskStatusAnimTag(nint handle) : base(handle) {
  }

  public CTaskStatusAnimTag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}
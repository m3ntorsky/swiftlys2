using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootFallAnimTag : CAnimTagBase, IFootFallAnimTag {

  public CFootFallAnimTag(nint handle) : base(handle) {
  }

  public CFootFallAnimTag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref FootFallTagFoot_t Foot {
    get => ref _Handle.AsRef<FootFallTagFoot_t>(Schema.GetOffset(0xC142B61EEB2B8B39));
  }


}
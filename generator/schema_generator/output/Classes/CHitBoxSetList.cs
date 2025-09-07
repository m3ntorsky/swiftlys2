using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHitBoxSetList : SchemaClass, IHitBoxSetList {

  public CHitBoxSetList(nint handle) : base(handle) {
  }

  public CHitBoxSetList(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CHitBoxSet > HitBoxSets {
    get => ref _Handle.AsRef<CUtlVector< CHitBoxSet >>(Schema.GetOffset(0x2FE1303444ABBA1A));
  }


}
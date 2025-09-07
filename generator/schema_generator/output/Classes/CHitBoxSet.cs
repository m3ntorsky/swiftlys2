using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHitBoxSet : SchemaClass, IHitBoxSet {

  public CHitBoxSet(nint handle) : base(handle) {
  }

  public CHitBoxSet(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x742AE9EC4D8F5786));
  }
  public ref uint NameHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x742AE9ECDE15EEFE));
  }
  public ref CUtlVector< CHitBox > HitBoxes {
    get => ref _Handle.AsRef<CUtlVector< CHitBox >>(Schema.GetOffset(0x742AE9EC07A4113F));
  }
  public ref CUtlString SourceFilename {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x742AE9ECD49CE26D));
  }


}
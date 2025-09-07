using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SoundOpvarTraceResult_t : SchemaClass, ISoundOpvarTraceResult_t {

  public SoundOpvarTraceResult_t(nint handle) : base(handle) {
  }

  public SoundOpvarTraceResult_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Pos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xF93EB0CBE5D6FAFD));
  }
  public ref bool DidHit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF93EB0CBA8217B9F));
  }
  public ref float DistSqrToCenter {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF93EB0CB96618227));
  }


}
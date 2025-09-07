using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class LookAtBone_t : SchemaClass, ILookAtBone_t {

  public LookAtBone_t(nint handle) : base(handle) {
  }

  public LookAtBone_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Index {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x25E8B58A491963CB));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x25E8B58A07D0CD59));
  }


}
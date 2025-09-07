using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticleIndex_t : SchemaClass, IParticleIndex_t {

  public ParticleIndex_t(nint handle) : base(handle) {
  }

  public ParticleIndex_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA7ED25EEDCB0894A));
  }


}
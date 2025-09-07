using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticleAttributeIndex_t : SchemaClass, IParticleAttributeIndex_t {

  public ParticleAttributeIndex_t(nint handle) : base(handle) {
  }

  public ParticleAttributeIndex_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB44A6FC8DCB0894A));
  }


}
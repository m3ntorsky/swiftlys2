using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PhysicsParticleId_t : SchemaClass, IPhysicsParticleId_t {

  public PhysicsParticleId_t(nint handle) : base(handle) {
  }

  public ref uint Value {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xADF050DADCB0894A));
  }


}
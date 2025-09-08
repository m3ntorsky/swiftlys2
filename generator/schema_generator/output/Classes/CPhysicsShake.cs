using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysicsShake : SchemaClass, IPhysicsShake {

  public CPhysicsShake(nint handle) : base(handle) {
  }

  public ref Vector Force {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x904CE6CFB9B6AFA4));
  }


}
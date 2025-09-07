using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticleControlPointDriver_t : SchemaClass, IParticleControlPointDriver_t {

  public ParticleControlPointDriver_t(nint handle) : base(handle) {
  }

  public ParticleControlPointDriver_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB7C66843E9EC8FF5));
  }
  public ref ParticleAttachment_t AttachType {
    get => ref _Handle.AsRef<ParticleAttachment_t>(Schema.GetOffset(0xB7C66843432E8381));
  }
  public ref CUtlString AttachmentName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB7C66843295DA9CB));
  }
  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB7C66843BD25CC2A));
  }
  public ref QAngle Offset {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xB7C6684346F6B3C0));
  }
  public ref CUtlString EntityName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB7C6684380D1D3E1));
  }


}
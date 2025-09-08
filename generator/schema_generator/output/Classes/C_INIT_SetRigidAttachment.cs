using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_SetRigidAttachment : CParticleFunctionInitializer, IC_INIT_SetRigidAttachment {

  public C_INIT_SetRigidAttachment(nint handle) : base(handle) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF6F728143F31A6BD));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF6F72814AE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF6F72814E5729606));
  }
  public ref bool LocalSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6F7281462418E6E));
  }


}
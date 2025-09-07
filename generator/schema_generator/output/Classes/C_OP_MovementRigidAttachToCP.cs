using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MovementRigidAttachToCP : CParticleFunctionOperator, IC_OP_MovementRigidAttachToCP {

  public C_OP_MovementRigidAttachToCP(nint handle) : base(handle) {
  }

  public C_OP_MovementRigidAttachToCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D3A79B83F31A6BD));
  }
  public ref int ScaleControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D3A79B8B0577A70));
  }
  public ref int ScaleCPField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D3A79B8B4A19A82));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x3D3A79B8AE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x3D3A79B8E5729606));
  }
  public ref bool OffsetLocal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3D3A79B8F07D31C1));
  }


}
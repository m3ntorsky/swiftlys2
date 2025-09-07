using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetVariable : CParticleFunctionPreEmission, IC_OP_SetVariable {

  public C_OP_SetVariable(nint handle) : base(handle) {
  }

  public C_OP_SetVariable(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleVariableRef VariableReference {
    get => new CParticleVariableRef(_Handle + Schema.GetOffset(0x9BAC801F3731E65A));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x9BAC801F3A9ED669));
  }
  public ref Vector PositionOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9BAC801FC9C9DB1D));
  }
  public ref QAngle RotationOffset {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x9BAC801FD70314A4));
  }
  public IParticleCollectionVecInput Input {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x9BAC801F1EA0ED5B));
  }
  public IParticleCollectionFloatInput FloatInput {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x9BAC801F7107333B));
  }


}
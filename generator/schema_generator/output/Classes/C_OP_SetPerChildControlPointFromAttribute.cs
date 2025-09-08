using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetPerChildControlPointFromAttribute : CParticleFunctionOperator, IC_OP_SetPerChildControlPointFromAttribute {

  public C_OP_SetPerChildControlPointFromAttribute(nint handle) : base(handle) {
  }

  public ref int ChildGroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4217F56BE3F3C965));
  }
  public ref int FirstControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4217F56B72117650));
  }
  public ref int NumControlPoints {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4217F56B551EBC4F));
  }
  public ref int ParticleIncrement {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4217F56B73AF63D0));
  }
  public ref int FirstSourcePoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4217F56B9D7DC18E));
  }
  public ref bool NumBasedOnParticleCount {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4217F56B401CC5D0));
  }
  public IParticleAttributeIndex_t AttributeToRead {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4217F56BE0F61F9E));
  }
  public ref int CPField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4217F56B50B79876));
  }


}
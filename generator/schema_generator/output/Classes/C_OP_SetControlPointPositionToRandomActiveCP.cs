using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointPositionToRandomActiveCP : CParticleFunctionPreEmission, IC_OP_SetControlPointPositionToRandomActiveCP {

  public C_OP_SetControlPointPositionToRandomActiveCP(nint handle) : base(handle) {
  }

  public ref int CP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7B108D36D4B1E579));
  }
  public ref int HeadLocationMin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7B108D360E904014));
  }
  public ref int HeadLocationMax {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7B108D36FCA53E76));
  }
  public IParticleCollectionFloatInput ResetRate {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x7B108D369E741FFC));
  }


}
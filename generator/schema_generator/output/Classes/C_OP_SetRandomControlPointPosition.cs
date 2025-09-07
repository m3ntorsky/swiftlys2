using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetRandomControlPointPosition : CParticleFunctionPreEmission, IC_OP_SetRandomControlPointPosition {

  public C_OP_SetRandomControlPointPosition(nint handle) : base(handle) {
  }

  public C_OP_SetRandomControlPointPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool UseWorldLocation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4E797BEAF371AED7));
  }
  public ref bool Orient {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4E797BEA7CD61854));
  }
  public ref int CP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4E797BEAD4B1E579));
  }
  public ref int HeadLocation {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4E797BEAA8ECDA78));
  }
  public IParticleCollectionFloatInput ReRandomRate {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x4E797BEA98F44A13));
  }
  public ref Vector CPMinPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4E797BEA4E9C9B68));
  }
  public ref Vector CPMaxPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4E797BEA4FFBFD72));
  }
  public IParticleCollectionFloatInput Interpolation {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x4E797BEACF55B987));
  }


}
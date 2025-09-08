using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LockToPointList : CParticleFunctionOperator, IC_OP_LockToPointList {

  public C_OP_LockToPointList(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xC9237E67E5729606));
  }
  public ref CUtlVector PointList {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xC9237E67976AB4FD));
  }
  public ref bool PlaceAlongPath {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC9237E6781CF2E1A));
  }
  public ref bool ClosedLoop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC9237E677C20D1AB));
  }
  public ref int NumPointsAlongPath {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC9237E67ACB5FC8A));
  }


}
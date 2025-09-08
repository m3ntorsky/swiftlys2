using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_PointList : CParticleFunctionInitializer, IC_INIT_PointList {

  public C_INIT_PointList(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x5E193E54E5729606));
  }
  public ref CUtlVector PointList {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x5E193E54976AB4FD));
  }
  public ref bool PlaceAlongPath {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5E193E5481CF2E1A));
  }
  public ref bool ClosedLoop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5E193E547C20D1AB));
  }
  public ref int NumPointsAlongPath {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5E193E54ACB5FC8A));
  }


}
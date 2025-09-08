using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_WaterImpulseRenderer : CParticleFunctionRenderer, IC_OP_WaterImpulseRenderer {

  public C_OP_WaterImpulseRenderer(nint handle) : base(handle) {
  }

  public IPerParticleVecInput Pos {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x7CC87C0C3B18EB69));
  }
  public IPerParticleFloatInput Radius {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x7CC87C0C5ACFC08D));
  }
  public IPerParticleFloatInput Magnitude {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x7CC87C0CED0A1D8B));
  }
  public IPerParticleFloatInput Shape {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x7CC87C0C5DCE07D8));
  }
  public ref EventTypeSelection_t EventType {
    get => ref _Handle.AsRef<EventTypeSelection_t>(Schema.GetOffset(0x7CC87C0CE1F9AA93));
  }


}
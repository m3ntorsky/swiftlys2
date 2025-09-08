using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateInEpitrochoid : CParticleFunctionInitializer, IC_INIT_CreateInEpitrochoid {

  public C_INIT_CreateInEpitrochoid(nint handle) : base(handle) {
  }

  public ref int Component1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3B16C41F125ABCA7));
  }
  public ref int Component2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3B16C41F135ABE3A));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x3B16C41FB3FDC289));
  }
  public IPerParticleFloatInput ParticleDensity {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3B16C41FF720B9EF));
  }
  public IPerParticleFloatInput Offset {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3B16C41F7F14BA34));
  }
  public IPerParticleFloatInput Radius1 {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3B16C41FB10C67F4));
  }
  public IPerParticleFloatInput Radius2 {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3B16C41FB40C6CAD));
  }
  public ref bool UseCount {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3B16C41F8836B9AB));
  }
  public ref bool UseLocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3B16C41F8AB11575));
  }
  public ref bool OffsetExistingPos {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3B16C41F79DD329B));
  }


}
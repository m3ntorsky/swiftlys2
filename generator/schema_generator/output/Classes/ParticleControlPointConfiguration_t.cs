using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticleControlPointConfiguration_t : SchemaClass, IParticleControlPointConfiguration_t {

  public ParticleControlPointConfiguration_t(nint handle) : base(handle) {
  }

  public ParticleControlPointConfiguration_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xC54E49C74D8F5786));
  }
  public ref CUtlVector< ParticleControlPointDriver_t > Drivers {
    get => ref _Handle.AsRef<CUtlVector< ParticleControlPointDriver_t >>(Schema.GetOffset(0xC54E49C7C63563E4));
  }
  public IParticlePreviewState_t PreviewState {
    get => new ParticlePreviewState_t(_Handle + Schema.GetOffset(0xC54E49C79E440558));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderPostProcessing : CParticleFunctionRenderer, IC_OP_RenderPostProcessing {

  public C_OP_RenderPostProcessing(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput PostProcessStrength {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD64D179C653C1A17));
  }
  public ref CStrongHandle<InfoForResourceTypeCPostProcessingResource> PostTexture {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCPostProcessingResource>>(Schema.GetOffset(0xD64D179C943F8D28));
  }
  public ref ParticlePostProcessPriorityGroup_t Priority {
    get => ref _Handle.AsRef<ParticlePostProcessPriorityGroup_t>(Schema.GetOffset(0xD64D179CE7EFB335));
  }


}
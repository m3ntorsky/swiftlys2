using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderGpuImplicit : CParticleFunctionRenderer, IC_OP_RenderGpuImplicit {

  public C_OP_RenderGpuImplicit(nint handle) : base(handle) {
  }

  public ref bool UsePerParticleRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF780A8E2CB5B403));
  }
  public ref uint VertexCountKb {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xF780A8E6064907B));
  }
  public ref uint IndexCountKb {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xF780A8E6CDECFF7));
  }
  public IParticleCollectionRendererFloatInput GridSize {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xF780A8E456E2F5C));
  }
  public IParticleCollectionRendererFloatInput RadiusScale {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xF780A8E15F78967));
  }
  public IParticleCollectionRendererFloatInput IsosurfaceThreshold {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xF780A8E32E25824));
  }
  public ref int ScaleCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF780A8EDE3CC5E6));
  }
  public CStrongHandle<IInfoForResourceTypeIMaterial2> Material {
    get => new CStrongHandle<InfoForResourceTypeIMaterial2>(_Handle + Schema.GetOffset(0xF780A8E888CE42E));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderBlobs : CParticleFunctionRenderer, IC_OP_RenderBlobs {

  public C_OP_RenderBlobs(nint handle) : base(handle) {
  }

  public IParticleCollectionRendererFloatInput CubeWidth {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xB25239A3E172FDCC));
  }
  public IParticleCollectionRendererFloatInput CutoffRadius {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xB25239A33B9D5B46));
  }
  public IParticleCollectionRendererFloatInput RenderRadius {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xB25239A35157484B));
  }
  public ref uint VertexCountKb {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xB25239A36064907B));
  }
  public ref uint IndexCountKb {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xB25239A36CDECFF7));
  }
  public ref int ScaleCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB25239A3DE3CC5E6));
  }
  public ref CUtlVector MaterialVars {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xB25239A3FA861D66));
  }
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIMaterial2>>(Schema.GetOffset(0xB25239A3888CE42E));
  }


}
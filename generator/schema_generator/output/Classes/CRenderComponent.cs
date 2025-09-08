using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRenderComponent : CEntityComponent, IRenderComponent {

  public CRenderComponent(nint handle) : base(handle) {
  }

  public INetworkVarChainer __m_pChainEntity {
    get => new CNetworkVarChainer(_Handle + Schema.GetOffset(0x8830FA5F63F0E7D));
  }
  public ref bool IsRenderingWithViewModels {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8830FA5700AA428));
  }
  public ref uint SplitscreenFlags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x8830FA5CACF9032));
  }
  public ref bool EnableRendering {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8830FA50FAC7C5E));
  }
  public ref bool InterpolationReadyToDraw {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8830FA51A075A53));
  }


}
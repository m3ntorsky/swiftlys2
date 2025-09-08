using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvLaser : CBeam, IEnvLaser {

  public CEnvLaser(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge LaserTarget {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x83A2D3C8C257F4D));
  }
  public ISprite Sprite {
    get => new CSprite(_Handle + Schema.GetOffset(0x83A2D3CEFBFA166));
  }
  public ref CUtlSymbolLarge SpriteName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x83A2D3C096530FF));
  }
  public ref Vector FirePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x83A2D3C2A7C404E));
  }
  public ref float StartFrame {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x83A2D3CB534B906));
  }


}
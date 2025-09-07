using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvBeam : CBeam, IEnvBeam {

  public CEnvBeam(nint handle) : base(handle) {
  }

  public CEnvBeam(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Active {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x84C6714A8E29CBCF));
  }
  public ref CStrongHandle< InfoForResourceTypeIMaterial2 > SpriteTexture {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0x84C6714A095DE4B7));
  }
  public ref CUtlSymbolLarge StartEntity {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x84C6714AA162CA40));
  }
  public ref CUtlSymbolLarge EndEntity {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x84C6714A636BA021));
  }
  public ref float Life {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x84C6714AA5A4067F));
  }
  public ref float BoltWidth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x84C6714A165169F2));
  }
  public ref float NoiseAmplitude {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x84C6714A414FFA76));
  }
  public ref int Speed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x84C6714AA4BD35A0));
  }
  public ref float Restrike {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x84C6714A4647E3AA));
  }
  public ref CUtlSymbolLarge SpriteName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x84C6714A096530FF));
  }
  public ref int FrameStart {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x84C6714ABA4C58E6));
  }
  public ref Vector EndPointWorld {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x84C6714ADCC233A4));
  }
  public ref Vector EndPointRelative {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x84C6714AA25C0E48));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x84C6714AA921CA53));
  }
  public ref Touch_t TouchType {
    get => ref _Handle.AsRef<Touch_t>(Schema.GetOffset(0x84C6714A159DBEB0));
  }
  public ref CUtlSymbolLarge FilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x84C6714A09C86445));
  }
  public ref CHandle< CBaseEntity > Filter {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x84C6714A45D9E0B1));
  }
  public ref CUtlSymbolLarge Decal {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x84C6714AC8536FA6));
  }
  public IEntityIOOutput OnTouchedByEntity {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x84C6714ACB930C48));
  }


}
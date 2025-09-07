using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoWorldLayer : CBaseEntity, IInfoWorldLayer {

  public CInfoWorldLayer(nint handle) : base(handle) {
  }

  public CInfoWorldLayer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OutputOnEntitiesSpawned {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x74C9C61B31420D1E));
  }
  public ref CUtlSymbolLarge WorldName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x74C9C61B29890DD8));
  }
  public ref CUtlSymbolLarge LayerName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x74C9C61BEABDA295));
  }
  public ref bool WorldLayerVisible {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x74C9C61BA9B3715E));
  }
  public ref bool EntitiesSpawned {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x74C9C61BAEF9D6C8));
  }
  public ref bool CreateAsChildSpawnGroup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x74C9C61B6D553CD3));
  }
  public ref uint LayerSpawnGroup {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x74C9C61B56D4B70E));
  }

  public void WorldNameUpdated() {
    Schema.Update(_Handle, 0x74C9C61B29890DD8);
  }
  public void LayerNameUpdated() {
    Schema.Update(_Handle, 0x74C9C61BEABDA295);
  }
  public void WorldLayerVisibleUpdated() {
    Schema.Update(_Handle, 0x74C9C61BA9B3715E);
  }
  public void EntitiesSpawnedUpdated() {
    Schema.Update(_Handle, 0x74C9C61BAEF9D6C8);
  }
}
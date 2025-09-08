using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameRules : SchemaClass, IGameRules {

  public CGameRules(nint handle) : base(handle) {
  }

  public INetworkVarChainer __m_pChainEntity {
    get => new CNetworkVarChainer(_Handle + Schema.GetOffset(0x4807DA77F63F0E7D));
  }
  public ISchemaFixedString QuestName {
    get => new SchemaFixedString(_Handle, 0x4807DA7748F621A1, 128, 1, 1);
  }
  public ref int QuestPhase {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4807DA77335693EC));
  }

  public void TotalPausedTicksUpdated() {
    Schema.Update(_Handle, 0x4807DA7723281397);
  }
  public void PauseStartTickUpdated() {
    Schema.Update(_Handle, 0x4807DA77E64EC54A);
  }
  public void GamePausedUpdated() {
    Schema.Update(_Handle, 0x4807DA77582909A9);
  }
}
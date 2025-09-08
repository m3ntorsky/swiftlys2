using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSceneListManager : CLogicalEntity, ISceneListManager {

  public CSceneListManager(nint handle) : base(handle) {
  }

  public ref CUtlVector ListManagers {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x6DF51C6DAD7882DF));
  }
  public ISchemaFixedArray<CUtlSymbolLarge> Scenes {
    get => new SchemaFixedArray<CUtlSymbolLarge>(_Handle, 0x6DF51C6D967363E8, 16, 8, 8);
  }
  public CHandle<IBaseEntity> Scenes {
    get => new CHandle<CBaseEntity>(_Handle, 0x6DF51C6D2B7EE872, 16, 4, 4);
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSceneListManager : CLogicalEntity, ISceneListManager {

  public CSceneListManager(nint handle) : base(handle) {
  }

  public CSceneListManager(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CHandle< CSceneListManager > > ListManagers {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CSceneListManager > >>(Schema.GetOffset(0x6DF51C6DAD7882DF));
  }
  public ISchemaFixedArray<CUtlSymbolLarge> Scenes {
    get => new SchemaFixedArray<CUtlSymbolLarge>(_Handle + Schema.GetOffset(0x6DF51C6D967363E8));
  }
  public ISchemaFixedArray<CHandle< CBaseEntity >> Scenes {
    get => new SchemaFixedArray<CHandle< CBaseEntity >>(_Handle + Schema.GetOffset(0x6DF51C6D2B7EE872));
  }


}
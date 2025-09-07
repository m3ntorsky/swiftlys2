using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicBranch : CLogicalEntity, ILogicBranch {

  public CLogicBranch(nint handle) : base(handle) {
  }

  public CLogicBranch(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool InValue {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5B700E1052400A1F));
  }
  public ref CUtlVector< CHandle< CBaseEntity > > Listeners {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CBaseEntity > >>(Schema.GetOffset(0x5B700E10E4AECE86));
  }
  public IEntityIOOutput OnTrue {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5B700E106EAE5D88));
  }
  public IEntityIOOutput OnFalse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5B700E104973AF03));
  }


}
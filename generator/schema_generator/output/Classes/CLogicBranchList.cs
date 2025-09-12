using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicBranchList : CLogicalEntity, ILogicBranchList {

  public CLogicBranchList(nint handle) : base(handle) {
  }

  public ISchemaUntypedField LogicBranchNames {
    get => new SchemaUntypedField(_Handle, 0xB21E12B82C1677D7, 16, 8, 8);
  }
  public ref CUtlVector<CHandle<CBaseEntity>> LogicBranchList {
    get => ref _Handle.AsRef<CUtlVector<CHandle<CBaseEntity>>>(Schema.GetOffset(0xB21E12B8E4DEC285));
  }
  public ref CLogicBranchList::LogicBranchListenerLastState_t LastState {
    get => ref _Handle.AsRef<CLogicBranchList::LogicBranchListenerLastState_t>(Schema.GetOffset(0xB21E12B89A391AC5));
  }
  public IEntityIOOutput OnAllTrue {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xB21E12B8419FFFAF));
  }
  public IEntityIOOutput OnAllFalse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xB21E12B86EFCD332));
  }
  public IEntityIOOutput OnMixed {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xB21E12B8EBC72437));
  }


}
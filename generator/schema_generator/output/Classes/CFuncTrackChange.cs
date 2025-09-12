using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncTrackChange : CFuncPlatRot, IFuncTrackChange {

  public CFuncTrackChange(nint handle) : base(handle) {
  }

  public IPathTrack TrackTop {
    get => new CPathTrack(_Handle + Schema.GetOffset(0x25A8A26FF7C2CCBF));
  }
  public IPathTrack TrackBottom {
    get => new CPathTrack(_Handle + Schema.GetOffset(0x25A8A26F37EC7637));
  }
  public IFuncTrackTrain Train {
    get => new CFuncTrackTrain(_Handle + Schema.GetOffset(0x25A8A26FB8642689));
  }
  public ISchemaUntypedField TrackTopName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x25A8A26FF9BD489C));
  }
  public ISchemaUntypedField TrackBottomName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x25A8A26F7F34C2D4));
  }
  public ISchemaUntypedField TrainName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x25A8A26FA3DC4C82));
  }
  public ref TRAIN_CODE Code {
    get => ref _Handle.AsRef<TRAIN_CODE>(Schema.GetOffset(0x25A8A26FB70C9D94));
  }
  public ref int TargetState {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x25A8A26F9EA3444D));
  }
  public ref int Use {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x25A8A26F45B2B614));
  }


}
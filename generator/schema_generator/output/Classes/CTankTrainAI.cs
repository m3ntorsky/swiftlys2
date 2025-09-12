using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTankTrainAI : CPointEntity, ITankTrainAI {

  public CTankTrainAI(nint handle) : base(handle) {
  }

  public ref CHandle<CFuncTrackTrain> Train {
    get => ref _Handle.AsRef<CHandle<CFuncTrackTrain>>(Schema.GetOffset(0x25820826D58EE22F));
  }
  public ref CHandle<CBaseEntity> TargetEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x2582082625D042A9));
  }
  public ref int SoundPlaying {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2582082658CF60D2));
  }
  public ISchemaUntypedField StartSoundName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x258208263F1AB605));
  }
  public ISchemaUntypedField EngineSoundName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2582082627E36CD1));
  }
  public ISchemaUntypedField MovementSoundName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x25820826F2195774));
  }
  public ISchemaUntypedField TargetEntityName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x25820826F88EC878));
  }


}
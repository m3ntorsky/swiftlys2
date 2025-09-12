using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInstructorEventEntity : CPointEntity, IInstructorEventEntity {

  public CInstructorEventEntity(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Name {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DE6628874FF65FE));
  }
  public ISchemaUntypedField HintTargetEntity {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DE662880024C1BE));
  }
  public ref CHandle<CBasePlayerPawn> TargetPlayer {
    get => ref _Handle.AsRef<CHandle<CBasePlayerPawn>>(Schema.GetOffset(0x6DE66288BA425153));
  }


}
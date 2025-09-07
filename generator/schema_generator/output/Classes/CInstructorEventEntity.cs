using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInstructorEventEntity : CPointEntity, IInstructorEventEntity {

  public CInstructorEventEntity(nint handle) : base(handle) {
  }

  public CInstructorEventEntity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge Name {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x6DE6628874FF65FE));
  }
  public ref CUtlSymbolLarge HintTargetEntity {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x6DE662880024C1BE));
  }
  public ref CHandle< CBasePlayerPawn > TargetPlayer {
    get => ref _Handle.AsRef<CHandle< CBasePlayerPawn >>(Schema.GetOffset(0x6DE66288BA425153));
  }


}
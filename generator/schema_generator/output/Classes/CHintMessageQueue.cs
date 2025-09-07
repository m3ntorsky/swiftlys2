using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHintMessageQueue : SchemaClass, IHintMessageQueue {

  public CHintMessageQueue(nint handle) : base(handle) {
  }

  public CHintMessageQueue(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float TmMessageEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBE13489745AC0F6));
  }
  public ref CUtlVector< CHintMessage* > Messages {
    get => ref _Handle.AsRef<CUtlVector< CHintMessage* >>(Schema.GetOffset(0xBE134896139CC55));
  }
  public IBasePlayerController PlayerController {
    get => new CBasePlayerController(_Handle + Schema.GetOffset(0xBE13489DCE6762E));
  }


}
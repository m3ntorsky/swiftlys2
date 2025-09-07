using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicGameEvent : CLogicalEntity, ILogicGameEvent {

  public CLogicGameEvent(nint handle) : base(handle) {
  }

  public CLogicGameEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge EventName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xBED9751E78114A54));
  }


}
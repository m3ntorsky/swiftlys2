using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicEventListener : CLogicalEntity, ILogicEventListener {

  public CLogicEventListener(nint handle) : base(handle) {
  }

  public CLogicEventListener(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString StrEventName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD797C990BC41C13B));
  }
  public ref bool IsEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD797C9905360D70E));
  }
  public ref int Team {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD797C990BEB42230));
  }
  public IEntityIOOutput OnEventFired {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD797C990E84EA158));
  }


}
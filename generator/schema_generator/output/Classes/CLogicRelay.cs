using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicRelay : CLogicalEntity, ILogicRelay {

  public CLogicRelay(nint handle) : base(handle) {
  }

  public CLogicRelay(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x15CFD4B93A7C5965));
  }
  public ref bool WaitForRefire {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x15CFD4B9AB85983A));
  }
  public ref bool TriggerOnce {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x15CFD4B981D75586));
  }
  public ref bool FastRetrigger {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x15CFD4B91AD2302E));
  }
  public ref bool PassthoughCaller {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x15CFD4B969DA94C8));
  }


}
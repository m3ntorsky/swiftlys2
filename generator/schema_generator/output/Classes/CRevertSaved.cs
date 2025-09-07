using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRevertSaved : CModelPointEntity, IRevertSaved {

  public CRevertSaved(nint handle) : base(handle) {
  }

  public CRevertSaved(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float LoadTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E0EAC0F9925A540));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E0EAC0F9879A98D));
  }
  public ref float HoldTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E0EAC0F105A1BF1));
  }


}
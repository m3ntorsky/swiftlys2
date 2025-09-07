using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDirectPlaybackUpdateNode : CUnaryUpdateNode, IDirectPlaybackUpdateNode {

  public CDirectPlaybackUpdateNode(nint handle) : base(handle) {
  }

  public CDirectPlaybackUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool FinishEarly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4E1CBFEFC2E75991));
  }
  public ref bool ResetOnFinish {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4E1CBFEFD5293C96));
  }
  public ref CUtlVector< CDirectPlaybackTagData > AllTags {
    get => ref _Handle.AsRef<CUtlVector< CDirectPlaybackTagData >>(Schema.GetOffset(0x4E1CBFEF7A57C5AD));
  }


}
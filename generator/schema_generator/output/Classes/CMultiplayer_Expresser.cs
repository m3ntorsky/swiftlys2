using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMultiplayer_Expresser : CAI_ExpresserWithFollowup, IMultiplayer_Expresser {

  public CMultiplayer_Expresser(nint handle) : base(handle) {
  }

  public CMultiplayer_Expresser(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool AllowMultipleScenes {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x19772F22AE5FCD97));
  }


}
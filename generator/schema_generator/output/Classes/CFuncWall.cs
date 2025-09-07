using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncWall : CBaseModelEntity, IFuncWall {

  public CFuncWall(nint handle) : base(handle) {
  }

  public CFuncWall(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int State {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8F4C70C07C824322));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncVPhysicsClip : CBaseModelEntity, IFuncVPhysicsClip {

  public CFuncVPhysicsClip(nint handle) : base(handle) {
  }

  public CFuncVPhysicsClip(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE695DCD93A7C5965));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRotDoor : CBaseDoor, IRotDoor {

  public CRotDoor(nint handle) : base(handle) {
  }

  public CRotDoor(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool SolidBsp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x175D110BA50CEC89));
  }


}
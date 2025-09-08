using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathAnimMotorUpdaterBase : CAnimMotorUpdaterBase, IPathAnimMotorUpdaterBase {

  public CPathAnimMotorUpdaterBase(nint handle) : base(handle) {
  }

  public ref bool LockToPath {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x165EE5771F2F0960));
  }


}
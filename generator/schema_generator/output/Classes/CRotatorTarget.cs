using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRotatorTarget : CPointEntity, IRotatorTarget {

  public CRotatorTarget(nint handle) : base(handle) {
  }

  public CRotatorTarget(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnArrivedAt {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x448D6B2611C20554));
  }
  public ref RotatorTargetSpace_t Space {
    get => ref _Handle.AsRef<RotatorTargetSpace_t>(Schema.GetOffset(0x448D6B26A8FD0676));
  }


}
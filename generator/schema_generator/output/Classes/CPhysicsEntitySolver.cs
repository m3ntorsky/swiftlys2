using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysicsEntitySolver : CLogicalEntity, IPhysicsEntitySolver {

  public CPhysicsEntitySolver(nint handle) : base(handle) {
  }

  public CPhysicsEntitySolver(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBaseEntity > MovingEntity {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x2948C36FC1DA080E));
  }
  public ref CHandle< CBaseEntity > PhysicsBlocker {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x2948C36F3DD8AB5E));
  }
  public ref float SeparationDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2948C36F202FE0BD));
  }
  public IGameTime_t CancelTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x2948C36F12944512));
  }


}
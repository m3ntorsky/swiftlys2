using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncTrain : CBasePlatTrain, IFuncTrain {

  public CFuncTrain(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> CurrentTarget {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xAAD8EE8EBD175911));
  }
  public ref bool Activated {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAAD8EE8E4337A09C));
  }
  public ref CHandle<CBaseEntity> Enemy {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xAAD8EE8E430EC2D5));
  }
  public ref float BlockDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAAD8EE8EA5348091));
  }
  public IGameTime_t NextBlockTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xAAD8EE8E82BC1902));
  }
  public ref CUtlSymbolLarge LastTarget {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xAAD8EE8ECF22FD34));
  }


}
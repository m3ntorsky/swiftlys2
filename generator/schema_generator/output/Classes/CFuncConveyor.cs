using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncConveyor : CBaseModelEntity, IFuncConveyor {

  public CFuncConveyor(nint handle) : base(handle) {
  }

  public CFuncConveyor(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge ConveyorModels {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x6E29EBA973AE4DBB));
  }
  public ref float TransitionDurationSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6E29EBA9D5E92B1D));
  }
  public ref QAngle MoveEntitySpace {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x6E29EBA9325319F9));
  }
  public ref Vector MoveDirEntitySpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6E29EBA98181512A));
  }
  public ref float TargetSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6E29EBA99C627845));
  }
  public IGameTick_t TransitionStartTick {
    get => new GameTick_t(_Handle + Schema.GetOffset(0x6E29EBA9FB464AF3));
  }
  public ref int TransitionDurationTicks {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6E29EBA9B99437D4));
  }
  public ref float TransitionStartSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6E29EBA97456F6D7));
  }
  public ref CUtlVector< CHandle< CBaseEntity > > ConveyorModels {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CBaseEntity > >>(Schema.GetOffset(0x6E29EBA9BAB755A8));
  }

  public void MoveDirEntitySpaceUpdated() {
    Schema.Update(_Handle, 0x6E29EBA98181512A);
  }
  public void TargetSpeedUpdated() {
    Schema.Update(_Handle, 0x6E29EBA99C627845);
  }
  public void TransitionStartTickUpdated() {
    Schema.Update(_Handle, 0x6E29EBA9FB464AF3);
  }
  public void TransitionDurationTicksUpdated() {
    Schema.Update(_Handle, 0x6E29EBA9B99437D4);
  }
  public void TransitionStartSpeedUpdated() {
    Schema.Update(_Handle, 0x6E29EBA97456F6D7);
  }
  public void ConveyorModelsUpdated() {
    Schema.Update(_Handle, 0x6E29EBA9BAB755A8);
  }
}
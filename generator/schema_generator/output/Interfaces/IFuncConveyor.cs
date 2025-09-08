using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncConveyor : IBaseModelEntity {

  public ref CUtlSymbolLarge ConveyorModels { get; }
  
  public ref float TransitionDurationSeconds { get; }
  
  public ref QAngle MoveEntitySpace { get; }
  
  public ref Vector MoveDirEntitySpace { get; }
  
  public ref float TargetSpeed { get; }
  
  public IGameTick_t TransitionStartTick { get; }
  
  public ref int TransitionDurationTicks { get; }
  
  public ref float TransitionStartSpeed { get; }
  
  public ref CUtlVector ConveyorModels { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITimerEntity : ILogicalEntity {

  
  public IEntityIOOutput OnTimer { get; }
  
  public IEntityIOOutput OnTimerHigh { get; }
  
  public IEntityIOOutput OnTimerLow { get; }
  
  public ref int Disabled { get; }
  
  public ref float InitialDelay { get; }
  
  public ref float RefireTime { get; }
  
  public ref bool UpDownState { get; }
  
  public ref int UseRandomTime { get; }
  
  public ref bool PauseAfterFiring { get; }
  
  public ref float LowerRandomBound { get; }
  
  public ref float UpperRandomBound { get; }
  
  public ref float RemainingTime { get; }
  
  public ref bool Paused { get; }
}
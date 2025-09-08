using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFishPool : IBaseEntity {

  public ref int FishCount { get; }
  
  public ref float MaxRange { get; }
  
  public ref float SwimDepth { get; }
  
  public ref float WaterLevel { get; }
  
  public ref bool IsDormant { get; }
  
  public ref CUtlVector<CHandle<CFish>> Fishes { get; }
  
  public ICountdownTimer VisTimer { get; }
  
}
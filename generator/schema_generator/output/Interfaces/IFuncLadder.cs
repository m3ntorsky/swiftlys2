using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncLadder : IBaseModelEntity {

  
  public ref Vector LadderDir { get; }
  
  public ref CUtlVector<CHandle<CInfoLadderDismount>> Dismounts { get; }
  
  public ref Vector LocalTop { get; }
  
  public ref Vector PlayerMountPositionTop { get; }
  
  public ref Vector PlayerMountPositionBottom { get; }
  
  public ref float AutoRideSpeed { get; }
  
  public ref bool Disabled { get; }
  
  public ref bool FakeLadder { get; }
  
  public ref bool HasSlack { get; }
  
  public ref CUtlSymbolLarge SurfacePropName { get; }
  
  public IEntityIOOutput OnPlayerGotOnLadder { get; }
  
  public IEntityIOOutput OnPlayerGotOffLadder { get; }
}
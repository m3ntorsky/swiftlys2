using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoFan : IPointEntity {

  
  public ref float FanForceMaxRadius { get; }
  
  public ref float FanForceMinRadius { get; }
  
  public ref float CurveDistRange { get; }
  
  public ref CUtlSymbolLarge FanForceCurveString { get; }
}
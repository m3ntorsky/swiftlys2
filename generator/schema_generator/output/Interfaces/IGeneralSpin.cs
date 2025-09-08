using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGeneralSpin : IParticleFunctionOperator {

  public ref int SpinRateDegrees { get; }
  
  public ref int SpinRateMinDegrees { get; }
  
  public ref float SpinRateStopTime { get; }
  
}
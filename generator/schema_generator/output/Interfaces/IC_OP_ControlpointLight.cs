using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ControlpointLight : IParticleFunctionOperator {

  public ref float Scale { get; }
  
  public ref int ControlPoint1 { get; }
  
  public ref int ControlPoint2 { get; }
  
  public ref int ControlPoint3 { get; }
  
  public ref int ControlPoint4 { get; }
  
  public ref Vector CPOffset1 { get; }
  
  public ref Vector CPOffset2 { get; }
  
  public ref Vector CPOffset3 { get; }
  
  public ref Vector CPOffset4 { get; }
  
  public ref float LightFiftyDist1 { get; }
  
  public ref float LightZeroDist1 { get; }
  
  public ref float LightFiftyDist2 { get; }
  
  public ref float LightZeroDist2 { get; }
  
  public ref float LightFiftyDist3 { get; }
  
  public ref float LightZeroDist3 { get; }
  
  public ref float LightFiftyDist4 { get; }
  
  public ref float LightZeroDist4 { get; }
  
  public ref Color LightColor1 { get; }
  
  public ref Color LightColor2 { get; }
  
  public ref Color LightColor3 { get; }
  
  public ref Color LightColor4 { get; }
  
  public ref bool LightType1 { get; }
  
  public ref bool LightType2 { get; }
  
  public ref bool LightType3 { get; }
  
  public ref bool LightType4 { get; }
  
  public ref bool LightDynamic1 { get; }
  
  public ref bool LightDynamic2 { get; }
  
  public ref bool LightDynamic3 { get; }
  
  public ref bool LightDynamic4 { get; }
  
  public ref bool UseNormal { get; }
  
  public ref bool UseHLambert { get; }
  
  public ref bool ClampLowerRange { get; }
  
  public ref bool ClampUpperRange { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBuoyancyHelper : ISchemaClass {

  
  public ref CUtlStringToken FluidType { get; }
  
  public ref float FluidDensity { get; }
  
  public ref float NeutrallyBuoyantGravity { get; }
  
  public ref float NeutrallyBuoyantLinearDamping { get; }
  
  public ref float NeutrallyBuoyantAngularDamping { get; }
  
  public ref bool NeutrallyBuoyant { get; }
  
  public ref CUtlVector<float> FractionOfWheelSubmergedForWheelFriction { get; }
  
  public ref CUtlVector<float> WheelFrictionScales { get; }
  
  public ref CUtlVector<float> FractionOfWheelSubmergedForWheelDrag { get; }
  
  public ref CUtlVector<float> WheelDrag { get; }
}
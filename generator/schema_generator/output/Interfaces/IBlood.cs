using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBlood : IPointEntity {

  public ref QAngle SprayAngles { get; }
  
  public ref Vector SprayDir { get; }
  
  public ref float Amount { get; }
  
  public ref BloodType Color { get; }
  
}
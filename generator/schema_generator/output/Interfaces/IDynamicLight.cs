using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDynamicLight : IBaseModelEntity {

  public ref byte ActualFlags { get; }
  
  public ref byte Flags { get; }
  
  public ref byte LightStyle { get; }
  
  public ref bool On { get; }
  
  public ref float Radius { get; }
  
  public ref int Exponent { get; }
  
  public ref float InnerAngle { get; }
  
  public ref float OuterAngle { get; }
  
  public ref float SpotRadius { get; }
  
}
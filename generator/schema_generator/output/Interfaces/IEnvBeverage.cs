using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvBeverage : IBaseEntity {

  public ref bool CanInDispenser { get; }
  
  public ref int BeverageType { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IIronSightController : ISchemaClass {

  
  public ref bool IronSightAvailable { get; }
  
  public ref float IronSightAmount { get; }
  
  public ref float IronSightAmountGained { get; }
  
  public ref float IronSightAmountBiased { get; }
}
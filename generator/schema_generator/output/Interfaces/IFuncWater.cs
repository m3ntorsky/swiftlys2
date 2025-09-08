using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncWater : IBaseModelEntity {

  public IBuoyancyHelper BuoyancyHelper { get; }
  
}
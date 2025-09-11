using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncWall : IBaseModelEntity {

  
  public ref int State { get; }
}
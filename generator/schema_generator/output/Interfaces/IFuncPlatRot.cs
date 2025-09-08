using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncPlatRot : IFuncPlat {

  public ref QAngle End { get; }
  
  public ref QAngle Start { get; }
  
}
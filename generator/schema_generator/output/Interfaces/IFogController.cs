using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFogController : IBaseEntity {

  
  public Ifogparams_t Fog { get; }
  
  public ref bool UseAngles { get; }
  
  public ref int ChangedVariables { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IResponseQueue : ISchemaClass {

  public ref CUtlVector<PointerTo<CAI_Expresser>> ExpresserTargets { get; }
  
}
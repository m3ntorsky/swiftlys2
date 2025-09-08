using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVariableInfo_t : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref CUtlStringToken NameToken { get; }
  
  public IFuseVariableIndex_t Index { get; }
  
  public ref byte NumComponents { get; }
  
  public ref FuseVariableType_t VarType { get; }
  
  public ref FuseVariableAccess_t Access { get; }
  
}
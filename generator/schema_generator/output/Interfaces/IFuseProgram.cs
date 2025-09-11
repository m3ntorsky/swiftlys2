using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuseProgram : ISchemaClass {

  
  public ref CUtlVector<byte> ProgramBuffer { get; }
  
// CUtlVector< FuseVariableIndex_t >
  public ref CUtlVector VariablesRead { get; }
  
// CUtlVector< FuseVariableIndex_t >
  public ref CUtlVector VariablesWritten { get; }
  
  public ref int MaxTempVarsUsed { get; }
}
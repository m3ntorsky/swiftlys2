using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuseProgram : ISchemaClass {

  public ref CUtlVector<byte> ProgramBuffer { get; }
  
  public ref CUtlVector VariablesRead { get; }
  
  public ref CUtlVector VariablesWritten { get; }
  
  public ref int MaxTempVarsUsed { get; }
  
}
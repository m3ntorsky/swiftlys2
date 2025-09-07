using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuseProgram : SchemaClass, IFuseProgram {

  public CFuseProgram(nint handle) : base(handle) {
  }

  public CFuseProgram(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< uint8 > ProgramBuffer {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x81E69119349962E1));
  }
  public ref CUtlVector< FuseVariableIndex_t > VariablesRead {
    get => ref _Handle.AsRef<CUtlVector< FuseVariableIndex_t >>(Schema.GetOffset(0x81E691194C160BEA));
  }
  public ref CUtlVector< FuseVariableIndex_t > VariablesWritten {
    get => ref _Handle.AsRef<CUtlVector< FuseVariableIndex_t >>(Schema.GetOffset(0x81E69119E9491C49));
  }
  public ref int MaxTempVarsUsed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x81E69119981A1518));
  }


}
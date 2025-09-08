using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuseProgram : SchemaClass, IFuseProgram {

  public CFuseProgram(nint handle) : base(handle) {
  }

  public ref CUtlVector<byte> ProgramBuffer {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x81E69119349962E1));
  }
  public ref CUtlVector VariablesRead {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x81E691194C160BEA));
  }
  public ref CUtlVector VariablesWritten {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x81E69119E9491C49));
  }
  public ref int MaxTempVarsUsed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x81E69119981A1518));
  }


}
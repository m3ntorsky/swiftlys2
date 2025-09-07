using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_Chunk : SchemaClass, IPulse_Chunk {

  public CPulse_Chunk(nint handle) : base(handle) {
  }

  public CPulse_Chunk(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlLeanVector< PGDInstruction_t > Instructions {
    get => ref _Handle.AsRef<CUtlLeanVector< PGDInstruction_t >>(Schema.GetOffset(0x816932094D358BC4));
  }
  public ref CUtlLeanVector< CPulse_RegisterInfo > Registers {
    get => ref _Handle.AsRef<CUtlLeanVector< CPulse_RegisterInfo >>(Schema.GetOffset(0x81693209BB828A49));
  }
  public ref CUtlLeanVector< PulseDocNodeID_t > InstructionEditorIDs {
    get => ref _Handle.AsRef<CUtlLeanVector< PulseDocNodeID_t >>(Schema.GetOffset(0x81693209236D8B64));
  }


}
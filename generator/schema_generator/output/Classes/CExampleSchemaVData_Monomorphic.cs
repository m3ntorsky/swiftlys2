using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CExampleSchemaVData_Monomorphic : SchemaClass, IExampleSchemaVData_Monomorphic {

  public CExampleSchemaVData_Monomorphic(nint handle) : base(handle) {
  }

  public ref int Example1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x43DB481BF8CF69BC));
  }
  public ref int Example2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x43DB481BFBCF6E75));
  }


}
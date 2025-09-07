using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CExampleSchemaVData_PolymorphicDerivedB : CExampleSchemaVData_PolymorphicBase, IExampleSchemaVData_PolymorphicDerivedB {

  public CExampleSchemaVData_PolymorphicDerivedB(nint handle) : base(handle) {
  }

  public CExampleSchemaVData_PolymorphicDerivedB(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int DerivedB {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2A5BE585B46A6150));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CExampleSchemaVData_PolymorphicDerivedA : CExampleSchemaVData_PolymorphicBase, IExampleSchemaVData_PolymorphicDerivedA {

  public CExampleSchemaVData_PolymorphicDerivedA(nint handle) : base(handle) {
  }

  public ref int DerivedA {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x275BE0CCB76A6609));
  }


}
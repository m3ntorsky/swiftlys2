using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CExampleSchemaVData_PolymorphicBase : SchemaClass, IExampleSchemaVData_PolymorphicBase {

  public CExampleSchemaVData_PolymorphicBase(nint handle) : base(handle) {
  }

  public ref int Base {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2CEB124160282B7C));
  }


}
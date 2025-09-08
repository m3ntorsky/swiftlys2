using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphModelBinding : SchemaClass, IAnimGraphModelBinding {

  public CAnimGraphModelBinding(nint handle) : base(handle) {
  }

  public ref CUtlString ModelName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xC0F296335D35B6E1));
  }
  public ISchemaUntypedField SharedData {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC0F29633D0085FE6));
  }


}
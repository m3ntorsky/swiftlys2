using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMathColorBlend : CLogicalEntity, IMathColorBlend {

  public CMathColorBlend(nint handle) : base(handle) {
  }

  public ref float InMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCC5E3EF67506C6C8));
  }
  public ref float InMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCC5E3EF66B1BD1C2));
  }
  public ref Color OutColor1 {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xCC5E3EF639D7D5AD));
  }
  public ref Color OutColor2 {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xCC5E3EF636D7D0F4));
  }
  public ISchemaUntypedField OutValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCC5E3EF6B5358CB4));
  }


}
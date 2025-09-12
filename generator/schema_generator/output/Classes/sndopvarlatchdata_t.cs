using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class sndopvarlatchdata_t : SchemaClass, Isndopvarlatchdata_t {

  public sndopvarlatchdata_t(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Stack {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8347C0D511ACB037));
  }
  public ISchemaUntypedField Operator {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8347C0D55D107B55));
  }
  public ISchemaUntypedField Opvar {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8347C0D508A9F41F));
  }
  public ref float Val {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8347C0D5E31D0C86));
  }
  public ref Vector Pos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8347C0D5DE9CFC5D));
  }


}
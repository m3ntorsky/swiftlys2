using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRegisterMap_t : SchemaClass, IPulseRegisterMap_t {

  public PulseRegisterMap_t(nint handle) : base(handle) {
  }

  public PulseRegisterMap_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Inparams {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x833FEA64B9B18E04));
  }
  public ISchemaUntypedField InparamsWhichCanBeMoved {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x833FEA6405245E23));
  }
  public ISchemaUntypedField Outparams {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x833FEA64798D964D));
  }


}
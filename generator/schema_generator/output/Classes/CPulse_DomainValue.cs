using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_DomainValue : SchemaClass, IPulse_DomainValue {

  public CPulse_DomainValue(nint handle) : base(handle) {
  }

  public CPulse_DomainValue(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref PulseDomainValueType_t Type {
    get => ref _Handle.AsRef<PulseDomainValueType_t>(Schema.GetOffset(0x8F29D60118853D59));
  }
  public ref CGlobalSymbolCaseSensitive Value {
    get => ref _Handle.AsRef<CGlobalSymbolCaseSensitive>(Schema.GetOffset(0x8F29D601DCB0894A));
  }
  public ISchemaUntypedField RequiredRuntimeType {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8F29D6013355393C));
  }


}
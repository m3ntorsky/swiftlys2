using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmParameterizedBlendNode__BlendRange_t : SchemaClass, INmParameterizedBlendNode__BlendRange_t {

  public CNmParameterizedBlendNode__BlendRange_t(nint handle) : base(handle) {
  }

  public CNmParameterizedBlendNode__BlendRange_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputIdx0 {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x17812ECC5A8983D2));
  }
  public ref short InputIdx1 {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x17812ECC5B898565));
  }
  public ISchemaUntypedField ParameterValueRange {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x17812ECC64AF37AE));
  }


}
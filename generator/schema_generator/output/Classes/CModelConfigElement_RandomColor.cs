using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_RandomColor : CModelConfigElement, IModelConfigElement_RandomColor {

  public CModelConfigElement_RandomColor(nint handle) : base(handle) {
  }

  public CModelConfigElement_RandomColor(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Gradient {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x375CC66605C95F25));
  }


}
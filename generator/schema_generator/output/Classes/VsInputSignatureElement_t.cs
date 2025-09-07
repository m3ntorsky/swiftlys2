using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VsInputSignatureElement_t : SchemaClass, IVsInputSignatureElement_t {

  public VsInputSignatureElement_t(nint handle) : base(handle) {
  }

  public VsInputSignatureElement_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedString Name {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xFD3BBE5B5B47C92C));
  }
  public ISchemaFixedString Semantic {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xFD3BBE5B14684E6F));
  }
  public ISchemaFixedString D3DSemanticName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xFD3BBE5B66524995));
  }
  public ref int D3DSemanticIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xFD3BBE5B67F2BA80));
  }


}